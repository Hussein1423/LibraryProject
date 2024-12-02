using Book_Windows_Forms_App.UserControles.Book;
using Book_Windows_Forms_App.UserControlesRecipientScreen;
using BusinessLayerBook;
using Guna.UI.WinForms;
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
   
    public partial class RecipientScreen : Form
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
        public RecipientScreen(int id)
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

        private void gabUsers_Click(object sender, EventArgs e)
        {
            MyBorrowings myBorrowings = new MyBorrowings(_ID);
            addUserControlToScreen(myBorrowings);
        }

        private void gabBooks_Click(object sender, EventArgs e)
        {
            ShowBooks showBooks = new ShowBooks(user.type, user.ID);
            addUserControlToScreen(showBooks);
        }

        private void gabExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure to want exit?","Exit",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            {
                this.Close();
                
            }

        }
    }
}
