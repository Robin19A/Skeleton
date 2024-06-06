using System;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;


namespace ClassLibrary
{
    public class clsOrderCollection
    {
        //private data member for the list
        List<clsOrder> mOrderList = new List<clsOrder>();

        //constructor for the class
        public clsOrderCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //onject for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are recrods to process
            while (Index < RecordCount)
            {
                //creates a blank Order
                clsOrder AnOrder = new clsOrder();
                //read in the fields for the current record
                AnOrder.OrderId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);
                AnOrder.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                AnOrder.DeliveryStatus = Convert.ToBoolean(DB.DataTable.Rows[Index]["DeliveryStatus"]);
                AnOrder.TotalAmount = Convert.ToDecimal(DB.DataTable.Rows[Index]["TotalAmount"]);
                AnOrder.ShippingAddress = Convert.ToString(DB.DataTable.Rows[Index]["ShippingAddress"]);
                AnOrder.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                //add the record to the private data member
                mOrderList.Add(AnOrder);
                //point at the next record
                Index++;
            }
        }

        //public property for the order list
        public List<clsOrder> OrderList
        {
            get
            {
                //set the private data
                return mOrderList;
            }
            set
            {
                //set the private data
                mOrderList = value;
            }
        }

        public int Count
        {
            get
            {
                //return the count of the list
                return OrderList.Count;

            }
            //return the count of the list return OrderList.Count;
            set
            {
                //we shall worry about this later
            }
        }

        public clsOrder ThisOrder { get; set; }
    }
}