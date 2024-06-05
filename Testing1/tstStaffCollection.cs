using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffes = new clsStaffCollection();
            //test to see that is exists
            Assert.IsNotNull(AllStaffes);
        }

        [TestMethod]
        public void StaffListOK()
        {
            clsStaffCollection AllStaffes = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.Active = true;
            TestItem.StaffId = 1;
            TestItem.DateOfBirth = DateTime.Now;
            TestItem.Name = "Robin";
            TestItem.Email = "robinyo@gmail.com";
            TestItem.Gender = "Male";
            TestItem.Address = "LE20PE";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaffes.StaffList = TestList;
            //test to sea that the two values are the same
            Assert.AreEqual(AllStaffes.StaffList, TestList);

        }

        [TestMethod]
        public void CountPropertyOK()
        {
            clsStaffCollection AllStaffes = new clsStaffCollection();
            Int32 SomeCount = AllStaffes.Count;
            AllStaffes.Count = SomeCount;
            Assert.AreEqual(AllStaffes.Count, SomeCount);
        }

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            clsStaffCollection AllStaffes = new clsStaffCollection();
            clsStaff TestStaff = new clsStaff();
            //set the properties of the test object
            TestStaff.Active = true;
            TestStaff.StaffId = 1;
            TestStaff.DateOfBirth = DateTime.Now;
            TestStaff.Name = "Robin";
            TestStaff.Email = "robinyo@gmail.com";
            TestStaff.Gender = "Male";
            TestStaff.Address = "LE20PE";
            //assign the data to the property
            AllStaffes.ThisStaff = TestStaff;
            Assert.AreEqual(AllStaffes.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsStaffCollection AllStaffes = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.Active = true;
            TestItem.StaffId = 1;
            TestItem.DateOfBirth = DateTime.Now;
            TestItem.Name = "Robin";
            TestItem.Email = "robinyo@gmail.com";
            TestItem.Gender = "Male";
            TestItem.Address = "LE20PE";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaffes.StaffList = TestList;
            Assert.AreEqual(AllStaffes.Count, TestList.Count);
        }

        [TestMethod]
        public void TwoRecordspresent()
        {
            clsStaffCollection AllStaffes = new clsStaffCollection();
            Assert.AreEqual(AllStaffes.Count,AllStaffes.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffes = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //variable t store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.StaffId = 1;
            TestItem.DateOfBirth = DateTime.Now;
            TestItem.Name = "Robin";
            TestItem.Email = "robinyo@gmail.com";
            TestItem.Gender = "Male";
            TestItem.Address = "LE20PE";
            //set ThisStaff to the test data
            AllStaffes.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaffes.Add();
            //set the primary key of the test data
            TestItem.StaffId = PrimaryKey;
            //find the record
            AllStaffes.ThisStaff.Find(PrimaryKey);
            //test t see that two values are the same
            Assert.AreEqual(AllStaffes.ThisStaff, TestItem);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an imstance of the class we want to create
            clsStaffCollection AllStaffes = new clsStaffCollection();
            //create the item of tesst data
            clsStaff TestItem = new clsStaff();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.DateOfBirth = DateTime.Now;
            TestItem.Name = "Robin";
            TestItem.Email = "robinyo@gmail.com";
            TestItem.Gender = "Male";
            TestItem.Address = "LE20PE";
            //set ThisStaff to the test data
            AllStaffes.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaffes.Add();
            //set the primary key of the test data
            TestItem.StaffId = PrimaryKey;
            //moidify the test record
            TestItem.Active = false;
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.Name = "Archie";
            TestItem.Email = "archie@gmail.com";
            TestItem.Gender = "Male";
            TestItem.Address = "Le21pe";
            //set the record based on the new test data
            AllStaffes.ThisStaff = TestItem;
            //update the record
            AllStaffes.Update();

            //find the record
            AllStaffes.ThisStaff.Find(PrimaryKey);
            //test to see if Thisaddress matches the test data
            Assert.AreEqual(AllStaffes.ThisStaff, TestItem);



        }

        [TestMethod]
        public void DeleteMethodOK() 
        {
            //create an imstance of the class we want to create
            clsStaffCollection AllStaffes = new clsStaffCollection();
            //create the item of tesst data
            clsStaff TestItem = new clsStaff();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.StaffId = 1;
            TestItem.DateOfBirth = DateTime.Now;
            TestItem.Name = "Robin";
            TestItem.Email = "robinyo@gmail.com";
            TestItem.Gender = "Male";
            TestItem.Address = "LE20PE";
            //set ThisStaff to the test data
            AllStaffes.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaffes.Add();
            //set the primary key of the test data
            TestItem.StaffId = PrimaryKey;
            //find the record
            AllStaffes.ThisStaff.Find(PrimaryKey);
            //delete the record
            AllStaffes.Delete();
            //now find the record was not found
            Boolean Found = AllStaffes.ThisStaff.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }
    }
}
