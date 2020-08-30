using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
namespace OOP2_2_PreLab
{
    public partial class PhoneBook : Form
    {
        public static List<Phone> phoneList = new List<Phone>();
        public static List<Phone> userphoneList = new List<Phone>();
        public static string path = "phonebook.csv";
        User user = LoginedUser.getInstance().UserGetSet;
        public PhoneBook()
        {
            InitializeComponent();
        }
        private void PhoneBook_Load(object sender, EventArgs e)
        {
            Util.LoadPhoneBook(phoneList, path);
        }
        private void BtnLists_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            userphoneList.Clear();
            for (int i = 0; i < phoneList.Count(); i++)
            {
                if (phoneList[i].User == user.Username)
                {
                    userphoneList.Add(phoneList[i]);
                }
            }
            dataGridView1.DataSource = userphoneList;
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            int counter = 0;
            if (phoneList.Any())
            {
                for (int i = 0; i < phoneList.Count(); i++)
                {
                    if (MTxtNumber.Text == phoneList[i].Number)
                    {
                        if (phoneList[i].User == user.Username)
                        {
                            MessageBox.Show("User already exists!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            counter++;
                            break;
                        }
                    }
                    else if (TxtName.Text == "" || TxtSurname.Text == "" || MTxtNumber.Text == "" || TxtAddress.Text == "" || TxtDescription.Text == "" || TxtEmail.Text == "")
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
                        if (MTxtNumber.Text.Length == 14)
                        {
                            Phone numberAdd = new Phone(user.Username.ToString(), TxtName.Text, TxtSurname.Text, MTxtNumber.Text, TxtAddress.Text, TxtDescription.Text, TxtEmail.Text);
                            phoneList.Add(numberAdd);
                            Util.SavePhoneBook(phoneList, path);
                            MessageBox.Show("Registration Successful!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (TxtName.Text == "" || TxtSurname.Text == "" || MTxtNumber.Text == "" || TxtAddress.Text == "" || TxtDescription.Text == "" || TxtEmail.Text == "")
                {
                    MessageBox.Show("Please fill in the blanks!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (Util.isEmailValid(TxtEmail.Text))
                    {
                        if (MTxtNumber.Text.Length == 14)
                        {
                            Phone numberAdd = new Phone(user.Username.ToString(), TxtName.Text, TxtSurname.Text, MTxtNumber.Text, TxtAddress.Text, TxtDescription.Text, TxtEmail.Text);
                            phoneList.Add(numberAdd);
                            Util.SavePhoneBook(phoneList, path);
                            MessageBox.Show("Registration Successful!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Phone number order incorrect!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Email order incorrect!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtName.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtSurname.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            MTxtNumber.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtAddress.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtDescription.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            TxtEmail.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            for (int i = 0; i < phoneList.Count; i++)
            {
                if (phoneList[i].Number == userphoneList[secilen].Number && phoneList[i].User == userphoneList[secilen].User)
                {
                    for (int j = 0; j < phoneList.Count; j++)
                    {
                        if (MTxtNumber.Text == phoneList[j].Number)
                        {
                            if (MTxtNumber.Text == userphoneList[secilen].Number)
                            {
                                if (Util.isEmailValid(TxtEmail.Text))
                                {
                                    if (MTxtNumber.Text.Length == 14)
                                    {
                                        phoneList[i].Number = MTxtNumber.Text;
                                        phoneList[i].Name = TxtName.Text;
                                        phoneList[i].Surname = TxtSurname.Text;
                                        phoneList[i].Address = TxtAddress.Text;
                                        phoneList[i].Description = TxtDescription.Text;
                                        phoneList[i].Mail = TxtEmail.Text;
                                        Util.SavePhoneBook(phoneList, path);
                                        MessageBox.Show("Update Successful!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        break;
                                    }
                                    else
                                        MessageBox.Show("Phone number order incorrect!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    break;
                                }
                                else
                                    MessageBox.Show("Email order incorrect!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                            else
                            {
                                MessageBox.Show("This number already exists!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                        }
                        if (j == phoneList.Count - 1)
                        {
                            if (Util.isEmailValid(TxtEmail.Text))
                            {
                                if (MTxtNumber.Text.Length == 14)
                                {
                                    phoneList[i].Number = MTxtNumber.Text;
                                    phoneList[i].Name = TxtName.Text;
                                    phoneList[i].Surname = TxtSurname.Text;
                                    phoneList[i].Address = TxtAddress.Text;
                                    phoneList[i].Description = TxtDescription.Text;
                                    phoneList[i].Mail = TxtEmail.Text;
                                    Util.SavePhoneBook(phoneList, path);
                                    MessageBox.Show("Update Successful!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    break;
                                }
                                else
                                    MessageBox.Show("Phone number order incorrect!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                            else
                                MessageBox.Show("Email order incorrect!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            for (int i = 0; i < phoneList.Count; i++)
            {
                if (phoneList[i].Number == userphoneList[secilen].Number && phoneList[i].User == userphoneList[secilen].User)
                {
                    phoneList.RemoveAt(i);
                    Util.SavePhoneBook(phoneList, path);
                    MessageBox.Show("Number Deleted!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
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

