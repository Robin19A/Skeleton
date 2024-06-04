using System;
namespace ClassLibrary
{
    public class clsOrder
    {
        //private data member for the Order id property
        private Int32 mOrderId;
        //OrderId public property
        public int OrderId
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderId;
            }
            set
            {
                //this line of code allows data into the property
                mOrderId = value;
            }
        }

        //private data member for the house no property
        private Int32 mCustomerId;
        //house no public property
        public int CustomerId
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerId;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerId = value;
            }
        }

        //private data member for the street property
        private DateTime mOrderDate;
        //street public property
        public DateTime OrderDate
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderDate;
            }
            set
            {
                //this line of code allows data into the property
                mOrderDate = value;
            }
        }

        //private data member for the post code property
        private string mDeliveredStatus;
        //post code public property
        public string DeliveredStatus
        {
            get
            {
                //this line of code sends data out of the property
                return mDeliveredStatus;
            }
            set
            {
                //this line of code allows data into the property
                mDeliveredStatus = value;
            }
        }

        //private data member for the date added property
        private Decimal mTotalAmount;
        //date added public property
        public Decimal TotalAmount
        {
            get
            {
                //this line of code sends data out of the property
                return mTotalAmount;
            }
            set
            {
                //this line of code allows data into the property
                mTotalAmount = value;
            }
        }

        //private data member for the house no property
        private string mShippingAddress;
        //house no public property
        public string ShippingAddress
        {
            get
            {
                //this line of code sends data out of the property
                return mShippingAddress;
            }
            set
            {
                //this line of code allows data into the property
                mShippingAddress = value;
            }
        }

        //private data member for the house no property
        private Int32 mStaffId;
        //house no public property
        public int StaffId
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffId;
            }
            set
            {
                //this line of code allows data into the property
                mStaffId = value;
            }
        }

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

        /****** FIND METHOD ******/
        public bool Find(int OrderId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address id to search for
            DB.AddParameter("@OrderId", OrderId);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderId");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mDeliveredStatus = Convert.ToString(DB.DataTable.Rows[0]["DeliveredStatus"]);
                mTotalAmount = Convert.ToDecimal(DB.DataTable.Rows[0]["TotalAmount"]);
                mShippingAddress = Convert.ToString(DB.DataTable.Rows[0]["ShippingAddress"]);
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                //return that everything worked OK
                return true;
            }
            //if no record was Found
            else
            {

                //return false indicating there is a problem
                return false;
            }
        }
    }
}
