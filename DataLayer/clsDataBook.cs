using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerBook
{
    public class clsDataBook
    {
        static private SqlConnection _connection()
        {
            string connectionString = "Server=.;Database=Books;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
        public static bool getBookByID(int id, ref string bookName, ref short? part, ref bool isBorrowing)
        {
            SqlConnection connection = _connection();

            string query = "SELECT * from books where ID_Book = @id";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            bool isFound = false;
            try
            {
                while (reader.Read())
                {
                    isFound = true;
                    bookName = reader["Book_Name"] as string;
                    isBorrowing = (bool)reader["is_Borrow"];
              
                    // التحقق من الحقل Part إذا كان غير فارغ
                    if (reader["Part"] != DBNull.Value)
                    {
                        part = (short)reader["Part"];
                    }
                    else
                    {
                        part = null; // استخدم نوع short? (nullable) لتعطي قيمة فارغة
                    }
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

        static public bool bookIsBorrowing(int id)
        {
            SqlConnection connection = _connection();
            string query = @"Select is_Borrow FROM Books
      WHERE ID_Book = @IDBook;";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            bool isBorrowing = false;
            command.Parameters.AddWithValue("IDBook", id);
            try
            {
                object rel = command.ExecuteScalar();
                if (rel != DBNull.Value)
                {
                    isBorrowing = (bool)rel;
                }
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return isBorrowing;
        }
        static public DataTable bookSearchStartWith(string Letters)
        {
            DataTable books = new DataTable();
            SqlConnection connection = _connection();
            string query = "SELECT * FROM books where  Book_Name LIKE '' + @Letters +'%'";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Letters", Letters);
            SqlDataReader reader = command.ExecuteReader();
            try
            {

                books.Load(reader);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                reader.Close();
                connection.Close();
            }
            return books;
        }
        public static int isExistBookByName(string bookName, short? part)
        {
            SqlConnection connection = _connection();

            string query = "SELECT * from books where Book_Name=@bookName and part = @part or  Book_Name=@bookName and part is null";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("bookName", bookName);
            cmd.Parameters.AddWithValue("@Part", (object)part ?? DBNull.Value);
            int id = -1;
            try
            {
                object rel = cmd.ExecuteScalar();
                if (rel != null)
                {
                    id = Convert.ToInt32(rel);
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return id;
        }

        public static int isExistBookByName(string bookName)
        {
            SqlConnection connection = _connection();

            string query = "SELECT ID_Book from books where Book_Name=@bookName";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("bookName", bookName);
            int id = -1;
            try
            {
                object rel = cmd.ExecuteScalar();
                if (rel != null)
                {
                    id = Convert.ToInt32(rel);
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return id;
        }
        public static int insertBook(string bookName, short? part,  bool isBorrowing)
        {
            int id = -1;
            SqlConnection connection = _connection();
            string query = @"INSERT INTO Books
           (Book_Name
           ,Part
           ,is_Borrow)
     VALUES
           (@Book_Name
           ,@Part
           ,@is_Borrow);
           Select SCOPE_IDENTITY();";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Book_Name", bookName);
            command.Parameters.AddWithValue("@Part", (object)part ?? DBNull.Value);

            command.Parameters.AddWithValue("@is_Borrow", isBorrowing);
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

        public static bool updateBook(int id, string bookName, short? part,  bool isBorrowing)
        {
            int rows = 0;
            SqlConnection connection = _connection();
            string query = @"UPDATE Books
   SET Book_Name = @Book_Name
      ,Part = @Part
      ,is_Borrow = @is_Borrow
 WHERE ID_Book = @ID_Book;";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("ID_Book", id);
            command.Parameters.AddWithValue("Book_Name", bookName);
            command.Parameters.AddWithValue("@Part", (object)part ?? DBNull.Value);
            command.Parameters.AddWithValue("is_Borrow", isBorrowing);
            try
            {
                rows = command.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return (rows > 0);
        }

        public static bool updateisBorrowingBook(int id,bool isBorrowing)
        {
            int rows = 0;
            SqlConnection connection = _connection();
            string query = @"UPDATE Books
   SET is_Borrow = @is_Borrow
 WHERE ID_Book = @ID_Book;";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("ID_Book", id);
            command.Parameters.AddWithValue("is_Borrow", isBorrowing);
            try
            {
                rows = command.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return (rows > 0);
        }

        public static bool deleteBook(int id)
        {
            int rows = 0;
            SqlConnection connection = _connection();
            string query = @"DELETE FROM Books
      WHERE ID_Book = @IDBook;";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("IDBook", id);
            try
            {
                rows = command.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return (rows > 0);
        }

        public static DataTable getAllBooks()
        {
            DataTable table = new DataTable();
            SqlConnection connection = _connection();
            string query = "select * from books";
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

        
    }
}

