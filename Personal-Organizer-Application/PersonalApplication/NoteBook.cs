using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Organizer_Application
{
    public partial class NoteBook : Form
    {
        public static string path = "notebook.csv";
        User user = LoginedUser.getInstance().UserGetSet;
        List<Notes> listNotebook = new List<Notes>();
        public NoteBook()
        {
            InitializeComponent();
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            int counter = 0;
            if (txtNote.Text == "")
            {
                MessageBox.Show("You cannot save empty note.Please enter your note.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                counter++;
            }
            if (counter != 1)
            {
                Notes note = new Notes(user.Username, txtNote.Text);
                listNotebook.Add(note);
                Util.SaveNotebook(listNotebook, path);
                MessageBox.Show("Registration Successful!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNote.Text = "";
            }
        }
        private void txtNote_TextChanged(object sender, EventArgs e)
        {
            if (txtNote.TextLength > 0)
            {
                txtNote.Text = char.ToUpper(txtNote.Text[0]).ToString() + txtNote.Text.Substring(1);
                txtNote.SelectionStart = txtNote.TextLength;
            }
        }
        private void BtnList_Click(object sender, EventArgs e)
        {
            dgv_list.DataSource = null;
            List();
        }
        public void List()
        {
            listNotebook = Util.LoadNotebook(path);
            dgv_list.DataSource = listNotebook;
        }
        private void dgv_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dgv_list.SelectedCells[0].RowIndex;
            txtNote.Text = dgv_list.Rows[secilen].Cells[1].Value.ToString();
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int secilen = dgv_list.SelectedCells[0].RowIndex;
                Notes note = new Notes(user.Username, txtNote.Text);
                listNotebook.RemoveAt(secilen);
                Util.SaveNotebook(listNotebook, path);
                MessageBox.Show("Note Deleted!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List();
                txtNote.Text = "";
            }
            catch (Exception)
            {
            }
        }
        private void NoteBook_Load(object sender, EventArgs e)
        {
            List();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogOut logOut = new LogOut();
            logOut.ShowDialog();
            this.Close();
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int secilen = dgv_list.SelectedCells[0].RowIndex;
                listNotebook[secilen].Note = txtNote.Text;
                Util.SaveNotebook(listNotebook, path);
                MessageBox.Show("Update Successful!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List();
            }
            catch
            {
            }
        }
        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LogOut logOut = new LogOut();
            logOut.ShowDialog();
            this.Close();
        }
    }
}
