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

namespace Book_Windows_Forms_App.UserControlesRecipientScreen
{
    public partial class MyBorrowings : UserControl
    {
        int ID = 0;
        public MyBorrowings(int iD)
        {
            InitializeComponent();
            ID = iD;
            gdgvMyBorrowings.EnableHeadersVisualStyles = false;
            gdgvMyBorrowings.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(192, 149, 85);
            gdgvMyBorrowings.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 43, 32);
        }

        private void MyBorrowings_Load(object sender, EventArgs e)
        {
            gdgvMyBorrowings.DataSource = clsBorrowing.getAllBorrowingsForSpecificRecipient(ID);
            lblNumberofMyBooks.Text = clsBorrowing.getNumberofMyBooksForRecipient(ID).ToString();
        }
    }
}
