using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SavitskyDA.Sprint1.Task2.V26.Lib;

namespace Tyuiu.SavitskyDA.Sprint1.Task2.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            //ISprint1Task2V26.CalculateMinutesSinceStart(int, int)

            DataService ds = new DataService();
            int hour = 12;
            int min = 30;
            var res = ds.CalculateMinutesSinceStart(hour, min);
            Assert.AreEqual(750, res);
        }
    }
}
