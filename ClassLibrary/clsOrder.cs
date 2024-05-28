using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public bool Active { get; set; }
        public short OrderId { get; set; }
        public short CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public string DeliveredStatus { get; set; }
        public decimal TotalAmount { get; set; }
        public string ShippingAddress { get; set; }
        public short StaffId { get; set; }
    }
}