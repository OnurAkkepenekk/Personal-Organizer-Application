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
namespace Personal_Organizer_Application
{
    public partial class LoginForm : Form
    {
        public static List<User> userList = new List<User>();
        public static string path = "mydb.csv";
        public static LoginForm Form1Instance;
        LogOut logOut = new LogOut();
        RegisterForm register = new RegisterForm();
        public LoginForm()
        {
            InitializeComponent();
            Form1Instance = this;
            Util.LoadCsv(userList, path);
            checkRememberUser();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox5.Hide();
            pictureBox3.Show();
            txtName.Text = "";
            txtPassword.Text = "";
            lblMesaj.Text = "";
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtName.Text;
            string password = txtPassword.Text;
            bool rememberMe = RememberMe.Checked;
            for (int i = 0; i < userList.Count; i++)
            {
                User user = userList[i];
                if (user.IsValid(username, password, rememberMe) == true)
                {
                    user.RememberMe = rememberMe;
                    LoginedUser.getInstance().UserGetSet = user;
                    lblMesaj.BackColor = Color.Green;
                    lblMesaj.Text = "successful login";
                    lblMesaj.Visible = true;
                    if (rememberMe == true)
                    {
                        Util.SaveCsv(userList, path);
                    }
                    Delay.Start();
                    return;
                }
            }
            lblMesaj.BackColor = Color.Red;
            lblMesaj.Text = "failed login";
            lblMesaj.Visible = true;
            txtName.Text = "";
            txtPassword.Text = "";
        }
        private void newKayıt_Click(object sender, EventArgs e)
        {
            this.Hide();
            register.ShowDialog();
            if (register.IsDisposed)
            {
                this.Show();
            }
        }
        private void checkRememberUser()
        {
            foreach (User user in userList)
            {
                if (user.RememberMe)
                {
                    LoginedUser.getInstance().UserGetSet = user;
                    this.Hide();
                    if (logOut.ShowDialog() == DialogResult.Cancel && LoginedUser.getInstance().UserGetSet.RememberMe == true)
                    {
                        System.Environment.Exit(1);
                    }
                }
            }
        }
        private void Delay_Tick(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPassword.Text = "";
            lblMesaj.Text = "";
            Delay.Enabled = false;
            this.Hide();
            if (logOut.ShowDialog() == DialogResult.Cancel && LoginedUser.getInstance().UserGetSet.RememberMe == true)
            {
                this.Close();
            }
            else
            {
                LoginForm Frm = new LoginForm();
                if (Frm.ShowDialog() == DialogResult.Cancel)
                {
                    this.Close();
                }
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            pictureBox3.Hide();
            pictureBox5.Show();
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            pictureBox5.Hide();
            pictureBox3.Show();
        }

        private void ProcessTime_Tick(object sender, EventArgs e)
        {
            lblNowTime.Text = DateTime.Now.ToLongDateString() + Environment.NewLine + DateTime.Now.ToLongTimeString();
            Util.RingAlarm();
        }
    }
}
