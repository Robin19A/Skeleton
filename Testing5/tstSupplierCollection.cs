using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Dynamic;

namespace Testing5
{
    [TestClass]
    public class tstSupplierCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //test to see that is exists
            Assert.IsNotNull(AllSuppliers);
        }

        [TestMethod]

        public void SupplierListOK()
        {
            //create an instance of the class we want to create 
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create some test data to assign to the property 
            //in this case the data needs to be a list of objects
            List<clsSupplier> TestList = new List<clsSupplier>();
            //Add an item to the List
            //create the item of test data 
            clsSupplier TestItem = new clsSupplier();
            //sets its properties 
            TestItem.Active = true;
            TestItem.SupplierId = 1;
            TestItem.SupplierName = "Shadeless";
            TestItem.Address = "Some address";
            TestItem.Phone = "555-363-0000";
            TestItem.Email = "Shadeless@gmail.com";
            TestItem.DateAdded = DateTime.Now;
            //add the item to the Testlist
            TestList.Add(TestItem);
            //assign the data to the property
            AllSuppliers.SupplierList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllSuppliers.SupplierList, TestList);
        }

        [TestMethod]

        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create some test data to assign to the property 
            //in this case the data needs to be a list of objects
            List<clsSupplier>TestList = new List<clsSupplier>();
            //Add an item to the list
            //create the item of test data
            clsSupplier TestItem = new clsSupplier();
            //set its properties
            TestItem.Active = true;
            TestItem.SupplierId = 1;
            TestItem.SupplierName = "Shadeless";
            TestItem.Address = "Some address";
            TestItem.Phone = "555-363-0000";
            TestItem.Email = "Shadeless@gmail.com";
            TestItem.DateAdded = DateTime.Now;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property 
            AllSuppliers.SupplierList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllSuppliers.Count, TestList.Count);
        }

        [TestMethod]

        public void ThisSupplierPropertyOK() 
        {
            //create an instance of the class we want to create 
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create some test data to assign to the property
            clsSupplier TestSupplier = new clsSupplier();
            //set the properties of the test project
            TestSupplier.Active = true;
            TestSupplier.SupplierId = 1;
            TestSupplier.SupplierName = "Shadeless";
            TestSupplier.Address = "Some address";
            TestSupplier.Phone = "555-363-0000";
            TestSupplier.Email = "Shadeless@gmail.com";
            TestSupplier.DateAdded = DateTime.Now;
            //assign the data to the property
            AllSuppliers.ThisSupplier = TestSupplier;
            //test to see that the two values are the same
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestSupplier);
        }

        [TestMethod]

        public void ListandOK()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsSupplier> TestList = new List<clsSupplier>();
            //Add an item to the list
            //create the item of test data
            clsSupplier TestItem = new clsSupplier();
            //set its properties
            TestItem.Active = true;
            TestItem.SupplierId = 1;
            TestItem.SupplierName = "Shadeless";
            TestItem.Address = "Some address";
            TestItem.Phone = "555-363-0000";
            TestItem.Email = "Shadeless@gmail.com";
            TestItem.DateAdded = DateTime.Now;
            //add the item to the TestList
            TestList.Add(TestItem);
            //assign the data to the property
            AllSuppliers.SupplierList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllSuppliers.Count, TestList.Count);
        }

        [TestMethod]

        public void AddMethodOK()
        {
            //create an instance of of the class we want create 
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create the item of test data
            clsSupplier TestItem = new clsSupplier();
            //variable to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.SupplierId = 1;
            TestItem.SupplierName = "Shadeless";
            TestItem.Address = "Some address";
            TestItem.Phone = "555-363-0000";
            TestItem.Email = "Shadeless@gmail.com";
            TestItem.DateAdded = DateTime.Now;
            //set ThisSupplier to the test data
            AllSuppliers.ThisSupplier = TestItem;
            //add the record
            PrimaryKey = AllSuppliers.Add();
            //set the primary key of the test data
            TestItem.SupplierId = PrimaryKey;
            //find the record
            AllSuppliers.ThisSupplier.Find(PrimaryKey);
            //test to see that the two values are the same 
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestItem);
        }
    }
}





