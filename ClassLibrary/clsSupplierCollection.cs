﻿using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;

namespace ClassLibrary
{
    public class clsSupplierCollection
    {
        //constructor for the class
        public clsSupplierCollection()
        {
            //variable for the index 
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //onject for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblSupplier_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsSupplier AnSupplier = new clsSupplier();
                //read in the fields for the current record
                AnSupplier.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnSupplier.SupplierId = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierId"]);
                AnSupplier.SupplierName = Convert.ToString(DB.DataTable.Rows[Index]["SupplierName"]);
                AnSupplier.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AnSupplier.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AnSupplier.Phone = Convert.ToString(DB.DataTable.Rows[Index]["Phone"]);
                AnSupplier.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                //add the record to the private data member
                mSupplierList.Add(AnSupplier);
                //point at the next record 
                Index++;
            }
            
        }
        //private data member for the list
        List<clsSupplier> mSupplierList = new List<clsSupplier>();

        //public property for SupplierList
        public List<clsSupplier> SupplierList
        {
            get
            {
                //return the private data
                return mSupplierList;
            }
            set
            {
                //set the private data
                mSupplierList = value;
            }
        }

        //public property for Count
        public int Count
        {
            get
            {
                //return the private data
                return SupplierList.Count;
            }
            set
            {
                //we will worry about this later
            }
        }

        public clsSupplier ThisSupplier { get; set; }
    }
}

       
    


