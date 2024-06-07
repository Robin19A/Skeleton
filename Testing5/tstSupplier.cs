using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Dynamic;
using System.IO;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using static System.Net.WebRequestMethods;

namespace Testing5
{
    [TestClass]
    public class tstSupplier
    {
        //good test data
        //create some test data to pass the method
        string SupplierName = "Zach";
        string Address = "25 Kingston Road";
        string Phone = "777-636-8888";
        string Email = "ZachShades@outlook.com";
        string DateAdded = DateTime.Now.ToShortDateString();

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsSupplier AnSupplier = new clsSupplier();
            //test to see that it exists  
            Assert.IsNotNull(AnSupplier);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {

            //create an instance of the class we want to create 
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property 
            Boolean TestData = true;
            //assign the data to the property 
            AnSupplier.Active = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnSupplier.Active, TestData);
        }

        [TestMethod]

        public void DateAddedPropertyOK()
        {

            //create an instance of the class we want to create 
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property 
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property 
            AnSupplier.DateAdded = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnSupplier.DateAdded, TestData);
        }

        [TestMethod]
        public void SupplierIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnSupplier.SupplierId = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AnSupplier.SupplierId, TestData);

        }

        [TestMethod]

        public void SupplierNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property
            string TestData = "Shiny Shades";
            //assign the data to the property
            AnSupplier.SupplierName = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AnSupplier.SupplierName, TestData);

        }

        [TestMethod]

        public void AddressPropertyOK()
        {
            //create an instance of hte class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property
            string TestData = "19 Miami Street";
            //assign the data to the property
            AnSupplier.Address = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AnSupplier.Address, TestData);

        }

        [TestMethod]

        public void PhonePropertyOK()
        {
            //create an instance of hte class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property
            string TestData = " (555) 555-1234";
            //assign the data to the property
            AnSupplier.Phone = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AnSupplier.Phone, TestData);

        }

        [TestMethod]

        public void EmailPropertyOK()
        {
            //create an instance of hte class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property
            string TestData = "ShinyShades@gmail.com";
            //assign the data to the property
            AnSupplier.Email = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AnSupplier.Email, TestData);

        }

        [TestMethod]

        public void FindMethodOK()
        {
            //create an instance of the class we want to create 
            clsSupplier AnSupplier = new clsSupplier();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method 
            Int32 SupplierId = 4;
            //invoke the method
            Found = AnSupplier.Find(SupplierId);
            //test to see if the result is true 
            Assert.IsTrue(Found);

        }

        [TestMethod]

        public void TestSupplierIdFound()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is O
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierId = 4;
            //invoke the method
            Found = AnSupplier.Find(SupplierId);
            //check the supplier id
            if (AnSupplier.SupplierId != 4)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestSupplierNameFound()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierId = 4;
            //invoke the method
            Found = AnSupplier.Find(SupplierId);
            //check the street property
            if (AnSupplier.SupplierName != "Shady")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddressFound()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierId = 4;
            //invoke the method
            Found = AnSupplier.Find(SupplierId);
            //check the town property
            if (AnSupplier.Address != "Shady Lane")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhoneFound()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierId = 4;
            //invoke the method
            Found = AnSupplier.Find(SupplierId);
            //check the phone property
            if (AnSupplier.Phone != "555-343-0000")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailFound()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierId = 4;
            //invoke the method
            Found = AnSupplier.Find(SupplierId);
            //check the street property
            if (AnSupplier.Email != "Shady@outlook.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierId = 4;
            //invoke the method
            Found = AnSupplier.Find(SupplierId);
            //check the date added property
            if (AnSupplier.DateAdded != Convert.ToDateTime("14/03/2022"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierId = 4;
            //invoke the method
            Found = AnSupplier.Find(SupplierId);
            //check the active property
            if (AnSupplier.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message 
            String Error = "";
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, Address, Phone, Email, DateAdded);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void SupplierNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string c=variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string SupplierName = ""; //this should trigger an error 
            //invovke the method 
            Error = AnSupplier.Valid(SupplierName, Address, Phone, Email, DateAdded);
            //test to see if the result is  correct 
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void SupplierNameMin()
        {
            //create an instance of the class we want to create 
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string SupplierName = "a"; //this should be ok 
            //invoke the method 
            Error = AnSupplier.Valid(SupplierName, Address, Phone, Email, DateAdded);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string SupplierName = "aa"; //this should be ok 
            //invoke the method 
            Error = AnSupplier.Valid(SupplierName, Address, Phone, Email, DateAdded);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string SupplierName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok 
            //invoke the method 
            Error = AnSupplier.Valid(SupplierName, Address, Phone, Email, DateAdded);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void SupplierNameMax()
        {
            //create an instance of the class we want to create 
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string SupplierName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok 
            //invoke the method 
            Error = AnSupplier.Valid(SupplierName, Address, Phone, Email, DateAdded);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMid()
        {
            //create an instance of the class we want to create 
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string SupplierName = "aaaaaaaaaaaaaaa"; //this should be ok 
            //invoke the method 
            Error = AnSupplier.Valid(SupplierName, Address, Phone, Email, DateAdded);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string SupplierName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should fail 
            //invoke the method 
            Error = AnSupplier.Valid(SupplierName, Address, Phone, Email, DateAdded);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string SupplierName = "";
            SupplierName = SupplierName.PadRight(500, 'a');//this should fail
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, Address, Phone, Email, DateAdded);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void DateAddedExtremeMin()
        {

            //create an instance of the class we want to create 
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable 
            string DateAdded = TestDate.ToString();
            //invoke the method 
            Error = AnSupplier.Valid(SupplierName, Address, Phone, Email, DateAdded);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create 
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date totodays date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day 
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable 
            string DateAdded = TestDate.ToString();
            //invoke the method 
            Error = AnSupplier.Valid(SupplierName, Address, Phone, Email, DateAdded);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create 
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date totodays date 
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable 
            string DateAdded = TestDate.ToString();
            //invoke the method 
            Error = AnSupplier.Valid(SupplierName, Address, Phone, Email, DateAdded);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date totodays date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day 
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable 
            string DateAdded = TestDate.ToString();
            //invoke the method 
            Error = AnSupplier.Valid(SupplierName, Address, Phone, Email, DateAdded);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create 
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date totodays date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years 
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable 
            string DateAdded = TestDate.ToString();
            //invoke the method 
            Error = AnSupplier.Valid(SupplierName, Address, Phone, Email, DateAdded);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]

        public void DateAddedInvalidData()
        {

            //create an instance of class we want to create 
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message 
            String Error = "";
            //set the DateAdded to a non date value
            string DateAdded = "this is not a date!";
            //invoke the method 
            Error = AnSupplier.Valid(SupplierName, Address, Phone, Email, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinLessOne()
        {
            //create an instance of the class we want to create 
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message 
            String Error = "";
            //this should fail 
            string Address = "";
            //invoke the method 
            Error = AnSupplier.Valid(SupplierName, Address, Phone, Email, DateAdded);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        } 


        [TestMethod]
        public void AddressMin()
        {
            //create an instance of the class we want to create 
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message 
            String Error = "";
            //this should pass 
            string Address = "a";
            //invoke the method 
            Error = AnSupplier.Valid(SupplierName, Address, Phone, Email, DateAdded);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message 
            String Error = "";
            //this should pass 
            string Address = "aa";
            //invoke the method 
            Error = AnSupplier.Valid(SupplierName, Address, Phone, Email, DateAdded);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message 
            String Error = "";
            //this should pass 
            string Address = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method 
            Error = AnSupplier.Valid(SupplierName, Address, Phone, Email, DateAdded);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        
        [TestMethod]
        public void AddressMax()
        {
            //create an instance of the class we want to create 
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message 
            String Error = "";
            //this should pass 
            string Address = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method 
            Error = AnSupplier.Valid(SupplierName, Address, Phone, Email, DateAdded);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        
        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message 
            String Error = "";
            //this should fail 
            string Address = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method 
            Error = AnSupplier.Valid(SupplierName, Address, Phone, Email, DateAdded);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        
        [TestMethod]
        public void AddressMid()
        {
            //create an instance of the class we want to create 
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message 
            String Error = "";
            //this should pass 
            string Address = "aaaaaaaaaaaaaaa";
            //invoke the method 
            Error = AnSupplier.Valid(SupplierName, Address, Phone, Email, DateAdded);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void AddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string Address = "";
            Address = Address.PadRight(500, 'a');//this should fail
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, Address, Phone, Email, DateAdded);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneMinLessOne()
        {
            //create an instance of the class we want to create 
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message 
            String Error = "";
            //this should fail 
            string Phone = "";
            //invoke the method 
            Error = AnSupplier.Valid(SupplierName, Address, Phone, Email, DateAdded);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneMin()
        {
            //create an instance of the class we want to create 
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message 
            String Error = "";
            //this should pass 
            string Phone = "a";
            //invoke the method 
            Error = AnSupplier.Valid(SupplierName, Address, Phone, Email, DateAdded);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PhoneMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message 
            String Error = "";
            //this should pass 
            string Phone = "aa";
            //invoke the method 
            Error = AnSupplier.Valid(SupplierName, Address, Phone, Email, DateAdded);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message 
            String Error = "";
            //this should pass 
            string Phone = "";
            Phone = Phone.PadRight(19, 'a');
            //invoke the method 
            Error = AnSupplier.Valid(SupplierName, Address, Phone, Email, DateAdded);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneMax()
        {
            //create an instance of the class we want to create 
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message 
            String Error = "";
            //this should pass 
            string Phone = "";
            Phone = Phone.PadRight(20, 'a');
            //invoke the method 
            Error = AnSupplier.Valid(SupplierName, Address, Phone, Email, DateAdded);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PhoneMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message 
            String Error = "";
            //this should fail 
            string Phone = "";
            //invoke the method 
            Error = AnSupplier.Valid(SupplierName, Address, Phone, Email, DateAdded);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void PhoneMid()
        {
            //create an instance of the class we want to create 
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message 
            String Error = "";
            //this should pass 
            string Phone = "";
            Phone = Phone.PadRight(10, 'a');
            //invoke the method 
            Error = AnSupplier.Valid(SupplierName, Address, Phone, Email, DateAdded);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneExtremeMax()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string Phone = "";
            Phone = Phone.PadRight(500, 'a');//this should fail
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, Address, Phone, Email, DateAdded);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinLessOne()
        {

            //create an instance of the class we want to create 
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message 
            String Error = "";
            //this should fail 
            string Email = "";
            //invoke the method 
            Error = AnSupplier.Valid(SupplierName, Address, Phone, Email, DateAdded);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void EmailMin()
        {

            //create an instance of the class we want to create 
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message 
            String Error = "";
            //this should pass 
            string Email = "a";
            //invoke the method 
            Error = AnSupplier.Valid(SupplierName, Address, Phone, Email, DateAdded);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void EmailMinPlusOne()
        {

            //create an instance of the class we want to create 
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message 
            String Error = "";
            //this should pass 
            string Email = "aa";
            //invoke the method 
            Error = AnSupplier.Valid(SupplierName, Address, Phone, Email, DateAdded);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void EmailMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message 
            String Error = "";
            //this should pass 
            string Email = "";
            Email = Email.PadRight(29, 'a');
            //invoke the method 
            Error = AnSupplier.Valid(SupplierName, Address, Phone, Email, DateAdded);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void EmailMax()
        {

            //create an instance of the class we want to create 
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message 
            String Error = "";
            //this should pass 
            string Email = "";
            Email = Email.PadRight(30, 'a');
            //invoke the method 
            Error = AnSupplier.Valid(SupplierName, Address, Phone, Email, DateAdded);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void EmailMaxPlusOne()
        {

            //create an instance of the class we want to create 
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message 
            String Error = "";
            //this shold fail 
            string Email = "";
            Email = Email.PadRight(31, 'a');
            //invoke the method 
            Error = AnSupplier.Valid(SupplierName, Address, Phone, Email, DateAdded);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void EmailMid()
        {

            //create an instance of the class we want to create 
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message 
            String Error = "";
            //this should pass 
            string Email = "";
            Email = Email.PadRight(15, 'a');
            //invoke the method 
            Error = AnSupplier.Valid(SupplierName, Address, Phone, Email, DateAdded);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void EmailExtremeMax()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string Email = "";
           Email = Email.PadRight(500, 'a');//this should fail
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, Address, Phone, Email, DateAdded);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
    }
}

 


  

