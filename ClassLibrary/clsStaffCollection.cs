using System;
using System.Collections.Generic;

namespace ClassLibrary
{

    public class clsStaffCollection
    {
        public clsStaffCollection() 
        { 
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //onject for the data connect
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sporc_tblStaff_SelectAll");
            RecordCount = DB.Count;
            while (Index< RecordCount)
            {
                clsStaff AnStaff = new clsStaff();
                //read in the fields for the current record
                AnStaff.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnStaff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                AnStaff.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfBirth"]);
                AnStaff.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                AnStaff.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AnStaff.Gender = Convert.ToString(DB.DataTable.Rows[Index]["Gender"]);
                AnStaff.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                mStaffList.Add( AnStaff );
                Index++;
            }
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.Active = true;
            TestItem.StaffId = 1;
            TestItem.DateOfBirth = DateTime.Now;
            TestItem.Name = "Robin";
            TestItem.Email = "robinyo@gmail.com";
            TestItem.Gender = "Male";
            TestItem.Address = "LE20PE";
            //add the test item to the test list
            mStaffList.Add(TestItem);
            //re initialise the object for some new data
            TestItem = new clsStaff();
            //set its properties
            TestItem.Active = true;
            TestItem.StaffId = 2;
            TestItem.DateOfBirth = DateTime.Now;
            TestItem.Name = "Sakib";
            TestItem.Email = "sakib@gmailcom.bd";
            TestItem.Gender = "Male";
            TestItem.Address = "LE21OP";
            mStaffList.Add(TestItem);
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
    }
}