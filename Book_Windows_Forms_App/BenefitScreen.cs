using Book_Windows_Forms_App.UserControles.Book;
using Book_Windows_Forms_App.UserControlesBenefitScreen;
using BusinessLayerBook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Windows_Forms_App
{
    public partial class BenefitScreen : Form
    {
        private void addUserControlToScreen(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(userControl);
            userControl.BringToFront();

        }
        private int _ID = 0;
        clsUser user;
        public BenefitScreen(int id)
        {
            InitializeComponent();
            if (id != -1)
            {
                _ID = id;
                user = clsUser.getUserByID(id);
                glblGreeting.Text = $"Welcome {user.firstName + " " + user.lastName + ":" + user.type}";
            }
            else
            {
                _ID = -1;
            }
        }

        private void gabBooks_Click(object sender, EventArgs e)
        {
            ShowBooks showBooks = new ShowBooks(user.type,user.ID);
            addUserControlToScreen(showBooks);

        }

        private void gabBorrowings_Click(object sender, EventArgs e)
        {
            MyBenefitBorrowing myBenefitBorrowing = new MyBenefitBorrowing(_ID);
            addUserControlToScreen(myBenefitBorrowing);
        }

        private void gabRequests_Click(object sender, EventArgs e)
        {
            GetAllRequests requests = new GetAllRequests(user.ID);
            addUserControlToScreen(requests);
           
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
