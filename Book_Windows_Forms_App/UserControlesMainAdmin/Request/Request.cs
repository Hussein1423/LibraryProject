using Book_Windows_Forms_App.UserControlesBenefitScreen;
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
    public partial class Request : UserControl
    {
        int idAdmin;
        public Request(int idAdmin)
        {
            InitializeComponent();
            this.idAdmin = idAdmin;
        }

        private void gabShowAllRequests_Click(object sender, EventArgs e)
        {
            
            GetRequests requests = new GetRequests(idAdmin,false);
            requests.gdgvRequests.DataSource = clsRequest.getAllRequests();
            MainAdmin.addUserControlTosubScreen(requests);
        }

        private void gabInsertBook_Click(object sender, EventArgs e)
        {
            GetRequests requests = new GetRequests(idAdmin,true);
            requests.gdgvRequests.DataSource = clsRequest.getAllRequestsWithNullState();
            DataGridViewButtonColumn btnAccept = new DataGridViewButtonColumn();
            btnAccept.HeaderText = "Accept State";
            btnAccept.Text = "Accept";
            btnAccept.Name = "btnAccept";
            btnAccept.UseColumnTextForButtonValue = true;
            requests.gdgvRequests.Columns.Add(btnAccept);

            DataGridViewButtonColumn btnReject = new DataGridViewButtonColumn();
            btnReject.HeaderText = "Reject State";
            btnReject.Text = "Reject";
            btnReject.Name = "btnReject";
            btnReject.UseColumnTextForButtonValue = true;
            requests.gdgvRequests.Columns.Add(btnReject);

            MainAdmin.addUserControlTosubScreen(requests);
        }
    }
}
