using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public int CustomerId { get; set; }
        public int CustomerUsername { get; set; }
        public string CustomerPassword { get; set; }
        public string CustomerEmail { get; set; }
        public DateTime CustomerDateofbirth { get; set; }
        public string CustomerAddress { get; set; }
    }
}