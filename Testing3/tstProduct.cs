using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;
using ClassLibrary;
using System.Security.Cryptography.X509Certificates;
using System.IO;

namespace Testing6
{
    [TestClass]
    public class tstProduct
    {
        string Name = "Syed waqar ali";
        string Description = "good";
        string DateAdded = DateTime.Now.ToShortDateString();
        string UnitPrice = " 12";
        string SupplierID = "12345";
        string Available = "Active";






        private string mDescription = "Some Description";
        private bool OK;
        private object AnProduct;

        [TestMethod]
        public void InstanceOK()
        {

            clsProduct AnProduct = new clsProduct();

            Assert.IsNotNull(AnProduct);
        }

        [TestMethod]
        public void ProductIDPropertyOK()
        {

            clsProduct AnProduct = new clsProduct();
            Int32 TestData = 1;
            AnProduct.ProductID = TestData;

            Assert.IsNotNull(AnProduct);
            Assert.AreEqual(AnProduct.ProductID, TestData);
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
        [TestMethod]
        public void FindMethodOK()
        {

            clsProduct AnProduct = new clsProduct();
            Boolean Found = false;
            Int32 ProductID = 1;
            Found = AnProduct.Find(ProductID);
            Assert.IsTrue(Found);
        }



        [TestMethod]

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
            Int32 ProductID = 21;
            Found = AnProduct.Find(ProductID);
            if (AnProduct.ProductID != 21)
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
            if (AnProduct.ProductID != 21)
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
            if (AnProduct.ProductID != 21)
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
            if (AnProduct.ProductID != 21)
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
            if (AnProduct.ProductID != 21)
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
            if (AnProduct.ProductID != 21)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void validMehtodOK()
        {
            clsProduct AnProduct = new clsProduct();
            String Error = "";
            string TestData = mDescription;
            Error = AnProduct.Valid(Name, Description, UnitPrice, DateAdded, SupplierID, Available);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductMinLessOne()
        {
            clsProduct AnProduct = new clsProduct();
            String Error = "";
            string ProductID = "";
            Error = AnProduct.Valid(Name, Description, UnitPrice, DateAdded, SupplierID, Available);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductMin()
        {
            clsProduct AnProduct = new clsProduct();
            String Error = "";
            string ProductID = "12";
            Error = AnProduct.Valid(Name, Description, UnitPrice, DateAdded, SupplierID, Available);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductMinPulsOne()
        {
            clsProduct AnProduct = new clsProduct();
            String Error = "";
            string ProductID = "123";
            Error = AnProduct.Valid(Name, Description, UnitPrice, DateAdded, SupplierID, Available);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductMaxLessOne()
        {
            clsProduct AnProduct = new clsProduct();
            String Error = "";
            string ProductID = "123456";
            Error = AnProduct.Valid(Name, Description, UnitPrice, DateAdded, SupplierID, Available);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductMax()
        {
            clsProduct AnProduct = new clsProduct();
            String Error = "";
            string ProductID = "12356776";
            Error = AnProduct.Valid(Name, Description, UnitPrice, DateAdded, SupplierID, Available);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductMid()
        {
            clsProduct AnProduct = new clsProduct();
            String Error = "";
            string ProductID = "123";
            Error = AnProduct.Valid(Name, Description, UnitPrice, DateAdded, SupplierID, Available);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductMaxPulseOne()
        {
            clsProduct AnProduct = new clsProduct();
            String Error = "";
            string ProductID = "1233445";
            Error = AnProduct.Valid(Name, Description, UnitPrice, DateAdded, SupplierID, Available);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductExtremeMax()
        {
            clsProduct AnProduct = new clsProduct();
            String Error = "";
            String ProductID = "";
            ProductID = ProductID.PadRight(500, 'a');
            Error = AnProduct.Valid(Name, Description, UnitPrice, DateAdded, SupplierID, Available);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnProduct.Valid(Name, Description, UnitPrice, DateAdded, SupplierID, Available);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnProduct.Valid(Name, Description, UnitPrice, DateAdded, SupplierID, Available);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnProduct.Valid(Name, Description, UnitPrice, DateAdded, SupplierID, Available);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnProduct.Valid(Name, Description, UnitPrice, DateAdded, SupplierID, Available);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable

            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnProduct.Valid(Name, Description, UnitPrice, DateAdded, SupplierID, Available);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }




    }

    
}


    

        









    



            
    



    
