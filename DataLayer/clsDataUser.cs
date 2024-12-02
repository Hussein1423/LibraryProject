using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataLayerBook
{
    public class clsDataUser
    {
        static private SqlConnection _connection()
        {
            string connectionString = "Server=.;Database=Books;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
        public static bool getUserByID(int id, ref string fName, ref string mName, ref string lName, ref string password,
            ref string phone, ref string type, ref bool auth)
        {
            SqlConnection connection = _connection();

            string query = "SELECT * from users where ID_User = @id";
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
                    fName = (string)reader["firstName"];
                    lName = (string)reader["lastName"];
                    mName = (string)reader["middleName"];
                    password = (string)reader["password"];
                    phone = (string)reader["phone"];
                    type = (string)reader["type"];
                    auth = (bool)reader["authoriz"];
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


        public static int isExistUserByName(string fName,  string mName,  string lName,  string password)
        {
            SqlConnection connection = _connection();

            string query = "SELECT * from users where firstName=@fName and middleName = @mName and lastName = @lName and password = @password";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("fName", fName);
            cmd.Parameters.AddWithValue("mName", mName);
            cmd.Parameters.AddWithValue("lName", lName);
            cmd.Parameters.AddWithValue("password", password);
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
        public static int insertUser(string fName, string mName, string lName, string password,
           string phone, string type, bool auth)
        {
            int id = -1;
            SqlConnection connection = _connection();
            string query = @"INSERT INTO Users
(
            firstName
           ,middleName
           ,lastName
           ,password
           ,phone
           ,type
           ,authoriz
		   )
     VALUES
           (@firstName
           ,@middleName
           ,@lastName
           ,@password
           ,@phone
           ,@type
           ,@authoriz);
           Select SCOPE_IDENTITY();";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@firstName", fName);
            command.Parameters.AddWithValue("@middleName", mName);
            command.Parameters.AddWithValue("@Password", password);
            command.Parameters.AddWithValue("@lastName", lName);
            command.Parameters.AddWithValue("@phone", phone);
            command.Parameters.AddWithValue("@type", type);
            command.Parameters.AddWithValue("@authoriz", auth);
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

        public static bool updateUser(int id, string fName, string mName, string lName, string password,
           string phone, string type, bool auth)
        {
            int rows = 0;
            SqlConnection connection = _connection();
            string query = @"UPDATE Users
   SET firstName = @firstName
      ,middleName = @middleName
	  ,lastName = @lastName
      ,password = @password
      ,phone = @phone
      ,type = @type
      ,authoriz = @authoriz
 WHERE ID_User = @id;";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("id", id);
            command.Parameters.AddWithValue("firstName", fName);
            command.Parameters.AddWithValue("middleName", mName);
            command.Parameters.AddWithValue("Password", password);
            command.Parameters.AddWithValue("lastName", lName);
            command.Parameters.AddWithValue("phone", phone);
            command.Parameters.AddWithValue("type", type);
            command.Parameters.AddWithValue("authoriz", auth);
            try
            {
                rows = command.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return (rows > 0);
        }

        public static bool deleteUser(int id)
        {
            int rows = 0;
            SqlConnection connection = _connection();
            string query = @"DELETE FROM Users
            WHERE ID_User = @id;";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("id", id);
            try
            {
                rows = command.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return (rows > 0);
        }

        public static DataTable getAllUsers()
        {
            DataTable table = new DataTable();
            SqlConnection connection = _connection();
            string query = "select * from users";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            try
            {
              
                    table.Load(reader);
                
            }
            catch(Exception ex)
            {

            }
            finally
            {
                reader.Close();
                connection.Close();
            }
            return table;
        }

        public static DataTable getAllBenefitUsers()
        {
            DataTable table = new DataTable();
            SqlConnection connection = _connection();
            string query = "select * from users where type = 'Benefit'";
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

        public static DataTable getAllRecipientUsers()
        {
            DataTable table = new DataTable();
            SqlConnection connection = _connection();
            string query = "select * from users where type = 'Recipient'";
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

        public static bool getUserByName(ref int id,string fName,string mName, string lName, ref string password,
           ref string phone, ref string type, ref bool auth)
        {
            SqlConnection connection = _connection();

            string query = "SELECT * from users where firstName = @firstName and middleName = @middleName and lastName = @lastName";

            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("firstName", fName);
            cmd.Parameters.AddWithValue("middleName", mName);
            cmd.Parameters.AddWithValue("lastName", lName);
            SqlDataReader reader = cmd.ExecuteReader();
            bool isFound = false;
            try
            {
                while (reader.Read())
                {
                    isFound = true;
                    id =  Convert.ToInt32(reader["ID"]);
                    password = (string)reader["password"];
                    phone = (string)reader["phone"];
                    type = (string)reader["type"];
                    auth = (bool)reader["authoriz"];
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

        public static int getUserByName(string fName, string mName, string lName)
        {
            SqlConnection connection = _connection();

            string query = "SELECT ID_User from users where firstName = @firstName and middleName = @middleName and lastName = @lastName";

            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("firstName", fName);
            cmd.Parameters.AddWithValue("middleName", mName);
            cmd.Parameters.AddWithValue("lastName", lName);
            int id = -1;
            try
            {
               object rel = cmd.ExecuteScalar();
                if (rel != DBNull.Value)
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

        static public DataTable usersSearchStartWith(string Letters)
        {
            DataTable users = new DataTable();
            SqlConnection connection = _connection();
            string query = @"SELECT * FROM users where firstName LIKE '' + @Letters +'%' or 
                            middleName LIKE '' + @Letters +'%' or lastName LIKE '' + @Letters +'%'";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Letters", Letters);
            SqlDataReader reader = command.ExecuteReader();
            try
            {

                users.Load(reader);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                reader.Close();
                connection.Close();
            }
            return users;
        }
    }
}