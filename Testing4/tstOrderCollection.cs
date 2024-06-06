using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Net;


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
    }
}
