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

namespace Book_Windows_Forms_App.UserControlesBenefitScreen
{
    public partial class MyBenefitBorrowing : UserControl
    {
        int _Id = 0;
        public MyBenefitBorrowing(int id)
        {
            InitializeComponent();
            _Id = id;
            gdgvMyBorrowings.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(192, 149, 85);
            gdgvMyBorrowings.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 43, 32);
            gdgvMyBorrowings.EnableHeadersVisualStyles = false;
        }

        private void MyBenefitBorrowing_Load(object sender, EventArgs e)
        {
            gdgvMyBorrowings.DataSource = clsBorrowing.getAllBorrowingsForSpecificBenefit(_Id);
            lblNumberofMyBooks.Text = clsBorrowing.getNumberofMyBooksForBenefit(_Id).ToString();

        }
    }
}
