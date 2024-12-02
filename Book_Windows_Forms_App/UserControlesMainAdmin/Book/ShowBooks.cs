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
using Book_Windows_Forms_App.UserControlesBenefitScreen;
namespace Book_Windows_Forms_App.UserControles.Book
{
    public partial class ShowBooks : UserControl
    {
        string _Type;
        int _IDBenefit;
        clsBook book;
        public ShowBooks(string type,int idBenefit)
        {
            InitializeComponent();
            _Type = type;
            _IDBenefit = idBenefit;
            gdgvBooks.EnableHeadersVisualStyles = false;
            gdgvBooks.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(192, 149, 85);
            gdgvBooks.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 43, 32);

        }
    

        private void ShowBooks_Load(object sender, EventArgs e)
        {
            MainAdmin.refresh(gdgvBooks,clsBook.getAllBooks());
            if(_Type == "Admin")
            {
                gdgvBooks.ContextMenuStrip = contextMenuStrip1;
            }
            else if(_Type== "Benefit")
            {
                gdgvBooks.ContextMenuStrip = contextMenuStrip2;
            }

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are sure?", "Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int id = (int)gdgvBooks.CurrentRow.Cells[0].Value;

                if (clsBook.deleteBook(id))
                {
                    MessageBox.Show("Deleted");
                    MainAdmin.refresh(gdgvBooks, clsBook.getAllBooks());
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            int id = (int)gdgvBooks.CurrentRow.Cells[0].Value;
            BookForm bookForm = new BookForm(id);
            MainAdmin.addUserControlTosubScreen(bookForm);
            MainAdmin.refresh(gdgvBooks, clsBook.getAllBooks());
        }

        private void gdgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gtbSearch_TextChanged(object sender, EventArgs e)
        {
            MainAdmin.refresh(gdgvBooks, clsBook.bookSearchWithLetters(gtbSearch.Text));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void requestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            book =clsBook.getBookByID( (int)gdgvBooks.CurrentRow.Cells[0].Value);
            if (book.isBorrowing)
            {
                MessageBox.Show("This book is borrowed");
            }
            else if (book != null)
            {
                Recipient recipient = new Recipient(book.ID,_IDBenefit);
                recipient.ShowDialog();
            }
           
            else { MessageBox.Show("Error"); }
        }
    }
}
