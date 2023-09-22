using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SavitskyDA.Sprint1.Task1.V6.Lib;

namespace Tyuiu.SavitskyDA.Sprint1.Task1.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 5.0;
            double y = 1.0;
            var res = ds.Calculate(x,y);
            Assert.AreEqual(2, res);
        }
    }
}
