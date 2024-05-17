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
    }
 }

