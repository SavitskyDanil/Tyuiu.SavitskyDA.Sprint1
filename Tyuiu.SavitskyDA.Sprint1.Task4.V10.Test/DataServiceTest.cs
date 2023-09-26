using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SavitskyDA.Sprint1.Task4.V10.Lib;

namespace Tyuiu.SavitskyDA.Sprint1.Task4.V10.Test
{
    [TestClass]
    public class DataServiceTest 
    {
        [TestMethod]
        public void ValidExpression()
        {

            //(1+cosα) / (sin2α)

            DataService ds = new DataService();
            double a = 2;
            double x = a * (Math.PI / 180);
            double wait = (Math.Round(0.7061, 3));
            var res = ds.Calculate(a);
            Assert.AreEqual(wait, res);

        }
    }
}
