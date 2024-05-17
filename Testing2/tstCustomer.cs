using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
        public object CustomerDateofbirth { get; private set; }

        [TestMethod]

        public void InstanceOK()
        {
            //create an instance of the class we want create
            clsCustomer AnCustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(AnCustomer);
        }
        [TestMethod]

        public void ActiveCustomerOK()
        {

            //create a instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the customers
            Boolean TestData = true;
            //assign the data to the customer
            AnCustomer.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Active, TestData);

        }
        public void DateAddedCustomerOK()
        {
            //CREATE AN INSTANCE OF THE class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the customer
            DateTime TestData = DateTime.Now.Date;
            //Assign the data to the property
            AnCustomer.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.DateAdded, TestData);
        }
        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnCustomer.CustomerId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerId, TestData);
        }
        [TestMethod]
        public void CustomerUsernamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnCustomer.CustomerUsername = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerUsername, TestData);
        }
        [TestMethod]
        public void CustomerPasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "greenboy32";
            //assign the data to the property
            AnCustomer.CustomerPassword = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerPassword, TestData);
        }
        [TestMethod]
        public void CustomerEmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "enochoyegoke48@gmail.com";
            //assign the data to the property
            AnCustomer.CustomerEmail = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerEmail, TestData);
        }
        [TestMethod]
        public void CustomerDateOfBirthPropertyOK()
        {
            //CREATE AN INSTANCE OF THE class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the customer
            DateTime TestData = DateTime.Now.Date;
            //Assign the data to the property
            AnCustomer.CustomerDateofbirth = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerDateofbirth, TestData);
        }

        [TestMethod]

        public void CustomerAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Oranmore Street ,Ballyfermout ,Dublin 10";
            //assign the data to the property
            AnCustomer.CustomerAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerAddress, TestData);
        }


    }
}



