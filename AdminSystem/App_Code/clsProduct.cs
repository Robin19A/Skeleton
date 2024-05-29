using System;

namespace testing 
{
    public class clsProduct

    {
        private Int32 mProductID;
        public Int32 ProductID
        {

            get
            {
                return mProductID;

            }
            set
            {
                mProductID = value;
            }

        }


    

       
       
        
        private string mName;
        public string Name
        {

            get
            {
                return mName;

            }
            set
            {
                mName = value;
            }

        }
       

        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public int SupplierID { get; set; }
        public decimal UnitPrice { get; set; }
        public bool Available { get; set; }

       


    }
}
