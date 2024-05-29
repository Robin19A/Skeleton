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


        AProduct.Availability = TestData;


        Assert.AreEqual(AProduct.Availability, TestData);
    }



}
    }

