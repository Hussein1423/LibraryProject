using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DataLayerBook
{
    public class clsDataBorrowing
    {
        static private SqlConnection _connection()
        {
            string connectionString = "Server=.;Database=Books;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
        public static bool getBorrowingByIDUserBenefit(int IDUserBenefit, ref int  IDUserRecipient, ref int IDBorrowing, ref int IDBook,ref DateTime borrowingDate,ref DateTime? recoveryDate)
        {
            SqlConnection connection = _connection();

            string query = @"
SELECT *
  FROM Borrowings where ID_User_Benefit = @IDUserBenefit;";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("IDUserBenefit", IDUserBenefit);
            SqlDataReader reader = cmd.ExecuteReader();
            bool isFound = false;
            try
            {
                while (reader.Read())
                {
                    isFound = true;
                    IDBorrowing   = (int)reader["ID_Borrowing"];
                    IDUserRecipient = (int)reader["ID_User_Recipient"];
                    IDBook = (int)reader["ID_Book"];
                    borrowingDate = (DateTime)reader["Borrowing_Date"];
                    recoveryDate = (DateTime?)reader["Recovery_Date"];
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                reader.Close();
                connection.Close();
            }
            return isFound;
        }

        public static int getNumberofMyBooksForRecipient(int id)
        {
          
            SqlConnection connection = _connection();
            string query = @"
SELECT Count(ID_Borrowing)
  FROM Borrowings
  where ID_User_Recipient = @id;";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("id", id);
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

        public static int getNumberofMyBooksForBenefit(int id)
        {

            SqlConnection connection = _connection();
            string query = @"
SELECT Count(ID_Borrowing)
  FROM Borrowings
  where ID_User_Benefit = @id;";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("id", id);
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
        public static bool getBorrowingByBorrowingID(ref int IDUserBenefit, ref int IDUserRecipient,  int IDBorrowing, ref int IDBook, ref DateTime borrowingDate, ref DateTime? recoveryDate)
        {
            SqlConnection connection = _connection();

            string query = @"
SELECT * FROM Borrowings where ID_Borrowing = @IDBorrowing;";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("IDBorrowing", IDBorrowing);
            SqlDataReader reader = cmd.ExecuteReader();
            bool isFound = false;
            try
            {
                while (reader.Read())
                {
                    isFound = true;
                    IDUserBenefit = (int)reader["ID_User_Benefit"];
                    IDUserRecipient = (int)reader["ID_User_Recipient"];
                    IDBook = (int)reader["ID_Book"];
                    borrowingDate = (DateTime)reader["Borrowing_Date"];
                    recoveryDate = (DateTime?)reader["Recovery_Date"];
                  
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                reader.Close();
                connection.Close();
            }
            return isFound;
        }

        //public static int isExistBookByName(string bookName, short? part)
        //{
        //    SqlConnection connection = _connection();

        //    string query = "SELECT * from books where Book_Name=@bookName and part = @part";
        //    connection.Open();
        //    SqlCommand cmd = new SqlCommand(query, connection);
        //    cmd.Parameters.AddWithValue("bookName", bookName);
        //    cmd.Parameters.AddWithValue("part", part);
        //    int id = -1;
        //    try
        //    {
        //        object rel = cmd.ExecuteScalar();
        //        if (rel != null)
        //        {
        //            id = Convert.ToInt32(rel);
        //        }

        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }
        //    return id;
        //}
        public static int insertBorrowing(int IDUserRecipient, int IDUserBenefit,int IDBook,DateTime borrowingDate,DateTime? recoveryDate)
        {
            int id = -1;
            SqlConnection connection = _connection();
            string query = @"INSERT INTO Borrowings
           (ID_User_Recipient
           ,ID_User_Benefit
           ,ID_Book
           ,Borrowing_Date
           ,Recovery_Date
           )
     VALUES
           (@IDUserRecipient
           ,@IDUserBenefit
           ,@IDBook
           ,@BorrowingDate
           ,@RecoveryDate
           );
           Select SCOPE_IDENTITY();";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("IDUserRecipient", IDUserRecipient);
            command.Parameters.AddWithValue("IDUserBenefit", IDUserBenefit);
            command.Parameters.AddWithValue("IDBook", IDBook);
            command.Parameters.AddWithValue("BorrowingDate", borrowingDate);
            command.Parameters.AddWithValue("RecoveryDate", (object) recoveryDate ?? DBNull.Value);
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

        public static bool updateBorrowing(int ID_Borrowing,int ID_User_Recipient,int ID_User_Benefit,int ID_Book,DateTime borrowingDate,DateTime? recoveryDate)
        {
            int rows = 0;
            SqlConnection connection = _connection();
            string query = @"UPDATE Borrowings
   SET ID_User_Recipient = @IDUserRecipient
      ,ID_User_Benefit = @IDUserBenefit
      ,ID_Book = @IDBook
      ,Borrowing_Date = @BorrowingDate
      ,Recovery_Date = @RecoveryDate
    
 WHERE ID_Borrowing = @IDBorrowing;";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("IDBorrowing", ID_Borrowing);
            command.Parameters.AddWithValue("IDUserRecipient", ID_User_Recipient);
            command.Parameters.AddWithValue("IDUserBenefit", ID_User_Benefit);
            command.Parameters.AddWithValue("IDBook", ID_Book);
            command.Parameters.AddWithValue("BorrowingDate", borrowingDate);
            command.Parameters.AddWithValue("RecoveryDate", (object)recoveryDate ?? DBNull.Value);
            try
            {
                rows = command.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return (rows > 0);
        }

        public static bool deleteBorrowing(int IDBorrowing)
        {
            int rows = 0;
            SqlConnection connection = _connection();
            string query = @"DELETE FROM Borrowings
      WHERE ID_Borrowing = @IDBorrowing;";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("IDBorrowing", IDBorrowing);
            try
            {
                rows = command.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return (rows > 0);
        }

        public static DataTable getAllBorrowings()
        {
            DataTable table = new DataTable();
            SqlConnection connection = _connection();
            string query = @"SELECT Borrowings.ID_Borrowing,Users.firstName AS RecipientFirstName,
            Users.middleName AS RecipientMiddleName,
            Users.lastName AS RecipientLastName,
            Users_1.firstName AS BeneficiaryFirstName,
            Users_1.middleName AS BeneficiaryMiddleName,
            Users_1.lastName AS BeneficiaryLastName,
            Books.Book_Name,  Books.Part,
            Borrowings.Borrowing_Date,  Borrowings.Recovery_Date
            FROM Borrowings INNER JOIN Books
            ON Books.ID_Book = Borrowings.ID_Book INNER JOIN Users 
            ON Borrowings.ID_User_Recipient = Users.ID_User 
            INNER JOIN Users AS Users_1 
            ON Borrowings.ID_User_Benefit = Users_1.ID_User;";
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

        public static DataTable getAllBorrowingsForSpecificRecipient(int id)
        {
            DataTable table = new DataTable();
            SqlConnection connection = _connection();
            string query = @"SELECT Borrowings.ID_Borrowing,Users.firstName AS RecipientFirstName,
            Users.middleName AS RecipientMiddleName,
            Users.lastName AS RecipientLastName,
            Users_1.firstName AS BeneficiaryFirstName,
            Users_1.middleName AS BeneficiaryMiddleName,
            Users_1.lastName AS BeneficiaryLastName,
            Books.Book_Name,  Books.Part,
            Borrowings.Borrowing_Date,  Borrowings.Recovery_Date
             FROM Borrowings INNER JOIN Books
            ON Books.ID_Book = Borrowings.ID_Book INNER JOIN Users 
            ON Borrowings.ID_User_Recipient = Users.ID_User 
            INNER JOIN Users AS Users_1 
            ON Borrowings.ID_User_Benefit = Users_1.ID_User Where Users.ID_User = @ID_User;";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("ID_User", id);
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

        public static DataTable getAllBorrowingsForSpecificBenefit(int id)
        {
            DataTable table = new DataTable();
            SqlConnection connection = _connection();
            string query = @"SELECT Borrowings.ID_Borrowing,Users.firstName AS RecipientFirstName,
            Users.middleName AS RecipientMiddleName,
            Users.lastName AS RecipientLastName,
            Users_1.firstName AS BeneficiaryFirstName,
            Users_1.middleName AS BeneficiaryMiddleName,
            Users_1.lastName AS BeneficiaryLastName,
            Books.Book_Name,  Books.Part,
            Borrowings.Borrowing_Date,  Borrowings.Recovery_Date
             FROM Borrowings INNER JOIN Books
            ON Books.ID_Book = Borrowings.ID_Book INNER JOIN Users 
            ON Borrowings.ID_User_Recipient = Users.ID_User 
            INNER JOIN Users AS Users_1 
            ON Borrowings.ID_User_Benefit = Users_1.ID_User Where Users_1.ID_User = @ID_User;";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("ID_User", id);
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

        public static DataTable benefitsSearchWithLetters(string letters)
        {
            DataTable table = new DataTable();
            SqlConnection connection = _connection();
            string query = @"SELECT Borrowings.ID_Borrowing,Users.firstName AS RecipientFirstName,
            Users.middleName AS RecipientMiddleName,
            Users.lastName AS RecipientLastName,
            Users_1.firstName AS BeneficiaryFirstName,
            Users_1.middleName AS BeneficiaryMiddleName,
            Users_1.lastName AS BeneficiaryLastName,
            Books.Book_Name,  Books.Part,
            Borrowings.Borrowing_Date,  Borrowings.Recovery_Date
           FROM Borrowings INNER JOIN Books
            ON Books.ID_Book = Borrowings.ID_Book INNER JOIN Users 
            ON Borrowings.ID_User_Recipient = Users.ID_User 
            INNER JOIN Users AS Users_1 
            ON Borrowings.ID_User_Benefit = Users_1.ID_User where Users_1.firstName LIKE '' + @Letters +'%';";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("Letters", letters);
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

        public static DataTable recipientsSearchWithLetters(string letters)
        {
            DataTable table = new DataTable();
            SqlConnection connection = _connection();
            string query = @"SELECT Borrowings.ID_Borrowing,Users.firstName AS RecipientFirstName,
            Users.middleName AS RecipientMiddleName,
            Users.lastName AS RecipientLastName,
            Users_1.firstName AS BeneficiaryFirstName,
            Users_1.middleName AS BeneficiaryMiddleName,
            Users_1.lastName AS BeneficiaryLastName,
            Books.Book_Name,  Books.Part,
            Borrowings.Borrowing_Date,  Borrowings.Recovery_Date
             FROM Borrowings INNER JOIN Books
            ON Books.ID_Book = Borrowings.ID_Book INNER JOIN Users 
            ON Borrowings.ID_User_Recipient = Users.ID_User 
            INNER JOIN Users AS Users_1 
            ON Borrowings.ID_User_Benefit = Users_1.ID_User where Users.firstName LIKE '' + @Letters +'%';";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("Letters", letters);
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

        public static DataTable booksSearchWithLetters(string letters)
        {
            DataTable table = new DataTable();
            SqlConnection connection = _connection();
            string query = @"SELECT Borrowings.ID_Borrowing,Users.firstName AS RecipientFirstName,
            Users.middleName AS RecipientMiddleName,
            Users.lastName AS RecipientLastName,
            Users_1.firstName AS BeneficiaryFirstName,
            Users_1.middleName AS BeneficiaryMiddleName,
            Users_1.lastName AS BeneficiaryLastName,
            Books.Book_Name,  Books.Part,
            Borrowings.Borrowing_Date,  Borrowings.Recovery_Date
           FROM Borrowings INNER JOIN Books
            ON Books.ID_Book = Borrowings.ID_Book INNER JOIN Users 
            ON Borrowings.ID_User_Recipient = Users.ID_User 
            INNER JOIN Users AS Users_1 
            ON Borrowings.ID_User_Benefit = Users_1.ID_User where Books.Book_Name LIKE '' + @Letters +'%';";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("Letters", letters);
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



    }
}
