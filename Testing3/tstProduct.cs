using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Testing3
{
    [TestClass]
    public class tstProduct
    {

        String Name = "ProductName";
        String Description = "Description";
        String DateAdded = DateTime.Now.ToShortDateString();
        String UnitPrice = "299.99";
        String SupplierID = "2";
        String Available = Convert.ToString(true);

        [TestMethod]
        public void ValidMethodOK()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            Error = AProduct.Valid(Name, Description, DateAdded, UnitPrice, SupplierID, Available);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void NameMinLessOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Name = "";
            Error = AProduct.Valid(Name, Description, DateAdded, UnitPrice, SupplierID, Available);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void NameMin()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Name = "n";
            Error = AProduct.Valid(Name, Description, DateAdded, UnitPrice, SupplierID, Available);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void NameMinPlusOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Name = "nn";
            Error = AProduct.Valid(Name, Description, DateAdded, UnitPrice, SupplierID, Available);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void NameMaxLessOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Name = "";
            Name = Name.PadRight(49, 'n');
            Error = AProduct.Valid(Name, Description, DateAdded, UnitPrice, SupplierID, Available);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void NameMax()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Name = "";
            Name = Name.PadRight(50, 'n');
            Error = AProduct.Valid(Name, Description, DateAdded, UnitPrice, SupplierID, Available);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void NameMaxPlusOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Name = "";
            Name = Name.PadRight(51, 'n');
            Error = AProduct.Valid(Name, Description, DateAdded, UnitPrice, SupplierID, Available);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void NameMid()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Name = "";
            Name = Name.PadRight(25, 'n');
            Error = AProduct.Valid(Name, Description, DateAdded, UnitPrice, SupplierID, Available);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void NameExtremeMax()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Name = "";
            Name = Name.PadRight(500, 'n');
            Error = AProduct.Valid(Name, Description, DateAdded, UnitPrice, SupplierID, Available);
            Assert.AreNotEqual(Error, "");
        }


        ////////////////////////


        [TestMethod]
        public void DescriptionMinLessOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Description = "";
            Error = AProduct.Valid(Name, Description, DateAdded, UnitPrice, SupplierID, Available);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DescriptionMin()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Description = "d";
            Error = AProduct.Valid(Name, Description, DateAdded, UnitPrice, SupplierID, Available);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DescriptionMinPlusOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Description = "dd";
            Error = AProduct.Valid(Name, Description, DateAdded, UnitPrice, SupplierID, Available);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DescriptionMaxLessOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Description = "";
            Description = Description.PadRight(199, 'd');
            Error = AProduct.Valid(Name, Description, DateAdded, UnitPrice, SupplierID, Available);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DescriptionMax()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Description = "";
            Description = Description.PadRight(200, 'd');
            Error = AProduct.Valid(Name, Description, DateAdded, UnitPrice, SupplierID, Available);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DescriptionMaxPlusOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            string Description = "";
            Description = Description.PadRight(201, 'd');
            Error = AProduct.Valid(Name, Description, DateAdded, UnitPrice, SupplierID, Available);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DescriptionMid()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            string Description = "";
            Description = Description.PadRight(100, 'd');
            Error = AProduct.Valid(Name, Description, DateAdded, UnitPrice, SupplierID, Available);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DescriptionExtremeMax()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            string Description = "";
            Description = Description.PadRight(2000, 'd');
            Error = AProduct.Valid(Name, Description, DateAdded, UnitPrice, SupplierID, Available);
            Assert.AreNotEqual(Error, "");
        }



        /////////////////////


        [TestMethod]
        public void DateAddedExtremeMinimum()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            DateTime TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateAdded = TestDate.ToString();
            Error = AProduct.Valid(Name, Description, DateAdded, UnitPrice, SupplierID, Available);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DateAddedMinLessOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            DateTime TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string DateAdded = TestDate.ToString();
            Error = AProduct.Valid(Name, Description, DateAdded, UnitPrice, SupplierID, Available);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DateAddedMin()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            DateTime TestDate = DateTime.Now.Date;
            string DateAdded = TestDate.ToString();
            Error = AProduct.Valid(Name, Description, DateAdded, UnitPrice, SupplierID, Available);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            DateTime TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string DateAdded = TestDate.ToString();
            Error = AProduct.Valid(Name, Description, DateAdded, UnitPrice, SupplierID, Available);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DateAddedExtremeMaximum()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            DateTime TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DateAdded = TestDate.ToString();
            Error = AProduct.Valid(Name, Description, DateAdded, UnitPrice, SupplierID, Available);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DateAddedInvalidDataType()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            string DateAdded = "DAteAdded is not a valid date :";
            Error = AProduct.Valid(Name, Description, DateAdded, UnitPrice, SupplierID, Available);
            Assert.AreNotEqual(Error, "");
        }




        ////////////////////////



        [TestMethod]
        public void UnitPriceExtremeMin()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            Double TestUnitPrice = -10000;
            String UnitPrice = TestUnitPrice.ToString();
            Error = AProduct.Valid(Name, Description, DateAdded, UnitPrice, SupplierID, Available);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UnitPriceMinLessOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            Double TestUnitPrice = 0;
            String UnitPrice = TestUnitPrice.ToString();
            Error = AProduct.Valid(Name, Description, DateAdded, UnitPrice, SupplierID, Available);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UnitPriceMin()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            Double TestUnitPrice = 1.00;
            String UnitPrice = TestUnitPrice.ToString();
            Error = AProduct.Valid(Name, Description, DateAdded, UnitPrice, SupplierID, Available);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UnitPriceMinPlusOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            Double TestUnitPrice = 2.00;
            String UnitPrice = TestUnitPrice.ToString();
            Error = AProduct.Valid(Name, Description, DateAdded, UnitPrice, SupplierID, Available);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UnitPriceMaxLessOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            Double TestUnitPrice = 9999.00;
            String UnitPrice = TestUnitPrice.ToString();
            Error = AProduct.Valid(Name, Description, DateAdded, UnitPrice, SupplierID, Available);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UnitPriceMax()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            Double TestUnitPrice = 10000.00;
            String UnitPrice = TestUnitPrice.ToString();
            Error = AProduct.Valid(Name, Description, DateAdded, UnitPrice, SupplierID, Available);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UnitPriceMaxPlusOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            Double TestUnitPrice = 10001.00;
            String UnitPrice = TestUnitPrice.ToString();
            Error = AProduct.Valid(Name, Description, DateAdded, UnitPrice, SupplierID, Available);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UnitPriceMid()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            Double TestUnitPrice = 5000.00;
            String UnitPrice = TestUnitPrice.ToString();
            Error = AProduct.Valid(Name, Description, DateAdded, UnitPrice, SupplierID, Available);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UnitPriceExtremeMax()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            Double TestUnitPrice = 1000000.00;
            String UnitPrice = TestUnitPrice.ToString();
            Error = AProduct.Valid(Name, Description, DateAdded, UnitPrice, SupplierID, Available);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UnitPriceInvalidData()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String UnitPrice = "This is Not a Double.";
            Error = AProduct.Valid(Name, Description, DateAdded, UnitPrice, SupplierID, Available);
            Assert.AreNotEqual(Error, "");
        }

        /// ///////////////////////////

        [TestMethod]
        public void SupplierIDExtremeMin()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            Double TestSupplierID = -5;
            String SupplierID = TestSupplierID.ToString();
            Error = AProduct.Valid(Name, Description, DateAdded, UnitPrice, SupplierID, Available);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierIDMinLessOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            Double TestSupplierID = 0;
            String SupplierID = TestSupplierID.ToString();
            Error = AProduct.Valid(Name, Description, DateAdded, UnitPrice, SupplierID, Available);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierIDMin()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            Double TestSupplierID = 1;
            String SupplierID = TestSupplierID.ToString();
            Error = AProduct.Valid(Name, Description, DateAdded, UnitPrice, SupplierID, Available);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierIDMinPlusOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            Double TestSupplierID = 2;
            String SupplierID = TestSupplierID.ToString();
            Error = AProduct.Valid(Name, Description, DateAdded, UnitPrice, SupplierID, Available);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void SupplierIDInvalidData()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";

            String SupplierID = "This is Not a Double.";
            Error = AProduct.Valid(Name, Description, DateAdded, UnitPrice, SupplierID, Available);
            Assert.AreNotEqual(Error, "");
        }


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
            string TestData = "Name";
            AnProduct.Name = TestData;

            Assert.AreEqual(AnProduct.Name, TestData);


        }

        [TestMethod]
        public void DescriptionPropertyOK()
        {

            clsProduct AnProduct = new clsProduct();
            string TestData = "Description";
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

            double TestData = 19.99;

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
            Int32 ProductID = 3;
            Found = AnProduct.Find(ProductID);
            Assert.IsTrue(Found);
        }
        public void TestProductIDFound()
        {

            clsProduct AnProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 3;
            Found = AnProduct.Find(ProductID);
            if (AnProduct.ProductID != 3)
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
            Int32 ProductID = 3;
            Found = AnProduct.Find(ProductID);
            if (AnProduct.Name != "BROWN")
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
            Int32 ProductID = 3;
            Found = AnProduct.Find(ProductID);
            if (AnProduct.Description != "SUNGLASSES")
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
            Int32 ProductID = 3;
            Found = AnProduct.Find(ProductID);
            if (AnProduct.DateAdded != Convert.ToDateTime("13-03-2023"))
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
            Int32 ProductID = 3;
            Found = AnProduct.Find(ProductID);
            if (AnProduct.UnitPrice != 12)
            {
                OK = true;
            }

            Assert.IsTrue(OK);
        }
        [TestMethod]

        public void TestSupplierIDFound()
        {

            clsProduct AnProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 3;
            Found = AnProduct.Find(ProductID);
            if (AnProduct.SupplierID != 4)
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
            Int32 ProductID = 3;
            Found = AnProduct.Find(ProductID);
            if (AnProduct.Available != true)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
       }


    }
}

