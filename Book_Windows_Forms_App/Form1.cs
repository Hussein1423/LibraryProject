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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
     
        }

        int id = -1;
        int isExistUser()
        {

            id = clsUser.isExistUserByName(gtbFirstName.Text.Trim(), gtbMiddleName.Text.Trim(), gtbLastName.Text.Trim(), gtbPassword.Text.Trim());
            return id;
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            id = isExistUser();
            if (isExistUser()!= -1)
            {
               clsUser user = clsUser.getUserByID(id);
                switch(user.type)
                {
                   case  "Benefit": 
                        BenefitScreen benefitScreen = new BenefitScreen(user.ID);
                        lblErrorMessage.Text = "";
                        benefitScreen.Show();
                      
                        break;
                    case "Recipient":
                        RecipientScreen recipientScreen = new RecipientScreen(user.ID);
                        lblErrorMessage.Text = "";
                        recipientScreen.Show();
              
                        break;
                    case "Admin":
                        MainAdmin mainAdmin = new MainAdmin(user.ID);
                        lblErrorMessage.Text = "";
                        mainAdmin.Show();
                       
                        break;

                }
            }
            else
            {
                lblErrorMessage.Text = "كلمة المرور او الاسم خطأ";
            }
        }

        private void gunaCirclePictureBox1_Click(object sender, EventArgs e)
        {

            if (gtbPassword.PasswordChar == '*')
            {
                gtbPassword.PasswordChar = '\0';
                gcpbforPassword.Image = Properties.Resources.hide_100px;
            }
            else
            {
                gtbPassword.PasswordChar = '*';
                gcpbforPassword.Image = Properties.Resources.invisible_100px;
            }
           
        }
    }
}
