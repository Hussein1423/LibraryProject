using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using BusinessLayerBook;
namespace Book_Windows_Forms_App.UserControlesBenefitScreen
{
   
    public partial class Recipient : Form
    {
        clsBook book = new clsBook();
        int IDBenefit = -1;
        DataTable recipientUsers = clsUser.getAllRecipientUsers();
        public Recipient(int IDBook,int IDBenefit)
        {
            InitializeComponent();
            book = clsBook.getBookByID(IDBook);
            this.IDBenefit = IDBenefit;
            foreach (DataRow row in recipientUsers.Rows)
            {
                string firstName = row["firstName"]?.ToString() ?? "";
                string middleName = row["middleName"]?.ToString() ?? "";
                string lastName = row["lastName"]?.ToString() ?? "";
                gcbRecipient.Items.Add($"{firstName} {middleName} {lastName}".Trim());
            }
            lblBook.Text = book.bookName.ToString();
            lblPart.Text = book.part.ToString();

        }

        private void gabConfirm_Click(object sender, EventArgs e)
        {
          string[] name = gcbRecipient.Text.Split(' ');
            int IDRecipient=0;
            if (name.Length>2)
            {
                 IDRecipient = clsUser.getIDByName(name[0], name[1], name[2]);
            }
          if(clsRequest.insertRequest(IDBenefit, IDRecipient, null, book.ID, null))
            {
                MessageBox.Show("Successfully!!!", "Done");
            }
            else
            {
                MessageBox.Show("Something Wrong", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
          this.Close();
        }
    }
}
