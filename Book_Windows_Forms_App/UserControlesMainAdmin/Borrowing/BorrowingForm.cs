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

namespace Book_Windows_Forms_App.UserControles.Borrowing
{
    public partial class BorrowingForm : UserControl
    {
        int _IDBorrowing = 0;

        DataTable benefitUsers = clsUser.getAllBenefitUsers();
        DataTable recipientUsers = clsUser.getAllRecipientUsers();
        DataTable books = clsBook.getAllBooks();
        clsUser benefitUser;
        clsUser recipientUser ;
        clsBook book ;
        clsBorrowing borrowing;

        public BorrowingForm(int IDBorrowing)
        {
            InitializeComponent();
            foreach (DataRow row in benefitUsers.Rows)
            {
                string firstName = row["firstName"]?.ToString() ?? "";
                string middleName = row["middleName"]?.ToString() ?? "";
                string lastName = row["lastName"]?.ToString() ?? "";
                cmbBenefits.Items.Add($"{firstName} {middleName} {lastName}".Trim());
            }
            foreach (DataRow row in recipientUsers.Rows)
            {
                string firstName = row["firstName"]?.ToString() ?? "";
                string middleName = row["middleName"]?.ToString() ?? "";
                string lastName = row["lastName"]?.ToString() ?? "";
                cmbRecipients.Items.Add($"{firstName} {middleName} {lastName}".Trim());
            }
            foreach (DataRow row in books.Rows)
            {
                cmbBooks.Items.Add(row["Book_Name"]);
            }
            _IDBorrowing = IDBorrowing;
  
          
        }
        private void stateofForm(clsBorrowing borrowing,clsBook book,clsUser userBenifit,clsUser userRecipient)
        {
            if (borrowing == null)
            {
                lblBorrowingID.Text = $"ID:?????";
            }
            else
            {
                lblBorrowingID.Text = $"ID:{borrowing.IDBorrowing}";
                cmbBenefits.Text = userBenifit.firstName + " " + userBenifit.middleName + " " + userBenifit.lastName;
                cmbRecipients.Text = userRecipient.firstName + " " + userRecipient.middleName + " " + userRecipient.lastName;
                cmbBooks.Text = book.bookName;
                if (borrowing.recoveryDate == null)
                {
                    dtpRecoveryDate.Text = null;
                }
                else
                {
                    dtpBorrowingDate.Text = borrowing.recoveryDate.ToString();
                } 
                dtpBorrowingDate.Text = borrowing.borrowingDate.ToString();
            }

        }
        private void gabBorrowingConfirm_Click(object sender, EventArgs e)
        {
            string[] name = new string[3];
            name = cmbBenefits.Text.Split(' ');
            borrowing.IDUserBenefit = clsUser.getIDByName(name[0].Trim(), name[1].Trim(), name[2].Trim());
            benefitUser.ID = borrowing.IDUserBenefit;
            name = cmbRecipients.Text.Split(' ');
            borrowing.IDUserRecipient = clsUser.getIDByName(name[0].Trim(),name[1].Trim(), name[2].Trim());
            recipientUser.ID = borrowing.IDUserRecipient;
            borrowing.IDBook = clsBook.getBookByName(cmbBooks.Text);
            book.ID = borrowing.IDBook;
            borrowing.recoveryDate = Convert.ToDateTime( dtpRecoveryDate.Text);
            borrowing.borrowingDate =Convert.ToDateTime( dtpBorrowingDate.Text);
            if(borrowing.save())
            {
                MessageBox.Show("Successfully!!!", "Done");
                book = clsBook.getBookByID(book.ID);
                benefitUser = clsUser.getUserByID(benefitUser.ID);
                recipientUser = clsUser.getUserByID(recipientUser.ID);
                stateofForm(borrowing,book,benefitUser,recipientUser);
            }
            else
            {
                MessageBox.Show("Something Wrong", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void BorrowingForm_Load(object sender, EventArgs e)
        {
            borrowing = clsBorrowing.getBorrowingByIDBorrowing(_IDBorrowing);
            if (borrowing != null)
            {
                benefitUser = clsUser.getUserByID(borrowing.IDUserBenefit);
                recipientUser = clsUser.getUserByID(borrowing.IDUserRecipient);
                book = clsBook.getBookByID(borrowing.IDBook);
                stateofForm(borrowing, book, benefitUser, recipientUser);

            }
            else
            {
                stateofForm(null,null,null,null);
                borrowing = new clsBorrowing();
                benefitUser = new clsUser();
                recipientUser = new clsUser();
                book = new clsBook();
            }
        }
    }
}
