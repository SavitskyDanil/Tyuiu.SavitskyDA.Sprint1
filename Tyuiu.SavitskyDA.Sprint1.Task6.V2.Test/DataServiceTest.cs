using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SavitskyDA.Sprint1.Task6.V2.Lib;

namespace Tyuiu.SavitskyDA.Sprint1.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();
            string value = "Hello";
            bool res = ds.CheckHello(value);
            Assert.AreEqual(true, res);
        }
    }
}
