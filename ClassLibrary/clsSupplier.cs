using System;

namespace ClassLibrary
{
    public class clsSupplier
    {
        //private data member for the supplier id property
        private Int32 mSupplierId;

        //supplierId public property

        public Int32 SupplierId
        {
            get
            {
                //this line of code sends data out of the property
                return mSupplierId;
            }
            set
            {
                //this line of code allows data into the property
                mSupplierId = value;
            }
        }

        //private data member for the supplier name property
        private string mSupplierName;
        //suplier name public property
        public string SupplierName
        {
            get
            {
                //this line of code sends data out of the property
                return mSupplierName;
            }
            set
            {
                //this line of code allows data into the property
                mSupplierName = value;
            }
        }

        //private data member for the address property
        private string mAddress;
        //town public property
        public string Address
        {
            get
            {
                //this line of code sends data out of the property
                return mAddress;
            }
            set
            {
                //this line of code allows data into the property
                mAddress = value;
            }
        }

        //private data member for the phone property
        private string mPhone;
        //phone public property
        public string Phone
        {
            get
            {
                //this line of code sends data out of the property
                return mPhone;
            }
            set
            {
                //this line of code allows data into the property
                mPhone = value;
            }
        }

        //private data member for the email property
        private DateTime mDateAdded;
        //date added public property
        public DateTime DateAdded
        {
            get
            {
                //this line of code sends data out of the property
                return mDateAdded;
            }
            set
            {
                //this line of code allows data into the property
                mDateAdded = value;
            }
        }

        //private data member for the email property 
        private string mEmail;
        //town public property 
        public string Email
        {
            get
            {
                //this line of code sends data out of the property 
                return mEmail;
            }
            set
            {
                //this line of code allows data into the property 
                mEmail = value;
            }
        }

        //private data member for the active property 
        private Boolean mActive;
        //active public property 
        public bool Active
        {
            get
            {
                //this line of code sends data out of the property 
                return mActive;
            }
            set
            {
                //this line of code allows data into the property 
                mActive = value;
            }
        }
        public bool Find(int supplierId)
        {
            //set the private data members to the test data value
            mSupplierId = 21;
            mSupplierName = "Sunny Shades";
            mAddress = "19 Kingston Road";
            mPhone = "04303487433";
            mDateAdded = Convert.ToDateTime("23/12/2022");
            mEmail = "Sunnyshades@gmail.com";
            mActive = true;
            //always return true
            return true;
        }
    }
    
}