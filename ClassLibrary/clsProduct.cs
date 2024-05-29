using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary
{
    public class clsProduct
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public int SupplierID { get; set; }
        public decimal UnitPrice { get; set; }
        public bool Available { get; set; }
    }
}