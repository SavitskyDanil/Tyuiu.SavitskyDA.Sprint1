﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SavitskyDA.Sprint1.Task7.V23.Lib
{
    public class DataService : ISprint1Task7V23
    {
        public double Calculate(double x, double y)
        {
            double res = x - Math.Pow(10, Math.Sin(x)) + (20 * Math.Pow(x, 2)) / (3 * Math.Pow(x, 3)) + Math.Cos((Math.Pow(x, 2) - y));
            return Math.Round(res, 3);
        }
    }
}
