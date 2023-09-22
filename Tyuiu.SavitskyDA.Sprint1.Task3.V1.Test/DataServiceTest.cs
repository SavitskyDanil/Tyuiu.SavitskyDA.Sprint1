using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SavitskyDA.Sprint1.Task3.V1.Lib;

namespace Tyuiu.SavitskyDA.Sprint1.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExspression()
        {
            //Объявите необходимые переменные и напишите программу вычисления объема цилиндра, предполагающий ввод исходных данных.
            DataService ds = new DataService();
            double r = 5;
            double h = 11;
            double wait = 863.5;
            var res = ds.CylinderVolume(r, h);
            Assert.AreEqual(wait, res);
        }
    }
}
