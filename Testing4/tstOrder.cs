﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void OrderIdOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int16 TestData = 1;
            //assign the data to the property
            AnOrder.OrderId = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AnOrder.OrderId, TestData);
        }

        [TestMethod]
        public void CustomerIdOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int16 TestData = 1000;
            //assign the data to the property
            AnOrder.CustomerId = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AnOrder.CustomerId, TestData);
        }

        [TestMethod]
        public void OrderDateOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.OrderDate = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AnOrder.OrderDate, TestData);
        }

        [TestMethod]
        public void DeliveredStatusOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "Delivered";
            //assign the data to the property
            AnOrder.DeliveredStatus = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AnOrder.DeliveredStatus, TestData);
        }

        [TestMethod]
        public void TotalAmountOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Decimal TestData = 15;
            //assign the data to the property
            AnOrder.TotalAmount = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AnOrder.TotalAmount, TestData);
        }

        [TestMethod]
        public void ShippingAddressOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "Gateway House, Leicester, LE1 9BH";
            //assign the data to the property
            AnOrder.ShippingAddress = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AnOrder.ShippingAddress, TestData);
        }

        [TestMethod]
        public void StaffIdOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int16 TestData = 1001;
            //assign the data to the property
            AnOrder.StaffId = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AnOrder.StaffId, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean cariable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int16 OrderId = 21;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderIdFoundOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the results of the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is Ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int16 OrderId = 21;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the Order Id
            if (AnOrder.OrderId != 1)
            { 
                OK = false; 
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }
    }
}