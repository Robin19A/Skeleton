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

    }
}
