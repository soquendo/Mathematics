﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    public class BasicMath
    {
        public double AddNumbers(double num1, double num2)
        {
            return num1 + num2;
        }

        public double SubNumbers(double num1, double num2)
        {
            return num1 - num2;
        }

        public double MulNumbers(double num1, double num2)
        {
            return num1 * num2;
        }

        public double DivNumbers(double num1, double num2)
        {
            return num1 / num2;
        }

        public double listCount(List<double> list)
        {
            return list.Sum();
        }

        public double listSum(List<double> list)
        {
            return list.Sum();
        }
    }
}
