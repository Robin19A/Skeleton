using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;

namespace Testing3
{
    [TestClass]
    public class tstProductUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsProductUser AnUser = new clsProductUser();
            Assert.IsNotNull(AnUser);
        }
        [TestMethod]
        public void AdminIDPropertyOK()
        {
            clsProductUser AnUser = new clsProductUser();
            Int32 TestData = 1;
            AnUser.UserID = TestData;
            Assert.AreEqual(AnUser.UserID, TestData);
        }
        [TestMethod]
        public void UsernamePropertyOK()
        {
            clsProductUser AnUser = new clsProductUser();
            string TestData = "WQar";
            AnUser.Username = TestData;
            Assert.AreEqual(AnUser.Username, TestData);
        }
        [TestMethod]
        public void PasswordPropertyOK()
        {
            clsProductUser AnUser = new clsProductUser();
            string TestData = "Ali124";
            AnUser.Password = TestData;
            Assert.AreEqual(AnUser.Password, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            clsProductUser AnUser = new clsProductUser();
            string TestData = "Stock Department";

            AnUser.Department = TestData;
            Assert.AreEqual(AnUser.Department, TestData);
        }
        [TestMethod]
        public void FindAdminMethodOK()
        {
            clsProductUser AnUser = new clsProductUser();
            Boolean Found = false;
            string Username = "Waqar Ali";
            string Password = "12345";
            Found = AnUser.FindUser(Username, Password);
            Assert.IsTrue(Found);
        }

        [TestMethod]

        public void TestUsernamePWFound()
        {
            clsProductUser AnUser = new clsProductUser();
            Boolean Found = false;
            Boolean Ok = true;
             string Username = "Waqar Ali";
            string Password = "12345";
            Found = AnUser.FindUser(Username, Password);

            if (AnUser.Username != Username && AnUser.Password != Password)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }
    }
}
