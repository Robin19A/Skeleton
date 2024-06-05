using System;
using System.Diagnostics;

namespace ClassLibrary
{
    public class clsProduct
    {
        private Int32 mProductID;
        private String mName;
        private string mDescription;
        private int mSupplierID;
        private bool mAvailable;
        private DateTime mDateAdded;
        private double mUnitPrice;

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
        public String Name
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
        public string Description
        {

            get
            {
                return mDescription;

            }
            set
            {
                mDescription = value;
            }

        }
        public DateTime DateAdded
        {

            get
            {
                return mDateAdded;

            }
            set
            {
                mDateAdded = value;
            }

        }
        public double UnitPrice
        {

            get
            {
                return mUnitPrice;

            }
            set
            {
                mUnitPrice = value;
            }

        }
        public int SupplierID

        {

            get
            {
                return mSupplierID;

            }
            set
            {
                mSupplierID = value;
            }

        }
        public bool Available

        {

            get
            {
                return mAvailable;

            }
            set
            {
                mAvailable = value;
            }

        }




        public bool Find(int productID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("ProductID", productID);
            DB.Execute("sproc_tblProduct_FilterByProductID");
            if(DB.Count == 1)
            {
                mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mSupplierID = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierID"]);
                mUnitPrice = Convert.ToDouble(DB.DataTable.Rows[0]["UnitPrice"]);
                mDescription = Convert.ToString(DB.DataTable.Rows[0]["Description"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["Available"]);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string Name, string Description, string DateAdded, string UnitPrice, string SupplierID, string Available)
        {
            String Error = "";
            DateTime d;
            Double UP;
            Int32 SID;


            if(Name.Length == 0)
            {
                Error += "Name may not be empty.";
            }
            if (Name.Length > 50)
            {
                Error += "Name must be lesser than 50 Characters.";
            }
            if (Description.Length == 0)
            {
                Error += "Description may not be empty.";
            }
            if (Description.Length > 200)
            {
                Error += "Description must be lesser than 200 Characters.";
            }



            try
            {
                d = Convert.ToDateTime(DateAdded);
                if (d < DateTime.Now.Date)
                {
                    Error = Error + "Date cant be in the past";
                }
                if (d > DateTime.Now.Date)
                {
                    Error = Error + "Date cannot be in the future";
                }
            }
            catch
            {
                Error = Error + "Correct DateAdded format.";
            }



            try
            {
                UP= Convert.ToDouble(UnitPrice);
                if (UP <= 0)
                {
                    Error += "Unitprice cant be Negative and Zero.";
                }
                if (UP> 10000.00)
                {
                    Error += "Unitprice Limit is 10000.00";
                }
            }
            catch
            {
                Error += "Unitprice is not valid.";
            }


            try
            {
                SID = Convert.ToInt32(SupplierID);
                if (SID <= 0)
                {
                    Error += "SupplierID cant be Negative.";
                }
            }
            catch
            {
                Error += "SupplierID Must be Int.";
            }

            return Error;
        }
    }
}