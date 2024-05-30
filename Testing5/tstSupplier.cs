using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Dynamic;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

namespace Testing5
{
    [TestClass]
    public class tstSupplier
    {
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
    }
}

 


  

