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
        private Boolean mDeliveryStatus;
        //post code public property
        public Boolean DeliveryStatus
        {
            get
            {
                //this line of code sends data out of the property
                return mDeliveryStatus;
            }
            set
            {
                //this line of code allows data into the property
                mDeliveryStatus = value;
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
                mDeliveryStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["DeliveryStatus"]);
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

        public string Valid(string orderDate, string totalAmount, string shippingAddress)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to storethe data values
            DateTime DateTemp;
            //create a temporary variable to storethe data values

            

            //if the HouseNo is blank
            if (shippingAddress.Length == 0)
            {
                //redord the error
                Error = Error + "The ShippingAddress may not be blank : ";

            }
            //if the HouseNo is no greater than 50
            if (shippingAddress.Length > 50)
            {
                //redord the error
                Error = Error + "The ShippingAddress must be less than 51 charachters : ";

            }

            //create an instance of DateTime to compare with DateTemp
            //in the if statement
            DateTime DateComp = DateTime.Now.Date;
            DateTime FutureDate = DateTime.Today.AddYears(100);
            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(orderDate);

                if (DateTemp < DateComp) //compare orderDate with Date
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > FutureDate)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //return the error 
                Error = Error + "The date was not a valid date : ";
            }

            //temporary if statment
            if (Convert.ToDecimal(totalAmount) < (Decimal)(0))
            {
                //record the error
                Error = Error + "THe total price has to cannot be more than 1000: ";
            }
            //temporary if statment
            if (Convert.ToDecimal( totalAmount) > (Decimal) (1000))
            {
                //record the error
                Error = Error + "THe total price has to cannot be more than 1000: ";
            }
            return Error;
        }
    }
} 

