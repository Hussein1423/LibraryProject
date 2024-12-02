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
    public partial class UserForm : UserControl
    {
        int _ID=1;
        clsUser user = new clsUser();
        public UserForm(int id)
        {
            InitializeComponent();
            _ID = id;
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            user = clsUser.getUserByID(_ID);
            if (user == null)
            {
                user = new clsUser();

            }
            stateofForm(user);
        }

        private void stateofForm(clsUser user)
        {
            if (user == null)
            {
                lblUserID.Text = $"ID:?????";
            }
            else
            {
                lblUserID.Text = $"ID:{user.ID}";
                gtbFirstName.Text = user.firstName;
                gtbLastName.Text = user.lastName;
                gtbMiddleName.Text = user.middleName;
                gtbPassword.Text =clsUtility.Decrypt( user.password);
                gtbPhone.Text = user.phone;
                gcbType.Text = user.type;
                if (user.authoriz)
                {
                    rbTrue.Checked = true;
                }
                else
                {
                    rbFalse.Checked = true;
                }
            }

        }
        private void gabConfirm_Click(object sender, EventArgs e)
        {
            
            user.firstName = gtbFirstName.Text;
            user.middleName = gtbMiddleName.Text;
            user.lastName = gtbLastName.Text;
            user.password = gtbPassword.Text;
            user.phone = gtbPhone.Text;
            user.type = gcbType.Text;
            if (rbTrue.Checked)
            {
                user.authoriz = true;
            }
            else
            { user.authoriz = false; }
            stateofForm(user);
            if (user.save())
            {
                MessageBox.Show("Successfully!!!", "Done");
                stateofForm(user);

            }
            else
            {
                MessageBox.Show("Something Wrong", "Error",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
        }
    }
}
