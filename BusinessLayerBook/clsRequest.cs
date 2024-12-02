using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerBook
{
    public class clsRequest
    {
        public int ID_User_Benefit { get; set; }
        public int ID_User_Recipient { get; set; }

        public int ID_Book { get; set; }

        public int? ID_User_Admin { get; set; }

        public int ID_Request { get; set; }

        public bool? state { get; set; }

       private clsRequest(int ID_Request, int ID_User_Benefit, int ID_User_Recipient, int? ID_User_Admin, int ID_Book, bool? state)
        {
            this.ID_Request = ID_Request;
            this.ID_User_Benefit = ID_User_Benefit;
            this.ID_User_Recipient = ID_User_Recipient;
            this.ID_User_Admin = ID_User_Admin;
            this.ID_Book = ID_Book;
            this.state = state;
        }
        public clsRequest()
        {
            ID_Request = -1;
            ID_User_Benefit = -1;
            ID_User_Recipient = -1;
            ID_User_Admin = null;
            ID_Book = -1;
            state = false;


        }

        public static DataTable getAllRequests()
        {
            return clsDataRequest.getAllRequests();
        }
        public static DataTable getAllRequestsForBenefitUser(int IdBenefitUser)
        {
            return clsDataRequest.getAllRequestsForBenefitUser(IdBenefitUser);
        }

        public static DataTable getAllRequestsWithNullState()
        {
            return clsDataRequest.getAllRequestsWithNullState();
        }
        public static bool deleteRequest(int ID_Request)
        {
            return clsDataRequest.deleteRequests(ID_Request);
        }

        public static bool insertRequest(int ID_User_Benefit, int ID_User_Recipient, int? ID_User_Admin, int ID_Book, bool? state)
        {
            return (clsDataRequest.insertRequest(ID_User_Benefit, ID_User_Recipient, ID_Book, ID_User_Admin, state) != -1);
        }

        public static bool updateRequest(int ID_Request, int? ID_User_Admin, bool? state)
        {
            return clsDataRequest.updateRequest(ID_Request, ID_User_Admin, state);
        }

        static public clsRequest getRequestByID(int id)
        {
           int IDUserBenefit=0, IDUserRecipient=0, IDBook=0;
           int? IDUserAdmin=null ;
            bool? state=null ;
            bool isFound = clsDataRequest.getRequestbyId(id,ref IDUserBenefit,ref IDUserRecipient,ref IDBook,ref IDUserAdmin,ref state);
            if (isFound)
            {
                return new clsRequest(id, IDUserBenefit, IDUserRecipient, IDUserAdmin, IDBook, state);
            }
            else
            {
                return null;
            }
        
        }

    }

}

