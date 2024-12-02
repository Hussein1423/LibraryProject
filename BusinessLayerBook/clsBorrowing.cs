using DataLayerBook;
using System;
using System.Data;

namespace BusinessLayerBook
{
    public class clsBorrowing
    {
        public enum eMode
        {
            InsertMode,
            UpdateMode
        }
        public eMode mode = eMode.InsertMode;
        public int IDBorrowing { get; set; }

        public int IDUserRecipient { get; set; }

        public int IDUserBenefit { get; set; }

        public int IDBook { get; set; }

        public DateTime borrowingDate { get; set; }

        public DateTime? recoveryDate { get; set; }

      


        private bool _InsertBorrowing()
        {
            this.IDBorrowing = clsDataBorrowing.insertBorrowing(IDUserRecipient, IDUserBenefit, IDBook, borrowingDate, recoveryDate);
            if (IDBorrowing != -1)
            {
                mode = eMode.UpdateMode;
                return true;
            }
            else
            {
                return false;
            }

        }

        private bool _UpdateBorrowing()
        {
            return clsDataBorrowing.updateBorrowing(IDBorrowing, IDUserRecipient, IDUserBenefit, IDBook, borrowingDate, recoveryDate);
        }

        private clsBorrowing(int IDBorrowing, int IDUserRecipient, int IDUserBenefit, int IDBook, DateTime borrowingDate, DateTime? recoveryDate)
        {

            this.IDBorrowing = IDBorrowing;
            this.IDUserRecipient = IDUserRecipient;
            this.IDUserBenefit = IDUserBenefit;
            this.IDBook = IDBook;
            this.borrowingDate = borrowingDate;
            this.recoveryDate = recoveryDate;
  
            mode = eMode.UpdateMode;


        }

        public clsBorrowing()
        {
            mode = eMode.InsertMode;
            this.IDBorrowing = -1;
            this.IDUserRecipient = 0;
            this.IDUserBenefit = 0;
            this.IDBook = 0;
            this.borrowingDate = DateTime.MinValue;
            this.recoveryDate = null; 
        }

        static public clsBorrowing getBorrowingByIDUserBenefit(int IDUserBenefit)
        {
         
            int IDUserRecipient = -1, IDBorrowing = -1, IDBook = -1;
            DateTime borrowingDate = DateTime.MinValue;
            DateTime? recoveryDate = null;

            bool isFound = clsDataBorrowing.getBorrowingByIDUserBenefit(IDUserBenefit, ref IDUserRecipient, ref IDBorrowing, ref IDBook, ref borrowingDate, ref recoveryDate);
            if (isFound)
            {
                return new clsBorrowing(IDBorrowing, IDUserRecipient, IDUserBenefit, IDBook, borrowingDate, recoveryDate);
            }
            else
            {
                return null;
            }
        }

        static public clsBorrowing getBorrowingByIDBorrowing(int IDBorrowing)
        {
            int IDUserRecipient = -1, IDUserBenefit = -1, IDBook = -1;
            DateTime borrowingDate = DateTime.MinValue;
            DateTime? recoveryDate = null;

            bool isFound = clsDataBorrowing.getBorrowingByBorrowingID(ref IDUserBenefit, ref IDUserRecipient, IDBorrowing, ref IDBook, ref borrowingDate, ref recoveryDate);
            if (isFound)
            {
                return new clsBorrowing(IDBorrowing, IDUserRecipient, IDUserBenefit, IDBook, borrowingDate, recoveryDate);
            }
            else
            {
                return null;
            }
        }

        //static public clsBook getBookByName(string bookName, short part)
        //{

        //    bool isBorrowing = false;
        //    int id = -1;
        //    id = clsDataBook.isExistBookByName(bookName, part);
        //    if (id != -1)
        //    {
        //        return getBookByID(id);
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}

        static public bool deleteBorrowing(int IDBorrowing)
        {
            return clsDataBorrowing.deleteBorrowing(IDBorrowing);
        }

        static public DataTable getAllBorrowings()
        {
            return clsDataBorrowing.getAllBorrowings();
        }

        public static int getNumberofMyBooksForRecipient(int id)
        {
            return clsDataBorrowing.getNumberofMyBooksForRecipient(id);
        }

        public static int getNumberofMyBooksForBenefit(int id)
        {
            return clsDataBorrowing.getNumberofMyBooksForBenefit(id);
        }


        static public DataTable getAllBorrowingsForSpecificRecipient(int id)
        {
            return clsDataBorrowing.getAllBorrowingsForSpecificRecipient(id);
        }
        static public DataTable getAllBorrowingsForSpecificBenefit(int id)
        {
            return clsDataBorrowing.getAllBorrowingsForSpecificBenefit(id);
        }


        public bool save()
        {
            switch (mode)
            {
                case eMode.InsertMode:
                    if (_InsertBorrowing())
                    {
                        mode = eMode.UpdateMode;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case eMode.UpdateMode:
                    return _UpdateBorrowing();

                default: return false;
            }
        }

        //public static bool isExistBookByName(string bookName, short part)
        //{
        //    int id = clsDataBook.isExistBookByName(bookName, part);
        //    return (id != -1);
        //}

        public static DataTable benefitsSearchWithLetters(string letters)
        {
            return clsDataBorrowing.benefitsSearchWithLetters(letters);
        }
        public static DataTable recipientsSearchWithLetters(string letters)
        {
            return clsDataBorrowing.recipientsSearchWithLetters(letters);
        }

        public static DataTable booksSearchWithLetters(string letters)
        {
            return clsDataBorrowing.booksSearchWithLetters(letters);
        }
    }
}
