using System;

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
        private String mName;
        public String Name
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




        public bool Find(int productID)
        {
            mProductID = 21;
            mName = "Black glasses";
            mDescription = "Sunglasses";
            mDateAdded = Convert.ToDateTime("12/12/12");
            mUnitPrice = 12;
            mSupplierID = 1;
            mAvailable = true;
            return true;
        }
    }
}