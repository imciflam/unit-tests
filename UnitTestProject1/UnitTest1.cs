using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Kpo4310.mvv.Lib.Test
{
    [TestClass()]
    public static class UnitTest1
    {

        [TestMethod()]
        public static void TestMethod1()
        {
            LogUtility.ErrorLog("");
            Assert.IsNotNull(LogUtility.address);
            //  Assert.IsNull(LogUtility.address);
        }

        [TestMethod()]
        public static void TestMethod2()
        {
            LogUtility.ErrorLog("");
            Assert.IsTrue(LogUtility.address == "error.log");
            // System.Diagnostics.Debug.Assert(LogUtility.address == "error.log", "fail");
            //  Assert.IsNull(LogUtility.address);
        }

    }
}