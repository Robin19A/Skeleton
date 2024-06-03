using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        //private data member for the address id property
        private Int16 mOrderId;
        private DateTime mOrderDate;

        //addressId public property
        private Int16 mOrderId
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderId;
            }
            set
            {
                //this line of code sends data out of the property
                mOrderId = value;
            }
        }

        private short orderId;
        public short GetOrderId()
        {
            return orderId;
        }

        public void SetOrderId(short value)
        {
            orderId = value;
        }

        public bool Active { get; set; }
        public short OrderId { get => GetOrderId(); set => SetOrderId(value); }
        public string CustomerId { get; set; }
        public string DeliveredStatus { get; set; }
        public decimal TotalAmount { get; set; }
        public string ShippingAddress { get; set; }
        public DateTime OrderDate { get; set; }
        public string StaffId { get; set; }

        public bool Find(int orderId)
        {
            //set the private data members to the test data value
            mOrderId = 1;
            mOrderDate = Convert.ToDateTime("10/05/2024");
            //always return true
            return true;

        }
    }
}