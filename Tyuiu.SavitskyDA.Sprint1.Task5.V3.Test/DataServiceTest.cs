using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SavitskyDA.Sprint1.Task5.V3.Lib;

namespace Tyuiu.SavitskyDA.Sprint1.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void VoidExpression()
        {
            //Присвоить целой переменной h третью от конца цифру в записи положительного целого числа k(например, если k = 130985, то h = 9).
            DataService ds = new DataService();
            int k = 130985;

            int res = ds.Calculate(k);

            int wait = 9;
            Assert.AreEqual(wait, res);

        }
    }
}
