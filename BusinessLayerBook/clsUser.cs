using DataLayerBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Security.Cryptography;

namespace BusinessLayerBook
{
    public class clsUser
    {
      
        public enum eMode
        {
            InsertMode,
            UpdateMode
        }
        public eMode mode = eMode.InsertMode;
        public int ID { get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }

        public string password { get; set; }

        public string phone { get; set; }

        public bool authoriz { get; set; }

        public string type { get; set; }

        private bool _InsertUser()
        {
            this.ID = clsDataUser.insertUser(this.firstName, this.middleName, this.lastName, this.password, this.phone, this.type, this.authoriz);
            new clsUser(ID, firstName, middleName, lastName,clsUtility.Encrypt( password), phone, authoriz, type);
            return (ID != -1);
        }

        private bool _UpdateUser()
        {
            return clsDataUser.updateUser(ID, firstName, middleName, lastName,clsUtility.Encrypt( password), phone, type, authoriz);
        }

        private clsUser(int id, string firstName, string middleName, string lastName, string password, string phone, bool authoriz, string type)
        {

            ID = id;
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.password = password;
            this.phone = phone;
            this.authoriz = authoriz;
            this.type = type;
            mode = eMode.UpdateMode;
        }

        public clsUser()
        {
            mode = eMode.InsertMode;
            ID = -1;
            firstName = string.Empty;
            middleName = string.Empty;
            lastName = string.Empty;
            password = string.Empty;
            phone = string.Empty;
            authoriz = false;
            type = string.Empty;

        }

        static public clsUser getUserByID(int id)
        {
            string firstName = "", middleName = "", lastName = "", password = "", phone = "", type = "";
            bool authoriz = false;
            bool isFound = clsDataUser.getUserByID(id, ref firstName, ref middleName, ref lastName, ref password, ref phone, ref type, ref authoriz);
            if (isFound)
            {
                return new clsUser(id, firstName, middleName, lastName, password, phone, authoriz, type);
            }
            else
            {
                return null;
            }
        }

        static public DataTable usersSearchWithLetters(string letters)
        {
            return clsDataUser.usersSearchStartWith(letters);
        }

        static public int getIDByName(string firstName, string middleName, string lastName)
        {

            int id = -1;
            id = clsDataUser.getUserByName(firstName, middleName, lastName);
            return id;
        }

        static public clsUser getUserByName(string fName, string mName, string lName)
        {
            string password = "", phone = "", type = "";
            bool authoriz = false;
            int id = -1;
            bool isFound = clsDataUser.getUserByName(ref id, fName, mName, lName, ref password, ref phone, ref type, ref authoriz);
            if (isFound)
            {
                return new clsUser(id, fName, mName, lName, password, phone, authoriz, type);
            }
            else
            {
                return null;
            }
        }
        static public int getIDUserByName(string firstName, string middleName, string lastName)
        {
            return clsDataUser.getUserByName(firstName, middleName, lastName);
        }

        static public bool deleteUser(int id)
        {
            return clsDataUser.deleteUser(id);
        }

        static public DataTable getAllUsers()
        {
            return clsDataUser.getAllUsers();
        }

        public bool save()
        {
            switch (mode)
            {
                case eMode.InsertMode:
                    if (_InsertUser())
                    {
                        mode = eMode.UpdateMode;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case eMode.UpdateMode:
                    return _UpdateUser();

                default: return false;
            }
        }

        public static DataTable getAllBenefitUsers()
        {
            return clsDataUser.getAllBenefitUsers();
        }
        public static DataTable getAllRecipientUsers() { return clsDataUser.getAllRecipientUsers(); }
        public static int isExistUserByName(string fName,  string mName,  string lName, string  password)
        {
           int id = clsDataUser.isExistUserByName(fName, mName, lName, clsUtility.Encrypt( password));
            return id;
        }
    }
}
