using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SumNumbers.Test
{
    [TestClass]
    public class SumBumbers_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            SumBumbers_BLL.SumBumbers_BLL testObj = new SumBumbers_BLL.SumBumbers_BLL();
            Assert.AreEqual(testObj.SumNumbers(10, 4), 14);
        }

        [TestMethod]
        public void TestMethod2()
        {

            SumBumbers_BLL.SumBumbers_BLL testObj = new SumBumbers_BLL.SumBumbers_BLL();
            Assert.AreEqual(testObj.SumNumbers(10, 4), 14,"Sum numbers fail");
           
        }
    }
}
