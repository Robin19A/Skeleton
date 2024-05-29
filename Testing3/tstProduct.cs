using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstProduct
    {
        public string mDescription { get; private set; }

        [TestMethod]
            public void InstanceOK()
            {
                clsProduct AnProduct = new clsProduct();
                Assert.IsNotNull(AnProduct);
            }
    
    [TestMethod]
    public void NamePropertyOK()
    {

        clsProduct AnProduct = new clsProduct();
        string TestData = mDescription;
        AnProduct.Name = TestData;

        Assert.AreEqual(AnProduct.Name, TestData);


    }

    [TestMethod]
    public void DescriptionPropertyOK()
    {

        clsProduct AnProduct = new clsProduct();
        string TestData = mDescription;
        AnProduct.Description = TestData;

        Assert.AreEqual(AnProduct.Description, TestData);


    }
    [TestMethod]
    public void DateAddedPropertyOK()
    {

        clsProduct AnAddress = new clsProduct();

        DateTime TestData = DateTime.Now.Date;

        AnAddress.DateAdded = TestData;

        Assert.AreEqual(AnAddress.DateAdded, TestData);
    }
    [TestMethod]
    public void UnitPricePropertyOK()
    {

        clsProduct AProduct = new clsProduct();

        decimal TestData = 19.99m;

        AProduct.UnitPrice = TestData;

        Assert.AreEqual(AProduct.UnitPrice, TestData);
    }
    [TestMethod]
    public void SupplierIDPropertyOK()
    {

        clsProduct AnProduct = new clsProduct();


        Int32 TestData = 1;


        AnProduct.SupplierID = TestData;


        Assert.IsNotNull(AnProduct);


        Assert.AreEqual(AnProduct.SupplierID, TestData);
    }
    [TestMethod]
    public void AvailablePropertyOK()
    {

        clsProduct AProduct = new clsProduct();


        Boolean TestData = true;


        AProduct.Available = TestData;


        Assert.AreEqual(AProduct.Available, TestData);
    }
        [TestMethod]
        public void FindMethodOK()
        {

            clsProduct AnProduct = new clsProduct();
            Boolean Found = false;
            Int32 ProductID = 1;
            Found = AnProduct.Find(ProductID);
            Assert.IsTrue(Found);
        }
        public void TestProductIDFound()
        {

            clsProduct AnProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 21;
            Found = AnProduct.Find(ProductID);
            if (AnProduct.ProductID != 21)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
        [TestMethod]

        public void TestNameFound()
        {

            clsProduct AnProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID =21;
            Found = AnProduct.Find(ProductID);
            if (AnProduct.Name != "Black glasses")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
        [TestMethod]

        public void TestDecriptionFound()
        {

            clsProduct AnProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 21;
            Found = AnProduct.Find(ProductID);
            if (AnProduct.Description != "Sunglasses")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
        [TestMethod]

        public void TestDateAddedFound()
        {

            clsProduct AnProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 21;
            Found = AnProduct.Find(ProductID);
            if (AnProduct.DateAdded != Convert.ToDateTime("12/12/12"))
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
        [TestMethod]

        public void TestUnitPriceFound()
        {

            clsProduct AnProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 21;
            Found = AnProduct.Find(ProductID);
            if (AnProduct.UnitPrice != 12)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
        [TestMethod]

        public void TestSupplierIDFound()
        {

            clsProduct AnProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 21;
            Found = AnProduct.Find(ProductID);
            if (AnProduct.SupplierID != 1)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
        [TestMethod]

        public void TestAvaibleFound()
        {

            clsProduct AnProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 21;
            Found = AnProduct.Find(ProductID);
            if (AnProduct.Available != true)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }



    }
    }

