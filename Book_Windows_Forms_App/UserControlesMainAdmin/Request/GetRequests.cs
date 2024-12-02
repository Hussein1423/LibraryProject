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

namespace Book_Windows_Forms_App.UserControlesMainAdmin.Request
{
    public partial class GetRequests : UserControl
    {
        int idAdmin;
        enum enColumns
        {
            Accept = 0,
            Reject =1
        }
        bool _ActiveClickEvent;
        public GetRequests(int idAdmin, bool activeClickEvent)
        {
            InitializeComponent();
            this.idAdmin = idAdmin;
            _ActiveClickEvent = activeClickEvent;
            gdgvRequests.EnableHeadersVisualStyles = false;
            gdgvRequests.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(192, 149, 85);
            gdgvRequests.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 43, 32);
        }

        private void gdgvRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_ActiveClickEvent)
            {
              
                if (e.ColumnIndex == (short)enColumns.Accept)
                {
                    int idRequest = (int)gdgvRequests.CurrentRow.Cells[2].Value;
                    clsRequest request = clsRequest.getRequestByID(idRequest);
                    if (!(clsBook.bookIsBorrowing(request.ID_Book)))
                    {
                        if (clsRequest.updateRequest(idRequest, idAdmin, true))
                        {
                            clsBorrowing borrowing = new clsBorrowing();
                            borrowing.IDBook = request.ID_Book;
                            borrowing.IDUserBenefit = request.ID_User_Benefit;
                            borrowing.IDUserRecipient = request.ID_User_Recipient;
                            borrowing.borrowingDate = DateTime.Now;
                            if (borrowing.save())
                            {
                                if (clsBook.updateisBorrowingBook(request.ID_Book, true))
                                {
                                    MessageBox.Show("You have accepted this request successfully!!");
                                    MainAdmin.refresh(gdgvRequests, clsRequest.getAllRequestsWithNullState());
                                }
                                else
                                {
                                    MessageBox.Show("You have an Error in updateBook");
                                }
                            }
                            else
                            {
                                MessageBox.Show("You have an Error in insert borrowing");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("This book is borrowed");
                    }
                }
                else if (e.ColumnIndex == (short)enColumns.Reject)
                {
                    int idRequest = (int)gdgvRequests.CurrentRow.Cells[2].Value;
                    if (clsRequest.updateRequest(idRequest, idAdmin, false))
                    {
                        MessageBox.Show("You have rejected this request successfully!!");
                        MainAdmin.refresh(gdgvRequests, clsRequest.getAllRequestsWithNullState());
                    }
                    else
                    {
                        MessageBox.Show("You have an Error");
                    }

                }
                
            }
        }
    }
}
