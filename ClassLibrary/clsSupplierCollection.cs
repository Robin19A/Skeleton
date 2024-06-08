using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Messaging;

namespace ClassLibrary
{
    public class clsSupplierCollection
    {
        // Constructor for the class
        public clsSupplierCollection()
        {
            // Object for data connection
            clsDataConnection DB = new clsDataConnection();
            // Execute the stored procedure
            DB.Execute("sproc_tblSupplier_SelectAll");
            PopulateArray(DB);
        }

        // Private data member for the list
        private List<clsSupplier> mSupplierList = new List<clsSupplier>();
        // Private member data for ThisSupplier
        private clsSupplier mThisSupplier = new clsSupplier();

        // Public property for SupplierList
        public List<clsSupplier> SupplierList
        {
            get
            {
                // Return the private data
                return mSupplierList;
            }
            set
            {
                // Set the private data
                mSupplierList = value;
            }
        }

        // Public property for Count
        public int Count
        {
            get
            {
                // Return the private data
                return mSupplierList.Count;
            }
            set
            {
                // We will worry about this later
            }
        }

        // Public property for ThisSupplier
        public clsSupplier ThisSupplier
        {
            get
            {
                // Return the private data
                return mThisSupplier;
            }
            set
            {
                // Set the private data
                mThisSupplier = value;
            }
        }

        public int Add()
        {
            // Adds a record to the database based on the values of mThisSupplier
            // Connect to the database
            clsDataConnection DB = new clsDataConnection();
            // Set the parameters for the stored procedure
            DB.AddParameter("@SupplierName", mThisSupplier.SupplierName);
            DB.AddParameter("@Address", mThisSupplier.Address);
            DB.AddParameter("@Phone", mThisSupplier.Phone);
            DB.AddParameter("@Email", mThisSupplier.Email);
            DB.AddParameter("@DateAdded", mThisSupplier.DateAdded);
            DB.AddParameter("@Active", mThisSupplier.Active);

            // Execute the query returning the primary key value
            return DB.Execute("sproc_tblSupplier_Insert");
        }

        public void Delete()
        {
            // Deletes the record pointed to by ThisSupplier
            // Connect to the database
            clsDataConnection DB = new clsDataConnection();
            // Set the parameters for the stored procedure
            DB.AddParameter("@SupplierId", mThisSupplier.SupplierId);
            // Execute the stored procedure
            DB.Execute("sproc_tblSupplier_Delete");
        }

        public void ReportByPhone(string Phone)
        {
           // Filters the records based on a full or partial phone number
        //    // Connect to the database
            clsDataConnection DB = new clsDataConnection();
        //    // Send the Phone parameter to the database
            DB.AddParameter("@Phone", Phone);
        //    // Execute the stored procedure
            DB.Execute("sproc_tblSupplier_FilterByPhone");
            PopulateArray(DB);
         }

        private void PopulateArray(clsDataConnection DB)
        {
            // Variable for the index
            int Index = 0;
            // Variable to store the record count
            int RecordCount;
            // Get the count of records
            RecordCount = DB.Count;
            // Clear the private array list
            mSupplierList = new List<clsSupplier>();
            // While there are records to process
            while (Index < RecordCount)
            {
                // Create a blank supplier
                clsSupplier AnSupplier = new clsSupplier();
                // Read in the fields for the current record
                AnSupplier.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnSupplier.SupplierId = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierId"]);
                AnSupplier.SupplierName = Convert.ToString(DB.DataTable.Rows[Index]["SupplierName"]);
                AnSupplier.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AnSupplier.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AnSupplier.Phone = Convert.ToString(DB.DataTable.Rows[Index]["Phone"]);
                AnSupplier.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                // Add the record to the private data member
                mSupplierList.Add(AnSupplier);
                // Point at the next record
                Index++;
            }
        }
    }
}








