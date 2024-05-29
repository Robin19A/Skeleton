using System;

namespace ClassLibrary
{
    public class clsProduct
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public decimal UnitPrice { get; set; }
        public int SupplierID { get; set; }
        public bool Availability { get; set; }
    }
}