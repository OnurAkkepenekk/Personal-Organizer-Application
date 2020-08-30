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
    public partial class Management : Form
    {
        public static Management mana;
        public Management()
        {
            mana = this;
            InitializeComponent();
        }
        private void Management_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = LoginForm.userList;
            for (int i = 0; i < LoginForm.userList.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i;
            }
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogOut logOut = new LogOut();
            logOut.ShowDialog();
            this.Close();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            User user = LoginedUser.getInstance().UserGetSet;
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            if (secilen == 0 && user.Usertypes != "*Admin")
            {
                MessageBox.Show("No changes can be made via admin", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TxtRegisterNo.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
                TxtUsername.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
                TxtPassword.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
                TxtUsertypes.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            if ((LoginForm.userList[secilen].Usertypes == "*Admin"))
            {
                MessageBox.Show("*Admin can not delete !!! ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                LoginForm.userList.RemoveAt(secilen);
                Util.SaveCsv(LoginForm.userList, LoginForm.path);
                MessageBox.Show("Deleting...");
                List();
                deleteText();
            }
        }
        private void BtnLists_Click(object sender, EventArgs e)
        {
            List();
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            //Kayıt olunması için gereken onayın alınması için atılan sayaç
            int accept = 0;
            for (int i = 0; i < LoginForm.userList.Count; i++)
            {
                if (TxtUsername.Text == LoginForm.userList[i].Username &&
                    (TxtPassword.Text) == LoginForm.userList[i].AccoundPassword &&
                    LoginForm.userList[i].Usertypes == TxtUsertypes.Text)
                {
                    MessageBox.Show("User already exists!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    accept++;
                    break;
                }
                else if (TxtUsername.Text == "" || TxtPassword.Text == "")
                {
                    MessageBox.Show("Please enter username and password!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    accept++;
                    break;
                }
                else if (TxtUsertypes.Text == "*Admin")
                {
                    MessageBox.Show("*Admin already exists! There can be only one in this system.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    accept++;
                    break;
                }
                if (TxtUsertypes.Text != "Admin" && TxtUsertypes.Text != "admin" && TxtUsertypes.Text != "user" && TxtUsertypes.Text != "part-time-user")
                {
                    MessageBox.Show("There is no such user type.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    accept++;
                    break;
                }
            }
            if (accept == 0)
            {
                if (LoginForm.userList[0].Usertypes == "*Admin")
                {
                    User user = LoginForm.userList[int.Parse(TxtRegisterNo.Text)];
                    user.Username = TxtUsername.Text;
                    user.AccoundPassword = (TxtPassword.Text);
                    user.Usertypes = TxtUsertypes.Text;
                    Util.SaveCsv(LoginForm.userList, LoginForm.path);
                    MessageBox.Show("Updating...");
                    deleteText();
                }
                else
                {
                    MessageBox.Show("*Admin ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void List()
        {
            Util.LoadCsv(LoginForm.userList, LoginForm.path);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = LoginForm.userList;
            for (int i = 0; i < LoginForm.userList.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i;
            }
        }
        private void deleteText()
        {
            TxtUsername.Text = "";
            TxtPassword.Text = "";
            TxtUsertypes.Text = "";
            TxtRegisterNo.Text = "";
        }
    }
}
