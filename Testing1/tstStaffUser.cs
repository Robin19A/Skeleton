using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStaffUser
    {
        [TestMethod]
        public void InstanceOK()
        { 
            //create an instance of the class we want to create
            clsStaffUser AnUser = new clsStaffUser();
            //test to see that it exists
            Assert.IsNotNull(AnUser);
        }

        [TestMethod]
        public void UserIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffUser AnUser = new clsStaffUser();
            //create some test data to assign to the property
            Int32 TestData = 2;
            //assign the data to the property
            AnUser.UserID = TestData;

            Assert.AreEqual(AnUser.UserID, TestData);
        }
        [TestMethod]
        public void UsernamePropertyOK() 
        {
            //create an instance of the class we want to create 
            clsStaffUser AnUser = new clsStaffUser();
            //create some test data to assign to the property
            string TestData = "Amanullah";
            //assign the data to the property
            AnUser.Username = TestData;

            Assert.AreEqual(AnUser.Username, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create 
            clsStaffUser AnUser = new clsStaffUser();
            //create some test data to assign to the property
            string TestData = "abc12345";
            //assign the data to the property
            AnUser.Password = TestData;

            Assert.AreEqual(AnUser.Password, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //create an instance of the class we want to create 
            clsStaffUser AnUser = new clsStaffUser();
            //create some test data to assign to the property
            string TestData = "Staff management";
            //assign the data to the property
            AnUser.Department = TestData;

            Assert.AreEqual(AnUser.Department, TestData);
        }

        [TestMethod]
        public void FindUserMethodOK()
        {
            //create an instance of the class we want to create 
            clsStaffUser AnUser = new clsStaffUser();
            //create a boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            string Username = "Amanullah";
            string Password = "abc12345";
            //invoke the method
            Found = AnUser.FindUser(Username, Password);

            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUsernamePWFound()
        {
            //create an instance of the class we want to create 
            clsStaffUser AnUser = new clsStaffUser();
            //create a boolean variable to store the results of the validation
            Boolean Found = false;
            //create a boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            string Username = "Amanullah";
            string Password = "abc12345";
            //invoke the method
            Found = AnUser.FindUser(Username, Password);
            //check the user id property
            if (AnUser.Username != Username && AnUser.Password != Password)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }



    }
}
