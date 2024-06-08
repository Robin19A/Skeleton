using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstSupplierUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsSupplierUser AnUser = new clsSupplierUser();
            //test to see that it exists
            Assert.IsNotNull(AnUser);
        }

        [TestMethod]

        public void UserIDPropertyOK() 
        {
            //create an instance of the class we want to create 
            clsSupplierUser AnUser = new clsSupplierUser();
            //create some test data to assign to the property 
            Int32 TestData = 1;
            //assign the data to the property
            AnUser.UserID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.UserID, TestData);

        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            //create an instance of the class we want to create 
            clsSupplierUser AnUser = new clsSupplierUser();
            //create some test data to assign to the property 
            string TestData = "Archie";
            //assign the data to the property 
            AnUser.UserName = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnUser.UserName, TestData);
        }
        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create 
            clsSupplierUser AnUser = new clsSupplierUser();
            //create some test data to assign to the property 
            string TestData = "24680";
            //assign the data to the property 
            AnUser.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Password, TestData);

        }
        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //create an instance of the class we want to create 
            clsSupplierUser AnUser = new clsSupplierUser();
            //create some test data to assign to the property 
            string TestData = "Supplier management";
            //assign the data to the property 
            AnUser.Department = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnUser.Department, TestData);
        }

        [TestMethod]

        public void FindUserMethodOK() 
        {
            //create an instance of the class we want to create 
            clsSupplierUser AnUser = new clsSupplierUser();
            //create a boolean variable to store the results of the validation 
            Boolean Found = false;
            //create some test data to use with the method 
            string UserName = "Archie";
            string Password = "24680";
            //invoke the method 
            Found = AnUser.FindUser(UserName, Password);
            //test to see if the result is true 
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUsernamePWFound()
        {
            //create an instance of the class we want to create 
            clsSupplierUser AnUser = new clsSupplierUser();
            //create a boolean variable to store the results of the validation
            Boolean Found = false;
            //create a boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            string Username = "Archie";
            string Password = "24680";
            //invoke the method
            Found = AnUser.FindUser(Username, Password);
            //check the user id property
            if (AnUser.UserName != Username && AnUser.Password != Password)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

    }
}
