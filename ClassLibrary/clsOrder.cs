using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        //private data member for the address id property
        private Int32 mOrderid;
        private short orderId;
        private int mAddressId;

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
        public short CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public string DeliveredStatus { get; set; }
        public decimal TotalAmount { get; set; }
        public string ShippingAddress { get; set; }
        public short StaffId { get; set; }

        public bool Find(int orderId)
        {
            //set the private data members to the test data value
            mAddressId = 1;
            //always return true
            return true;

        }
    }
}