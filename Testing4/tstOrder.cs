using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Net;
using static System.Net.Mime.MediaTypeNames;
namespace Testing4
{
    [TestClass]
    public class tstOrder
    {

        //good test data
        //create some test data to pass the method
        string CustomerId = "4000";
        string OrderDate = DateTime.Now.ToShortDateString();
        string TotalAmount = "30";
        string ShippingAddress = "Gateway House, Leicester, LE1 9BH";
        string StaffId = "1004";

        /******************INSTANCE OF THE CLASS TEST******************/
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);
        }

        /******************PROPERTY OK TESTS******************/
        [TestMethod]
        public void OrderIdOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 4;
            //assign the data to the property
            AnOrder.OrderId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderId, TestData);
        }

        [TestMethod]
        public void CustomerIdOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 4000;
            //assign the data to the property
            AnOrder.CustomerId = TestData;
            //test to see that the two values are the same
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
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderDate, TestData);
        }

        [TestMethod]
        public void DeliveryStatusOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnOrder.DeliveryStatus = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.DeliveryStatus, TestData);
        }

        [TestMethod]
        public void TotalAmountOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Decimal TestData = 30;
            //assign the data to the property
            AnOrder.TotalAmount = TestData;
            //test to see that the two values are the same
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
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.ShippingAddress, TestData);
        }

        [TestMethod]
        public void StaffIdOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1004;
            //assign the data to the property
            AnOrder.StaffId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.StaffId, TestData);
        }

        /******************FIND METHOD TEST******************/
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderId = 4;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        /******************PROPERTY DATA TESTS******************/
        [TestMethod]
        public void TestOrderIdFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 4;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the Order id property
            if (AnOrder.OrderId != 4)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerIdFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 4;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the house no property
            if (AnOrder.CustomerId != 4000)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderDateFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 4;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the street property
            if (AnOrder.OrderDate != Convert.ToDateTime("07/06/2024"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DeliveryStatusFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 4;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the town property
            if (AnOrder.DeliveryStatus != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TotalAmountFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 4;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the post code property
            if (AnOrder.TotalAmount != 30)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ShippingAddressFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 4;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the county code property
            if (AnOrder.ShippingAddress != "Gateway House, Leicester, LE1 9BH")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffIdFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 4;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the date added property
            if (AnOrder.StaffId != 1004)
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
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnOrder.Valid(OrderDate, TotalAmount, ShippingAddress);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
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
            Error = AnOrder.Valid(OrderDate, TotalAmount, ShippingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "*");
        }

        [TestMethod]
        public void OrderDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderDate, TotalAmount, ShippingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderDate, TotalAmount, ShippingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderDate, TotalAmount, ShippingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderDate, TotalAmount, ShippingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateInvalidData()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //set the DateAdded to a non date value
            string OrderDate = "this is not a date!";
            //invoke the method
            Error = AnOrder.Valid(OrderDate, TotalAmount, ShippingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ShippingAddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ShippingAddress = ""; //this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(OrderDate, TotalAmount, ShippingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "*");
        }

        [TestMethod]
        public void ShippingAddressMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ShippingAddress = "a"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderDate, TotalAmount, ShippingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingAddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ShippingAddress = "aa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderDate, TotalAmount, ShippingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ShippingAddress = "";
            ShippingAddress = ShippingAddress.PadRight(49, 'a'); //this should fail             
            //invoke the method
            Error = AnOrder.Valid(OrderDate, TotalAmount, ShippingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingAddressMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ShippingAddress = "";
            ShippingAddress = ShippingAddress.PadRight(50, 'a'); //this should fail             
            //invoke the method
            Error = AnOrder.Valid(OrderDate, TotalAmount, ShippingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingAddressMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ShippingAddress = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderDate, TotalAmount, ShippingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingAddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ShippingAddress = "";
            ShippingAddress = ShippingAddress.PadRight(51, 'a'); //this should fail            
            //invoke the method
            Error = AnOrder.Valid(OrderDate, TotalAmount, ShippingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ShippingAddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ShippingAddress = "";
            ShippingAddress = ShippingAddress.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnOrder.Valid(OrderDate, TotalAmount, ShippingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}


