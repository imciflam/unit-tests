using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kpo4310.mvv.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//dependency  
using Kpo4310.mvv.main;
using System.IO;

namespace Kpo4310.mvv.Lib.Tests
{
    [TestClass()]
    public class UnitTestProject
    {
        [TestMethod()]
        public void TestMethod1()
        {
            FrmMain z = new FrmMain();
            FrmMain.nameChecker();
            Assert.IsNotNull(z.names); 
        }
        [TestMethod()]
        public void TestMethod2()
        {
            FrmMain z = new FrmMain();
            Assert.AreEqual(FrmMain.nameChecker(), "Нейтрон"+ Environment.NewLine+"Ка-плюс"+ Environment.NewLine+"Электрон" + Environment.NewLine);
           // FrmMain.nameChecker() = 
           /* foreach(var name in z.names)
            {
                Assert.IsInstanceOfType(name, typeof(string));
            }*/
           // Assert.IsInstanceOfType(z.names, typeof(List<string>));






        }
       /* public void TestMethod3()
        {
            FrmMain z = new FrmMain();
            FrmMain.nameChecker();
            Assert.IsNotNull(z.fstream);
        }*/

    }
}
