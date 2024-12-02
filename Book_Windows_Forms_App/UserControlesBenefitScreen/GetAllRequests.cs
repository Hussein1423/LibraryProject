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
    public partial class GetAllRequests : UserControl
    {
        int idBenefit=0;
        public GetAllRequests(int idBenefit)
        {
            InitializeComponent();
            this.idBenefit = idBenefit;
       
            gdgvRequsts.EnableHeadersVisualStyles = false;
            gdgvRequsts.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(192, 149, 85);
            gdgvRequsts.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 43, 32);

        }

        private void GetAllRequests_Load(object sender, EventArgs e)
        {

            MainAdmin.refresh(gdgvRequsts, clsRequest.getAllRequestsForBenefitUser(idBenefit));
        }
    }
}
