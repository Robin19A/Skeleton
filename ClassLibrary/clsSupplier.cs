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
        public bool Find(int SupplierId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the supplier id to search for 
            DB.AddParameter("@SupplierId", SupplierId);
            //execute the stored procedure
            DB.Execute("sproc_tblSupplier_FilterBySupplierId");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members 
                mSupplierId = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierId"]);
                mSupplierName = Convert.ToString(DB.DataTable.Rows[0]["SupplierName"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mPhone = Convert.ToString(DB.DataTable.Rows[0]["Phone"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                //return that everything worked ok
                return true;

            }
            //if no record was found
            else
            {


                //return false indicating there is a problem 
                return false;
            }
        }
    }
}
    