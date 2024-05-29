using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary
{
    public class clsProduct
    {

        private Int32 mProductID;
        public Int32 ProductID
        {

            get
            {
                return mProductID;

            }
            set
            {
                mProductID = value;
            }

        }

        private string mName;
        public string Name
        {

            get
            {
                return mName;

            }
            set
            {
                mName = value;
            }

        }
        private string mDescription;
        public string Description
        {

            get
            {
                return mDescription;

            }
            set
            {
                mDescription = value;
            }

        }
        private DateTime mDateAdded;
        public DateTime DateAdded
        {

            get
            {
                return mDateAdded;

            }
            set
            {
                mDateAdded = value;
            }

        }
        private decimal mUnitPrice;
        public decimal UnitPrice
        {

            get
            {
                return mUnitPrice;

            }
            set
            {
                mUnitPrice = value;
            }

        }
        private int mSupplierID;
        public int SupplierID

        {

            get
            {
                return mSupplierID;

            }
            set
            {
                mSupplierID = value;
            }

        }
        private bool mAvailable;
        public bool Available

        {

            get
            {
                return mAvailable;

            }
            set
            {
                mAvailable = value;
            }

        }





        internal bool Availability;





        public bool Find(int ProductID)
        {
            mProductID = 21;
            return true;
        }
        public bool Find(string Name)
        {
            mName = "Syed waqar ali";
            return true;
        }

        public string Valid(string Name, string Description, string UnitPrice, string DateAdded, string SupplierID, string Available)
        {
            String Error = "";
            DateTime DateTemp;
            if (Name.Length == 0)
            {
                Error = Error + "The name may not be blank: ";
            }
            if (Name.Length > 6)
            {
                Error = Error + "The name not must be less than 6 char:";
            }
            DateTemp = Convert.ToDateTime(DateAdded);
            if (DateTemp < DateTime.Now.Date)
            {
                Error = Error + "The date can not be in the past : ";
            }
            if (DateTemp<DateTime.Now.Date)
            {
                Error = Error + "The date cannot be in the future :";
            }

            return "Error";
        }
    }
}

    
  

    


