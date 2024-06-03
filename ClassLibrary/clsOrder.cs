using System;
namespace ClassLibrary
{
    public class clsOrder
    {
        //private data member for the Order id property
        private Int16 mOrderId;
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
        private Int16 mCustomerId;
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
        private Int16 mStaffId;
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
            //set the private data members to the test data value
            mOrderId = 1;
            mCustomerId = 1000;
            mOrderDate = Convert.ToDateTime("10/05/2024");
            mDeliveredStatus = "Delivered";
            mTotalAmount = 15;
            mShippingAddress = "Gateway House, Leicester, LE1 9BH";
            mStaffId = 1001;
            mActive = true;
            //always return true
            return true;
        }
    }
}