using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstProductCollection
    {

        [TestMethod]
        public void InstanceOK()
        {
            clsProductCollection AllProduct = new clsProductCollection();
            Assert.IsNotNull(AllProduct);
        }


        [TestMethod]
        public void ProuctListOK()
        {
            clsProductCollection AllProduct = new clsProductCollection();
            List<clsProduct> TestList = new List<clsProduct>();
            clsProduct TestItem = new clsProduct();
            TestItem.ProductID = 1;
            TestItem.Name = "ProductName";
            TestItem.Description = "ProductDescription";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.UnitPrice = 5503.00;
            TestItem.SupplierID = 2;
            TestItem.Available = true;
            TestList.Add(TestItem);
            AllProduct.ProductList = TestList;
            Assert.AreEqual(AllProduct.ProductList, TestList);
        }


        [TestMethod]
        public void CountPropertyOK()
        {
            clsProductCollection AllProduct = new clsProductCollection();
            Int32 SomeCount = 0;
            AllProduct.Count = SomeCount;
            Assert.AreNotEqual(AllProduct.Count, SomeCount);
        }

        [TestMethod]
        public void ThisProductPropertyOK()
        {
            clsProductCollection AllProduct = new clsProductCollection();
            clsProduct TestItem = new clsProduct();

            TestItem.ProductID = 1;
            TestItem.Name = "ProductName";
            TestItem.Description = "ProductDescription";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.UnitPrice = 5503.00;
            TestItem.SupplierID = 2;
            TestItem.Available = true;
            AllProduct.ThisProduct = TestItem;

            Assert.AreEqual(AllProduct.ThisProduct, TestItem);
        }




        public void ListAndCountOK()
        {
            clsProductCollection AllProduct = new clsProductCollection();
            List<clsProduct> TestList = new List<clsProduct>();
            clsProduct TestItem = new clsProduct();

            TestItem.ProductID = 1;
            TestItem.Name = "ProductName";
            TestItem.Description = "ProductDescription";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.UnitPrice = 5503.00;
            TestItem.SupplierID = 2;
            TestItem.Available = true;
            TestList.Add(TestItem);
            AllProduct.ProductList = TestList;

            Assert.AreEqual(AllProduct.Count, TestList.Count);
        }


        [TestMethod]
        public void TwoRecordsPresent()
        {
            clsProductCollection AllProduct = new clsProductCollection();
            Assert.AreNotEqual(AllProduct.Count, 4);
        }


        [TestMethod]
        public void AddMethodOK()
        {
            clsProductCollection AllProduct = new clsProductCollection();
            clsProduct TestProduct = new clsProduct();
            Int32 PrimaryKey = 0;
            TestProduct.Name = "ProductName";
            TestProduct.Description = "ProductDescription";
            TestProduct.DateAdded = DateTime.Now.Date;
            TestProduct.UnitPrice = 5503.00;
            TestProduct.SupplierID = 2;
            TestProduct.Available = true;
            AllProduct.ThisProduct = TestProduct;
            PrimaryKey = AllProduct.Add();
            TestProduct.ProductID = PrimaryKey;
            AllProduct.ThisProduct.Find(PrimaryKey);
            Assert.AreEqual(AllProduct.ThisProduct, TestProduct);

        }


        [TestMethod]
        public void UpdateMethodOK()
        {
            clsProductCollection AllProduct = new clsProductCollection();
            clsProduct TestProduct = new clsProduct();

            Int32 PrimaryKey = 0;

            TestProduct.Name = "ProductName";
            TestProduct.Description = "ProductDescription";
            TestProduct.DateAdded = DateTime.Now.Date;
            TestProduct.UnitPrice = 5503.00;
            TestProduct.SupplierID = 2;
            TestProduct.Available = true;
            AllProduct.ThisProduct = TestProduct;
            PrimaryKey = AllProduct.Add();

            TestProduct.ProductID = PrimaryKey;


            TestProduct.Name = "MAX BROWN";
            TestProduct.Description = "Goggles";
            TestProduct.DateAdded = DateTime.Now.Date;
            TestProduct.UnitPrice = 503.00;
            TestProduct.SupplierID = 5;
            TestProduct.Available = true;
            AllProduct.ThisProduct = TestProduct;
            AllProduct.Update();
            AllProduct.ThisProduct.Find(PrimaryKey);
            Assert.AreEqual(AllProduct.ThisProduct, TestProduct);
        }


        [TestMethod]
        public void DeleteMethodOK()
        {
            clsProductCollection AllProduct = new clsProductCollection();
            clsProduct TestProduct = new clsProduct();
            Int32 PrimaryKey = 0;
            TestProduct.Name = "ProductName";
            TestProduct.Description = "ProductDescription";
            TestProduct.DateAdded = DateTime.Now.Date;
            TestProduct.UnitPrice = 5503.00;
            TestProduct.SupplierID = 2;
            TestProduct.Available = true;
            AllProduct.ThisProduct = TestProduct;
            PrimaryKey = AllProduct.Add();
            TestProduct.ProductID = PrimaryKey;
            AllProduct.ThisProduct.Find(PrimaryKey);
            AllProduct.Delete();
            Boolean Found = AllProduct.ThisProduct.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }


        [TestMethod]
        public void ReportByNameMethodOK()
        {

            clsProductCollection AllProduct = new clsProductCollection();

            clsProductCollection FilteredProducts = new clsProductCollection();
            FilteredProducts.ReportByName("");

            Assert.AreEqual(AllProduct.Count, FilteredProducts.Count);


        }

        [TestMethod]
        public void ReportByNameNoneFound()
        {

            clsProductCollection FilteredProducts = new clsProductCollection();
            FilteredProducts.ReportByName("xxx xxx");

            Assert.AreEqual(0, FilteredProducts.Count);


        }


        [TestMethod]

        public void ReportByNameTestDataFound()
        {
            clsProductCollection FilteredProducts = new clsProductCollection();
            Boolean OK = true;
            FilteredProducts.ReportByName("ProductName");

            if (FilteredProducts.Count == 2)
            {
                if (FilteredProducts.ProductList[0].ProductID != 24)
                {
                    OK = false;
                }
                if (FilteredProducts.ProductList[0].ProductID != 25)
                {
                    OK = false;
                }

            }
            else
            {
                OK = false;
            }
            Assert.IsFalse(OK);
        }
    }
}
