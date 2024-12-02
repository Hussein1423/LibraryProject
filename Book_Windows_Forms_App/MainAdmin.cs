using Book_Windows_Forms_App.UserControles;
using Book_Windows_Forms_App.UserControles.Book;
using Book_Windows_Forms_App.UserControles.Borrowing;
using Book_Windows_Forms_App.UserControlesMainAdmin.Request;
using BusinessLayerBook;
using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Windows_Forms_App
{
    public partial class MainAdmin : Form
    {
     
        private void addUserControlToScreen(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(userControl);
            userControl.BringToFront();
        }
        static public void addUserControlTosubScreen(UserControl userControl)
        {
            var y = Application.OpenForms["MainAdmin"] as MainAdmin;
            userControl.Dock = DockStyle.Fill;
            y.panel2.Controls.Clear();
            y.panel2.Controls.Add(userControl);
            userControl.BringToFront();
        }

        static public void refresh(GunaDataGridView gunaDataGridView,DataTable data)
        {

            gunaDataGridView.DataSource = data;

        }

        private int _ID = 0;
        clsUser user;
        public MainAdmin(int id)
        {
            InitializeComponent();
            if(id!=-1)
            {
                _ID = id;
                user=clsUser.getUserByID(id);
                gunaLabel1.Text = $"Welcome {user.firstName + " " + user.lastName + ":" + user.type}";
            }
            else
            {
                _ID = -1;
            }

        }

 
        private void gabUsers_Click(object sender, EventArgs e)
        {
            User user = new User();
            addUserControlToScreen(user);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gabBooks_Click(object sender, EventArgs e)
        {
            Book book = new Book(user.ID);
            addUserControlToScreen(book);
            

        }

        private void gabBorrwings_Click(object sender, EventArgs e)
        {
            Borrowing borrowing = new Borrowing();
            addUserControlToScreen(borrowing);
        }

        private void gabRequests_Click(object sender, EventArgs e)
        {
            Request request = new Request(user.ID);
            addUserControlToScreen(request);
        }

        private void gabExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to want exit?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();

            }
        }
    }
}
