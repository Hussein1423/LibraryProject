using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Windows_Forms_App.UserControles
{
    public partial class User : UserControl
    {
        public User()
        {
            InitializeComponent();
        }

       

        private void gabInsertUser_Click(object sender, EventArgs e)
        {
            UserForm insertUser = new UserForm(-1);
            MainAdmin.addUserControlTosubScreen(insertUser);
        }

        private void gabShowUsers_Click(object sender, EventArgs e)
        {
            ShowUsers showUsers = new ShowUsers();
            MainAdmin.addUserControlTosubScreen(showUsers);
        }
    }
}
