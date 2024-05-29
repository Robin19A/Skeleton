using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstProduct
    {
       
          [TestMethod]
            public void InstanceOK()
            {
                clsProduct AnProduct = new clsProduct();
                Assert.IsNotNull(AnProduct);
            }

        }
    }

