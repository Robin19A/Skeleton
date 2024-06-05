using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsProductCollection
    {
        List<clsProduct> mProductList = new List<clsProduct>();
        clsProduct mThisProduct = new clsProduct();



        public List<clsProduct> ProductList
        {
            get
            {
                return mProductList;
            }
            set { mProductList = value; }
        }

        public int Count
        {
            get
            {
                return mProductList.Count;
            }
            set { }
        }
        public clsProduct ThisProduct
        {
            get
            {
                return mThisProduct;
            }
            set
            {
                mThisProduct = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Name", mThisProduct.Name);
            DB.AddParameter("@Description", mThisProduct.Description);
            DB.AddParameter("@DateAdded", mThisProduct.DateAdded);
            DB.AddParameter("@UnitPrice", mThisProduct.UnitPrice);
            DB.AddParameter("@SupplierID", mThisProduct.SupplierID);
            DB.AddParameter("@Available", mThisProduct.Available);
            return DB.Execute("sproc_tblProduct_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductID", mThisProduct.ProductID);
            DB.Execute("sproc_tblProduct_Delete");
        }

        public void ReportByName(string Name)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Name", Name);
            DB.Execute("sproc_tblProduct_FilterByName");

            PopulateArray(DB);
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductID", mThisProduct.ProductID);
            DB.AddParameter("@Name", mThisProduct.Name);
            DB.AddParameter("@Description", mThisProduct.Description);
            DB.AddParameter("@DateAdded", mThisProduct.DateAdded);
            DB.AddParameter("@UnitPrice", mThisProduct.UnitPrice);
            DB.AddParameter("@SupplierID", mThisProduct.SupplierID);
            DB.AddParameter("@Available", mThisProduct.Available);
            DB.Execute("sproc_tblProduct_update");
        }


        public clsProductCollection()
        {

            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblProduct_SelectALL");

            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mProductList = new List<clsProduct>();
            while (Index < RecordCount)
            {
                clsProduct AProduct = new clsProduct();
                AProduct.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                AProduct.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                AProduct.Description = Convert.ToString(DB.DataTable.Rows[Index]["Description"]);
                AProduct.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                AProduct.UnitPrice = Convert.ToDouble(DB.DataTable.Rows[Index]["UnitPrice"]);
                AProduct.SupplierID = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierID"]);
                AProduct.Available = Convert.ToBoolean(DB.DataTable.Rows[Index]["Available"]);
                mProductList.Add(AProduct);
                Index++;
            }
        }
    }
}