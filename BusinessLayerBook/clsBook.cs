using DataLayerBook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerBook
{
    public class clsBook
    {
        public enum eMode
        {
            InsertMode,
            UpdateMode
        }
        public eMode mode = eMode.InsertMode;
        public int ID { get; set; }

        public string bookName { get; set; }
       
        public bool isBorrowing { get; set; }

        public short? part { get; set; }

        private bool _InsertBook()
        {
            this.ID = clsDataBook.insertBook(bookName,part,isBorrowing);
            return (ID != -1);
        }

        private bool _UpdateBook()
        {
            return clsDataBook.updateBook(ID,bookName,part,isBorrowing);
        }

        private clsBook(int id, string bookName,short? part, bool isBorrowing)
        {

            ID = id;
            this.bookName = bookName;
            this.part =part;
            this.isBorrowing = isBorrowing;
            mode = eMode.UpdateMode;
        }

        public clsBook()
        {
            mode = eMode.InsertMode;
            ID = -1;
            bookName = string.Empty;
            isBorrowing = false;
            part = -1;

        }

        static public DataTable bookSearchWithLetters(string bookName)
        {
            return clsDataBook.bookSearchStartWith(bookName);
        }
        static public clsBook getBookByID(int id)
        {
            string bookName = "";
            bool isBorrowing = false;
            short? part = null;
            bool isFound = clsDataBook.getBookByID(id, ref bookName, ref part, ref isBorrowing);
            if (isFound)
            {
                return new clsBook(id, bookName,part,isBorrowing);
            }
            else
            {
                return null;
            }
        }

        static public int getBookByName(string bookName,short? part)
        {
          
            int id = -1;
            id = clsDataBook.isExistBookByName(bookName,part);
            if (id!=-1)
            {
                return id;
            }
            else
            {
                return -1;
            }
        }

        static public int getBookByName(string bookName)
        {

            int id = -1;
            id = clsDataBook.isExistBookByName(bookName);
            if (id != -1)
            {
                return id;
            }
            else
            {
                return -1;
            }
        }

        static public bool deleteBook(int id)
        {
            return clsDataBook.deleteBook(id);
        }

        static public DataTable getAllBooks()
        {
            return clsDataBook.getAllBooks();
        }

        public static bool updateisBorrowingBook(int id, bool isBorrowing)
        {
            return clsDataBook.updateisBorrowingBook(id, isBorrowing);
        }

        public static bool bookIsBorrowing(int id)
        {
            return clsDataBook.bookIsBorrowing(id);
        }

        public bool save()
        {
            switch (mode)
            {
                case eMode.InsertMode:
                    if (_InsertBook())
                    {
                        mode = eMode.UpdateMode;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case eMode.UpdateMode:
                    return _UpdateBook();

                default: return false;
            }
        }

        public static bool isExistBookByName(string bookName,short part)
        {
            int id = clsDataBook.isExistBookByName(bookName,part);
            return (id!=-1);
        }
    }
}

