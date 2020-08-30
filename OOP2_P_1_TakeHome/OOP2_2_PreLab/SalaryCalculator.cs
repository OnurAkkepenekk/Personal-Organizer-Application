using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2_2_PreLab
{
    public partial class SalaryCalculator : Form
    {
        public SalaryCalculator()
        {
            InitializeComponent();
        }
        public string path = "mydb.csv";
        User user = LoginedUser.getInstance().UserGetSet;
        private void button1_Click(object sender, EventArgs e)
        {
            double initialSalary = 4500;
            double experience = 0.00;
            double city = 0.00;
            double higher_education = 0.00;
            double foreign_Language_Knowledge = 0.00;
            double management_Task = 0.00;
            double Family_Status = 0.00;
            try
            {
                //Experience
                if (cmbBoxExperience.SelectedItem.ToString() == "2-4 Years")
                {
                    experience = 0.60;
                }
                else if (cmbBoxExperience.SelectedItem.ToString() == "5-9 Years")
                {
                    experience = 1.00;
                }
                else if (cmbBoxExperience.SelectedItem.ToString() == "10-14 Years")
                {
                    experience = 1.20;
                }
                else if (cmbBoxExperience.SelectedItem.ToString() == "15-20 Years")
                {
                    experience = 1.35;
                }
                else if (cmbBoxExperience.SelectedItem.ToString() == "20+ Years")
                {
                    experience = 1.50;
                }
                //City
                if (cmbBoxCity.SelectedItem.ToString() == "İstanbul")
                {
                    city = 0.15;
                }
                else if (cmbBoxCity.SelectedItem.ToString() == "Ankara" || cmbBoxCity.SelectedItem.ToString() == "İzmir")
                {
                    city = 0.10;
                }
                else if (cmbBoxCity.SelectedItem.ToString() == "Kocaeli" || cmbBoxCity.SelectedItem.ToString() == "Sakarya" || cmbBoxCity.SelectedItem.ToString() == "Düzce" || cmbBoxCity.SelectedItem.ToString() == "Bolu" || cmbBoxCity.SelectedItem.ToString() == "Yalova" || cmbBoxCity.SelectedItem.ToString() == "Edirne" || cmbBoxCity.SelectedItem.ToString() == "Kırklareli" || cmbBoxCity.SelectedItem.ToString() == "Tekirdağ")
                {
                    city = 0.05;
                }
                else if (cmbBoxCity.SelectedItem.ToString() == "Trabzon" || cmbBoxCity.SelectedItem.ToString() == "Ordu" || cmbBoxCity.SelectedItem.ToString() == "Giresun" || cmbBoxCity.SelectedItem.ToString() == "Rize" || cmbBoxCity.SelectedItem.ToString() == "Artvin" || cmbBoxCity.SelectedItem.ToString() == "Gümüşhane" || cmbBoxCity.SelectedItem.ToString() == "Bursa" || cmbBoxCity.SelectedItem.ToString() == "Eskişehir" || cmbBoxCity.SelectedItem.ToString() == "Bilecik" || cmbBoxCity.SelectedItem.ToString() == "Aydın" || cmbBoxCity.SelectedItem.ToString() == "Denizli" || cmbBoxCity.SelectedItem.ToString() == "Muğla" || cmbBoxCity.SelectedItem.ToString() == "Adana" || cmbBoxCity.SelectedItem.ToString() == "Mersin" || cmbBoxCity.SelectedItem.ToString() == "Balıkesir" || cmbBoxCity.SelectedItem.ToString() == "Çanakkale" || cmbBoxCity.SelectedItem.ToString() == "Antalya" || cmbBoxCity.SelectedItem.ToString() == "Isparta" || cmbBoxCity.SelectedItem.ToString() == "Burdur")
                {
                    city = 0.03;
                }
                //Education
                if (chBoxPrfAssociate.Checked == true)
                {
                    higher_education = 0.35;
                }
                else if (chBoxPrfPhD.Checked == true)
                {
                    higher_education = 0.30;
                }
                else if (chBoxNprfPhd.Checked == true)
                {
                    higher_education = 0.15;
                }
                else if (chBoxPrfMaster.Checked == true)
                {
                    higher_education = 0.10;
                }
                else if (chBoxNprfMaster.Checked == true)
                {
                    higher_education = 0.05;
                }
                //Language
                if (chBoxDEnglish.Checked == true || chBoxGEnglish.Checked == true)
                {
                    foreign_Language_Knowledge = 0.20;
                }
                foreign_Language_Knowledge += Convert.ToInt32(cmbBoxOtherLanguage.SelectedItem) * 0.05;
                //Title
                if (cmbTitle.SelectedItem.ToString() == "Team Leader / Group Manager / Technical Manager / Software Architect")
                {
                    management_Task = 0.50;
                }
                else if (cmbTitle.SelectedItem.ToString() == "Project Manager")
                {
                    management_Task = 0.75;
                }
                else if (cmbTitle.SelectedItem.ToString() == "Director / Projects Manager")
                {
                    management_Task = 0.85;
                }
                else if (cmbTitle.SelectedItem.ToString() == "CTO / General Manager")
                {
                    management_Task = 1.00;
                }
                else if (cmbTitle.SelectedItem.ToString() == "IT Manager(max 5 personel)")
                {
                    management_Task = 0.40;
                }
                else if (cmbTitle.SelectedItem.ToString() == "IT Manager(+5 personel)")
                {
                    management_Task = 0.60;
                }
                //Family
                int counter = 0;
                if (chBoxMarried.Checked == true)
                {
                    Family_Status = 0.20;
                }

                if (Convert.ToInt32(cmbBox18.SelectedItem) >= 2)
                {
                    Family_Status += 0.80;
                }
                else if (Convert.ToInt32(cmbBox7.SelectedItem) >= 2)
                {
                    Family_Status += 0.60;
                }
                else if (Convert.ToInt32(cmbBox0.SelectedItem) >= 2)
                {
                    Family_Status += 0.40;
                }
                else if (Convert.ToInt32(cmbBox18.SelectedItem) == 1)
                {
                    Family_Status += 0.40;
                    counter++;
                }
                if (Convert.ToInt32(cmbBox7.SelectedItem) == 1)
                {
                    Family_Status += 0.30;
                    counter++;
                }
                if (Convert.ToInt32(cmbBox0.SelectedItem) == 1 && counter != 2)
                {
                    Family_Status += 0.20;
                }
                txtBoxSalary.Text = Family_Status.ToString();
                if (user.Usertypes == "Admin" || user.Usertypes == "*Admin" || user.Usertypes == "admin" || user.Usertypes == "user" || user.Usertypes == "User")
                {
                    SalaryBuilder vBuilder = new UserSalaryBuilder();
                    vBuilder.Salary.InitialSalary = initialSalary;
                    vBuilder.Salary.City = city;
                    vBuilder.Salary.Experience = experience;
                    vBuilder.Salary.Family_Status1 = Family_Status;
                    vBuilder.Salary.Foreign_Language_Knowledge = foreign_Language_Knowledge;
                    vBuilder.Salary.Higher_education = higher_education;
                    vBuilder.Salary.Management_Task = management_Task;
                    SalaryDirector director = new SalaryDirector();
                    double salary = director.Calculate(vBuilder);
                    txtBoxSalary.Text = salary.ToString();
                }
                else
                {
                    SalaryBuilder vBuilder = new PartTimeUserSalaryBuilder();
                    vBuilder.Salary.InitialSalary = initialSalary;
                    vBuilder.Salary.City = city;
                    vBuilder.Salary.Experience = experience;
                    vBuilder.Salary.Family_Status1 = Family_Status;
                    vBuilder.Salary.Foreign_Language_Knowledge = foreign_Language_Knowledge;
                    vBuilder.Salary.Higher_education = higher_education;
                    vBuilder.Salary.Management_Task = management_Task;
                    SalaryDirector director = new SalaryDirector();
                    double salary = director.Calculate(vBuilder);
                    txtBoxSalary.Text = salary.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill in all the blanks ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Util.LoadCsv(LoginForm.userList, LoginForm.path);
            for (int i = 0; i < LoginForm.userList.Count; i++)
            {
                if (LoginForm.userList[i].Username == user.Username)
                    LoginForm.userList[i].Salary = txtBoxSalary.Text;
            }
            LoginedUser.getInstance().UserGetSet.Salary = txtBoxSalary.Text;
            Util.SaveCsv(LoginForm.userList, path);
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogOut logOut = new LogOut();
            logOut.ShowDialog();
            this.Close();
        }
    }
}
