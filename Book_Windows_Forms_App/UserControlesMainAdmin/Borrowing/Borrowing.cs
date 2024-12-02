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
    public partial class Borrowing : UserControl
    {
        public Borrowing()
        {
            InitializeComponent();
        }

        private void gabInsertBorrowing_Click(object sender, EventArgs e)
        {
            BorrowingForm borrowingForm = new BorrowingForm(-1);
            MainAdmin.addUserControlTosubScreen(borrowingForm);
        }

        private void gabShowBorrowings_Click(object sender, EventArgs e)
        {
            ShowBorrowing showBorrowing = new ShowBorrowing();
            MainAdmin.addUserControlTosubScreen(showBorrowing);
        }
    }
}
