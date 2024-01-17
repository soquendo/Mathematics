using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    public class AdvMath
    {
        public double CalcArea(double height, double width)
        {
            return height * width;
        }

        public double CalcAverage(List<double> numbers)
        {
            return numbers.Average();
        }

        public double CalcValueSquared(double value)
        {
            return value * value;
        }

        public double CalcPyTheorem(double a, double b)
        {
            return Math.Sqrt(a * a + b * b);
        }
    }
}
