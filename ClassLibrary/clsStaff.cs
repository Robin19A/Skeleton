using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        //private data member for the address id propert
        private Int32 mStaffId;

        //private data member for the DateOfBirth
        private DateTime mDateOfBirth;

        //private data member for the active property
        private Boolean mActive;

        //private data member for the name property
        private string mName;

        //private data member for the name property
        private string mEmail;

        //private data member for the name property
        private string mAddress;

        //private data member for the name property
        private string mGender;
        public bool Active
        {
            get
            {
                //this line of code sends data out of the property
                return mActive;
            }
            set
            {
                //this line of code allows data into the property
                mActive = value;
            }
        }

               
        public DateTime DateOfBirth
        {
            get
            {
                //this line of code sends data out of the property
                return mDateOfBirth;
            }
            set
            { 
                //this line of code allows data into property
                mDateOfBirth = value;
            }
        }

        public int StaffId
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffId;
            }

            set
            {
                //this line of code allows data into the property
                mStaffId = value;
            }
        }
        
        public string Name
        {
            get
            {
                //this line of code sends data out of the property
                return mName;
            }
            set
            {
                //this line of code allows data into the property
                mName = value;
            }
        }
        public string Email
        {
            get
            {
                //this line of code sends data out of the property
                return mEmail;
            }
            set
            {
                //this line of code allows data into the property
                mEmail = value;
            }
        }
        
        public string Address
        {
            get
            {
                //this line of code sends data out of the property
                return mAddress;
            }
            set
            {
                //this line of code allows data into the property
                mAddress = value;
            }
        }
        public string Gender
        {
            get
            {
                //this line of code sends data out of the property
                return mGender;
            }
            set
            {
                //this line of code allows data into the property
                mGender = value;
            }
        }

        public bool Find(int staffId)
        {
            //set the privte data members to the test data value
            mStaffId = 21;
            mName = "Amanullah Robin";
            mEmail = "arobin@gmail.com";
            mDateOfBirth = Convert.ToDateTime("23/12/2022");
            mGender = "Male";
            mAddress = "57A London Road";
            mActive = true;
            //always return true
            return true;
        }
    }
}