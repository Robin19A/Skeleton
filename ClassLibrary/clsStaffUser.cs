﻿using System;
using System.IO;

namespace ClassLibrary
{
    public class clsStaffUser
    {
        //private data member for the user id property
        private Int32 mUserID;
        //private data member for the user name property
        private string mUsername;
        //private data member for the user password property
        private string mPassword;
        ////private data member for the user depertment property
        private string mDepartment;

        public int UserID
        {
            get
            {
                //return the private data
                return mUserID;
            }
            set
            {
                //set the private data
                mUserID = value;
            }
        }
        public string Username 
        {
            get
            {
                //return the private data
                return mUsername;
            }
            set
            {
                //set the private data
                mUsername = value;
            }
        }
        public string Password 
        {
            get
            {
                //return the private data
                return mPassword;
            }
            set
            {
                //set the private data
                mPassword = value;
            }
        }
        public string Department 
        {
            get
            {
                //return the private data
                return mDepartment;
            }
            set
            {
                //set the private data
                mDepartment = value;
            }
        }

        public bool FindUser(string Username, string Password)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameters for the user username and password to search for
            DB.AddParameter("@Username", Username);
            DB.AddParameter("@Password", Password);
            //execute the stored procedure
            DB.Execute("sproc_tblUsers_FindUsernamePW");
            //if one record is found (there should be either one or more)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mUserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
                mUsername = Convert.ToString(DB.DataTable.Rows[0]["Username"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                //return true to confirm everything worked ok
                return true;
            }
            else
            {
                return false;
            }

            
        }
    }
}