using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Windows_Forms_App.UserControles.Book
{
    public partial class Book : UserControl
    {
        int _IDUser;

        public Book(int iDUser)
        {
            InitializeComponent();
            _IDUser = iDUser;
        }

        private void gabInsertBook_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm(-1);
            
            MainAdmin.addUserControlTosubScreen(bookForm);
        }

        private void gabShowBooks_Click(object sender, EventArgs e)
        {
            ShowBooks showBooks = new ShowBooks("Admin",_IDUser);
       
            MainAdmin.addUserControlTosubScreen(showBooks);
        }
    }
}
