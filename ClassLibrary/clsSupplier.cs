using System;

namespace ClassLibrary
{
    public class clsSupplier
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}