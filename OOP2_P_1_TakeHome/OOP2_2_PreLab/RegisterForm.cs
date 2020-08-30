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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int counter = 0;
            if (LoginForm.userList.Any())
            {
                for (int i = 0; i < LoginForm.userList.Count(); i++)
                {
                    if (txtNewName.Text == LoginForm.userList[i].Username)
                    {
                        MessageBox.Show("User already exists!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        counter++;
                        break;
                    }
                    else if (txtNewName.Text == "" || txtNewPass.Text == "" || TxtName.Text == "" || TxtSurname.Text == "" || MTxtPhoneNumber.Text == "" || TxtAddress.Text == "" || TxtEmail.Text == "" || LblPath.Text == "")
                    {
                        MessageBox.Show("Please fill in the blanks!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        counter++;
                        break;
                    }
                }
                if (counter != 1)
                {
                    if (Util.isEmailValid(TxtEmail.Text))
                    {
                        if (MTxtPhoneNumber.Text.Length == 14)
                        {
                            User userAdd = new User(txtNewName.Text, Util.ComputeStringToSha256Hash((txtNewPass.Text)), false, "user", TxtName.Text, TxtSurname.Text, MTxtPhoneNumber.Text, TxtAddress.Text, TxtEmail.Text, LblPath.Text, "5000");
                            LoginForm.userList.Add(userAdd);
                            Util.SaveCsv(LoginForm.userList, LoginForm.path);
                            MessageBox.Show("Registration Successful!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                            MessageBox.Show("Phone number order incorrect!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Email order incorrect!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (txtNewName.Text == "" || txtNewPass.Text == "" || TxtName.Text == "" || TxtSurname.Text == "" || MTxtPhoneNumber.Text == "" || TxtAddress.Text == "" || TxtEmail.Text == "" || LblPath.Text == "")
                {
                    MessageBox.Show("Please fill in the blanks!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (Util.isEmailValid(TxtEmail.Text))
                    {
                        if (MTxtPhoneNumber.Text.Length == 14)
                        {
                            User userAdd = new User(txtNewName.Text, Util.ComputeStringToSha256Hash((txtNewPass.Text)), false, "*Admin", TxtName.Text, TxtSurname.Text, MTxtPhoneNumber.Text, TxtAddress.Text, TxtEmail.Text, LblPath.Text, "5000");
                            LoginForm.userList.Add(userAdd);
                            Util.SaveCsv(LoginForm.userList, LoginForm.path);
                            MessageBox.Show("Registration Successful!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                            MessageBox.Show("Phone number order incorrect!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Email order incorrect!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void KayıtFormu_Load(object sender, EventArgs e)
        {
            txtNewName.Text = "";
            txtNewPass.Text = "";
            TxtName.Text = "";
            TxtSurname.Text = "";
            MTxtPhoneNumber.Text = "";
            TxtAddress.Text = "";
            TxtEmail.Text = "";
            LblPath.Text = "";
            PicPhoto.ImageLocation = "";
        }
        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm form = LoginForm.Form1Instance;
            form.Show();
        }
        private void BtnImagePath_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            PicPhoto.ImageLocation = openFileDialog1.FileName;
            LblPath.Text= Util.ImageToBase64(openFileDialog1.FileName);
        }
    }
}
