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

        public string Valid(string name, string email, string gender, string address, string dateOfBirth)
        {

            //create a string variable to store the error
            String Error = "";

            //create a temporary variable to store the date values
            DateTime DateTemp;
            try
            {
                //copy the dateOfBirth value to the DateTemp Variable
                DateTemp = Convert.ToDateTime(dateOfBirth);
                //check to see if the data is less than today's date
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the data is greater than today,s date
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch 
            {
                Error = Error + "The date was not valid date : ";
            }

            //if the Name is Blank 
            if (name.Length == 0)
            {
                //record the error
                Error = Error + "The name may not be blank : ";
            }
            //if the Name is greater than 50 characters
            if (name.Length > 50)
            {
                //record the error
                Error = Error + "The name must be less than 50 characters : ";

            }



            //is the email blank
            if (email.Length == 0)
            {
                //record the error
                Error = Error + "The email may not be blank : ";
            }
            //if the email is too long
            if (email.Length > 50)
            {
                //record the error
                Error = Error + "The email must be less than 50 characters : ";
            }

            //is the gender Blank
            if (gender.Length == 0)
            {
                //record the error
                Error = Error + "The gender may not be blank : ";
            }
            //if the gender is too long
            if (gender.Length > 50)
            {
                //record the error
                Error = Error + "The email must be less than 50 characters : ";
            }



            //is the address Blank
            if (address.Length == 0)
            {
                //record the error
                Error = Error + "The address may not be blank : ";
            }
            //if the address is too long
            if (address.Length > 50)
            {
                //record the error
                Error = Error + "The address must be less than 50 characters : ";
            }


            //return any error messages
            return Error;
        }
    }
}