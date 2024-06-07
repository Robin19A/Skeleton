using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Net;
using static System.Net.Mime.MediaTypeNames;


namespace Testing4
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //test to see that is exists
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderListOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property 
            //in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //Add an Item to the List 
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.DeliveryStatus = true;
            TestItem.OrderId = 4;
            TestItem.CustomerId = 4000;
            TestItem.OrderDate = DateTime.Now;
            TestItem.TotalAmount = 30;
            TestItem.ShippingAddress = "Gateway House, Leicester, LE1 9BH";
            TestItem.StaffId = 1004;
            //add the tiem to the test list
            TestList.Add(TestItem);
            //assign the data to the proprty
            AllOrders.OrderList = TestList;
            //test to see that the two values are the dsame
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        [TestMethod]
        public void ThisOrderOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property 
            clsOrder TestOrder = new clsOrder();
            //set its properties
            TestOrder.DeliveryStatus = true;
            TestOrder.OrderId = 4;
            TestOrder.CustomerId = 4000;
            TestOrder.OrderDate = DateTime.Now;
            TestOrder.TotalAmount = 30;
            TestOrder.ShippingAddress = "Gateway House, Leicester, LE1 9BH";
            TestOrder.StaffId = 1004;
            //assign the data to the proprty
            AllOrders.ThisOrder = TestOrder;
            //test to see that the two values are the dsame
            Assert.AreEqual(AllOrders.OrderList, TestOrder);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property 
            //in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //Add an Item to the List 
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.DeliveryStatus = true;
            TestItem.OrderId = 4;
            TestItem.CustomerId = 4000;
            TestItem.OrderDate = DateTime.Now;
            TestItem.TotalAmount = 30;
            TestItem.ShippingAddress = "Gateway House, Leicester, LE1 9BH";
            TestItem.StaffId = 1004;
            //add the tiem to the test list
            TestList.Add(TestItem);
            //assign the data to the proprty
            AllOrders.OrderList = TestList;
            //test to see that the two values are the dsame
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.DeliveryStatus = true;
            TestItem.OrderId = 1;
            TestItem.CustomerId = 1500;
            TestItem.OrderDate = DateTime.Now;
            TestItem.TotalAmount = 60;
            TestItem.ShippingAddress = "Gateway House, Leicester, LE1 9BH";
            TestItem.StaffId = 2000;
            //set ThisAddress to the test data
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            //set the primary ket of the test data
            TestItem.OrderId = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            TestItem.DeliveryStatus = true;
            TestItem.OrderId = 4;
            TestItem.CustomerId = 4000;
            TestItem.OrderDate = DateTime.Now;
            TestItem.TotalAmount = 30;
            TestItem.ShippingAddress = "Gateway House, Leicester, LE1 9BH";
            TestItem.StaffId = 1004;
            //set ThisAddress to the test data
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            //set the primary ket of the test data
            TestItem.OrderId = PrimaryKey;
            TestItem.DeliveryStatus = false;
            TestItem.CustomerId = 4500;
            TestItem.OrderDate = DateTime.Now;
            TestItem.TotalAmount = 35;
            TestItem.ShippingAddress = "Gateway House, Floor 2, Leicester, LE1 9BH";
            TestItem.StaffId = 1045;
            //set the record based on the new test data
            AllOrders.ThisOrder = TestItem;
            AllOrders.Update();
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see if ThisAddress matches the test data Assert.AreEqual(AllAddresses. ThisAddress, TestItem);

        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.DeliveryStatus = true;
            TestItem.OrderId = 4;
            TestItem.CustomerId = 4000;
            TestItem.OrderDate = DateTime.Now;
            TestItem.TotalAmount = 30;
            TestItem.ShippingAddress = "Gateway House, Leicester, LE1 9BH";
            TestItem.StaffId = 1004;
            //set ThisAddress to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderId = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //delete the record
            AllOrders.Delete();
            //now find the record
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }
    }
}
