using System;
using System.Collections.Generic;

namespace ClassLibrary
{

    public class clsStaffCollection
    {
        public clsStaffCollection() 
        { 

            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sporc_tblStaff_SelectAll");
            
            PopulateArray(DB);

            
            
        }
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //
        clsStaff mThisStaff = new clsStaff(); 

        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }
        public int Count
        {
            get
            {
                return mStaffList.Count;
            }
            set
            {
                //we shall worry about this letter
            }
        }
        public clsStaff ThisStaff
        {
            get
            {
             return mThisStaff;
            }
            set
            {
                mThisStaff = value;
            }
        }

        public int Add()
        {
           clsDataConnection DB = new clsDataConnection();

           DB.AddParameter("@Name", mThisStaff.Name);
           DB.AddParameter("@Email", mThisStaff.Email);
           DB.AddParameter("@DateOfBirth", mThisStaff.DateOfBirth);
           DB.AddParameter("@Gender", mThisStaff.Gender);
           DB.AddParameter("@Address", mThisStaff.Address);
           DB.AddParameter("Active", mThisStaff.Active);

            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffId", mThisStaff.StaffId);
            DB.AddParameter("@Name", mThisStaff.Name);
            DB.AddParameter("@Email", mThisStaff.Email);
            DB.AddParameter("@DateOfBirth", mThisStaff.DateOfBirth);
            DB.AddParameter("@Gender", mThisStaff.Gender);
            DB.AddParameter("@Address", mThisStaff.Address);
            DB.AddParameter("Active", mThisStaff.Active);

             DB.Execute("sproc_tblStaff_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffId", mThisStaff.StaffId);

            DB.Execute("sproc_tblStaff_Delete");
        }

        public void ReportByAddress(string Address)
        {
            //filters the records based on a full or partial address
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the Address parameter to the database
            DB.AddParameter("@Address", Address);
            //execute the stored procedure
            DB.Execute("sproc_tblAddress_FilterByAddress");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mStaffList = new List<clsStaff>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address object
                clsStaff AnStaff = new clsStaff();
                //read in the fields for the current record
                AnStaff.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnStaff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                AnStaff.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfBirth"]);
                AnStaff.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                AnStaff.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AnStaff.Gender = Convert.ToString(DB.DataTable.Rows[Index]["Gender"]);
                AnStaff.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                //add the record to the private data member
                mStaffList.Add(AnStaff);
                //point at the next record
                Index++;

            }


        }
    }
}