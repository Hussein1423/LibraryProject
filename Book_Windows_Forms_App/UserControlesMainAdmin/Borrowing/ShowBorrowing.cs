using Book_Windows_Forms_App.UserControles.Book;
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
    public partial class ShowBorrowing : UserControl
    {
        public ShowBorrowing()
        {
            InitializeComponent();
            gdgvBorrowing.EnableHeadersVisualStyles = false;
            gdgvBorrowing.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(192, 149, 85);
            gdgvBorrowing.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 43, 32);
        }
       

        private void ShowBorrowing_Load(object sender, EventArgs e)
        {
            MainAdmin.refresh(gdgvBorrowing, clsBorrowing.getAllBorrowings());
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are sure?", "Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int id = (int)gdgvBorrowing.CurrentRow.Cells[0].Value;
                short? part;
                if (gdgvBorrowing.CurrentRow.Cells[8].Value.ToString() == "")
                {
                    part = null;
                }
                else
                {
                    part = (short?)gdgvBorrowing.CurrentRow.Cells[8].Value;
                }
                int idBook = (int)clsBook.getBookByName(gdgvBorrowing.CurrentRow.Cells[7].Value.ToString(), part);

                if (clsBorrowing.deleteBorrowing(id))
                {
                    MessageBox.Show("Deleted");
                    clsBook.updateisBorrowingBook(idBook, false);
                    MainAdmin.refresh(gdgvBorrowing, clsBorrowing.getAllBorrowings());
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int)gdgvBorrowing.CurrentRow.Cells[0].Value;
            BorrowingForm borrowingForm = new BorrowingForm(id);
            MainAdmin.addUserControlTosubScreen(borrowingForm);
            MainAdmin.refresh(gdgvBorrowing, clsBorrowing.getAllBorrowings());
        }

        private void gtbSearch_TextChanged(object sender, EventArgs e)
        {
            if (rbBook.Checked)
            {
                MainAdmin.refresh(gdgvBorrowing, clsBorrowing.booksSearchWithLetters(gtbSearch.Text));
            }
            else if (rbBenefit.Checked)
            {
                MainAdmin.refresh(gdgvBorrowing, clsBorrowing.benefitsSearchWithLetters(gtbSearch.Text));
            }
            else if (rbRecipient.Checked)
            {
                MainAdmin.refresh(gdgvBorrowing, clsBorrowing.recipientsSearchWithLetters(gtbSearch.Text));
            }
        }
    }
}
