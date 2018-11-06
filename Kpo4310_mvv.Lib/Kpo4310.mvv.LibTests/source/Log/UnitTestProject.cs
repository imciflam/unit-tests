using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kpo4310.mvv.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4310.mvv.Lib.Tests
{
    [TestClass()]
    public class UnitTestProject
    {
        [TestMethod()]
        public void TestMethod1()
        {
            LogUtility.ErrorLog("");
            Assert.IsNotNull(LogUtility.address);
        }
        [TestMethod()]
        public void TestMethod2()
        {
            LogUtility.ErrorLog("");
            Assert.IsTrue(LogUtility.address == "error.log");
        }

    }
}
