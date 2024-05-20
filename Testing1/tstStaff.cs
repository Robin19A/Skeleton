using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //crate an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            Assert.IsNotNull(AnStaff);

        }
        
    }
}
