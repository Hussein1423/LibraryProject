using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class clsDataRequest
    {
        static private SqlConnection _connection()
        {
            string connectionString = "Server=.;Database=Books;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
        public static DataTable getAllRequests()
        {
            DataTable table = new DataTable();
            SqlConnection connection = _connection();
            string query = @"SELECT 
    Requests.ID_Request, 
    UserBenefit.firstName AS BenefitFirstName, 
    UserBenefit.middleName AS BenefitMiddleName, 
    UserBenefit.lastName AS BenefitLastName, 
    UserRecipient.firstName AS RecipientFirstName, 
    UserRecipient.middleName AS RecipientMiddleName, 
    UserRecipient.lastName AS RecipientLastName, 
    UserAdmin.firstName AS AdminFirstName, 
    UserAdmin.middleName AS AdminMiddleName, 
    UserAdmin.lastName AS AdminLastName, 
    Books.Book_Name, 
    Books.Part, 
    Requests.State
FROM Requests 
LEFT JOIN Users AS UserBenefit 
    ON Requests.ID_User_Benefit = UserBenefit.ID_User
LEFT JOIN Users AS UserRecipient 
    ON Requests.ID_User_Recipient = UserRecipient.ID_User
LEFT JOIN Users AS UserAdmin 
    ON Requests.ID_User_Admin = UserAdmin.ID_User
INNER JOIN Books 
    ON Requests.ID_Book = Books.ID_Book;
";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            try
            {

                table.Load(reader);

            }
            catch (Exception ex)
            {

            }
            finally
            {
                reader.Close();
                connection.Close();
            }
            return table;
        }
        public static DataTable getAllRequestsForBenefitUser(int IDBenefit)
        {
            DataTable table = new DataTable();
            SqlConnection connection = _connection();
            string query = @"SELECT 
    Requests.ID_Request, 
    UserBenefit.firstName AS BenefitFirstName, 
    UserBenefit.middleName AS BenefitMiddleName, 
    UserBenefit.lastName AS BenefitLastName, 
    UserRecipient.firstName AS RecipientFirstName, 
    UserRecipient.middleName AS RecipientMiddleName, 
    UserRecipient.lastName AS RecipientLastName, 
    UserAdmin.firstName AS AdminFirstName, 
    UserAdmin.middleName AS AdminMiddleName, 
    UserAdmin.lastName AS AdminLastName, 
    Books.Book_Name, 
    Books.Part, 
    Requests.State
FROM Requests 
LEFT JOIN Users AS UserBenefit 
    ON Requests.ID_User_Benefit = UserBenefit.ID_User
LEFT JOIN Users AS UserRecipient 
    ON Requests.ID_User_Recipient = UserRecipient.ID_User
LEFT JOIN Users AS UserAdmin 
    ON Requests.ID_User_Admin = UserAdmin.ID_User
INNER JOIN Books 
    ON Requests.ID_Book = Books.ID_Book where Requests.ID_User_Benefit = @IDUserBenefit;
";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("IDUserBenefit", IDBenefit);
            SqlDataReader reader = command.ExecuteReader();
            try
            {

                table.Load(reader);

            }
            catch (Exception ex)
            {

            }
            finally
            {
                reader.Close();
                connection.Close();
            }
            return table;
        }

        public static DataTable getAllRequestsWithNullState()
        {
            DataTable table = new DataTable();
            SqlConnection connection = _connection();
            string query = @"SELECT 
    Requests.ID_Request, 
    UserBenefit.firstName AS BenefitFirstName, 
    UserBenefit.middleName AS BenefitMiddleName, 
    UserBenefit.lastName AS BenefitLastName, 
    UserRecipient.firstName AS RecipientFirstName, 
    UserRecipient.middleName AS RecipientMiddleName, 
    UserRecipient.lastName AS RecipientLastName, 
    UserAdmin.firstName AS AdminFirstName, 
    UserAdmin.middleName AS AdminMiddleName, 
    UserAdmin.lastName AS AdminLastName, 
    Books.Book_Name, 
    Books.Part, 
    Requests.State
FROM Requests 
LEFT JOIN Users AS UserBenefit 
    ON Requests.ID_User_Benefit = UserBenefit.ID_User
LEFT JOIN Users AS UserRecipient 
    ON Requests.ID_User_Recipient = UserRecipient.ID_User
LEFT JOIN Users AS UserAdmin 
    ON Requests.ID_User_Admin = UserAdmin.ID_User
INNER JOIN Books 
    ON Requests.ID_Book = Books.ID_Book where  Requests.State is null ;
";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            try
            {

                table.Load(reader);

            }
            catch (Exception ex)
            {

            }
            finally
            {
                reader.Close();
                connection.Close();
            }
            return table;
        }
        public static int insertRequest(int IDUserBenefit, int IDUserRecipient, int IDBook,int? IDUserAdmin, bool? state)
        {
            int id = -1;
            SqlConnection connection = _connection();
            string query = @"INSERT INTO Requests
           (ID_User_Benefit
           ,ID_User_Recipient
           ,ID_Book
           ,ID_User_Admin
           ,State)
     VALUES
           (@IDUserBenefit
           ,@IDUserRecipient
           ,@IDBook
           ,@IDUserAdmin
           ,@State)
          Select SCOPE_IDENTITY();";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("IDUserRecipient", IDUserRecipient);
            command.Parameters.AddWithValue("IDUserBenefit", IDUserBenefit);
            command.Parameters.AddWithValue("IDBook", IDBook);
            command.Parameters.AddWithValue("IDUserAdmin", (object)IDUserAdmin ?? DBNull.Value);
            command.Parameters.AddWithValue("State", (object)state ?? DBNull.Value);
            try
            {
                object rel = command.ExecuteScalar();
                if (rel != null)
                {
                    id = Convert.ToInt32(rel);
                }

            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return id;
        }

        public static bool updateRequest(int IDRequest, int? IDUserAdmin, bool? state)
        {
            int rows = 0;
            SqlConnection connection = _connection();
            string query = @"UPDATE Requests
   SET ID_User_Admin = @IDUserAdmin,
      State = @State
 WHERE ID_Request = @IDRequest;";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("IDRequest", IDRequest);
            command.Parameters.AddWithValue("IDUserAdmin", (object)IDUserAdmin ?? DBNull.Value);
            command.Parameters.AddWithValue("State", (object)state ?? DBNull.Value);
            try
            {
                rows = command.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return (rows > 0);
        }

        public static bool deleteRequests(int IDRequest)
        {
            int rows = 0;
            SqlConnection connection = _connection();
            string query = @"DELETE FROM Requests
     WHERE ID_Request = @IDRequest;";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("IDRequest", IDRequest);
            try
            {
                rows = command.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return (rows > 0);
        }

        public static bool getRequestbyId(int IDRequest, ref int IDUserBenefit,ref int IDUserRecipient,ref int IDBook,ref int? IDUserAdmin,ref bool? state)
        {
            bool isFound = false;
            SqlConnection connection = _connection();
            string query = @"select * from requests where ID_Request = @IDRequest";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("IDRequest", IDRequest);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    IDUserBenefit = (int)reader["ID_User_Benefit"];
                    IDUserRecipient = (int)reader["ID_User_Recipient"];
                    IDBook = (int)reader["ID_Book"];
                    if (reader["ID_User_Admin"] != DBNull.Value)
                    {
                        IDUserAdmin = (int)reader["ID_User_Admin"];
                    }
                    else
                    {
                        IDUserAdmin = null;
                    }
                    if (reader["State"] != DBNull.Value)
                    {
                        state = (bool)reader["State"];
                    }
                    else
                    {
                        state = null;
                    }
                    isFound = true;
                }
               
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return isFound;
        }

    }
}
