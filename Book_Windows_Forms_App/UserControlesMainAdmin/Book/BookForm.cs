using BusinessLayerBook;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Windows_Forms_App.UserControles.Book
{
    public partial class BookForm : UserControl
    {
        int _ID = -1;
        clsBook book;
        public BookForm(int id)
        {
            InitializeComponent();
            _ID = id;
        }
        private void stateofForm(clsBook book)
        {
            if (book == null)
            {
                lblID.Text = $"ID:?????";
            }
            else
            {
                lblID.Text = $"ID:{book.ID}";
                gtbBookName.Text = book.bookName;
                if (book.part == null)
                {
                    nudBookPart.Text = Convert.ToString(0);
                }
                else
                {
                    nudBookPart.Text = book.part.ToString();
                }
               
                if (book.isBorrowing)
                {
                    rbBookTrue.Checked = true;
                }
                else
                {
                    rbBookFalse.Checked = true;
                }
            }

        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            book = clsBook.getBookByID( _ID );
            stateofForm(book);
            if (book == null)
            {
                book = new clsBook();
            }

        }

        private void gabBookConfirm_Click(object sender, EventArgs e)
        {
            book.bookName = gtbBookName.Text;
            if(Convert.ToUInt16(nudBookPart.Text) == 0)
            { 
            book.part = null;
            }
            else
            {
                book.part = Convert.ToInt16(nudBookPart.Text);
            }
           
            if (rbBookTrue.Checked)
            {
               book.isBorrowing = true;
            }
            else
            { book.isBorrowing = false; }
            stateofForm(book);
            if (book.save())
            {
                MessageBox.Show("Successfully!!!", "Done");
                stateofForm(book);

            }
            else
            {
                MessageBox.Show("Something Wrong", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
    }
