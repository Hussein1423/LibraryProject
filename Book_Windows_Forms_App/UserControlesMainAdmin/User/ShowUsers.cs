using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayerBook;
namespace Book_Windows_Forms_App.UserControles
{
    public partial class ShowUsers : UserControl
    {
        public ShowUsers()
        {
            InitializeComponent();

            gdgvUsers.EnableHeadersVisualStyles = false;

            // Set the default header style
            gdgvUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(192, 149, 85);
            gdgvUsers.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 43, 32);

        }

        private void ShowUsers_Load(object sender, EventArgs e)
        {
            MainAdmin.refresh(gdgvUsers, clsUser.getAllUsers());
          

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are sure?", "Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int id = (int)gdgvUsers.CurrentRow.Cells[0].Value;

            if (clsUser.deleteUser(id))
            { 
                    MessageBox.Show("Deleted");
                    MainAdmin.refresh(gdgvUsers, clsUser.getAllUsers());
                }
            else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int)gdgvUsers.CurrentRow.Cells[0].Value;
            UserForm userForm = new UserForm(id);
            MainAdmin.addUserControlTosubScreen(userForm);
            MainAdmin.refresh(gdgvUsers, clsUser.getAllUsers());
        }

        private void gtbSearch_TextChanged(object sender, EventArgs e)
        {
          
                MainAdmin.refresh(gdgvUsers, clsUser.usersSearchWithLetters(gtbSearch.Text));
            
        }

        
    }
}
