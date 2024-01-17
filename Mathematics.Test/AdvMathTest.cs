using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics.Test
{
    public class AdvMathTest
    {
        [Fact]
        public void CalcAreaTest()
        {
            var math = new AdvMath();
            var result = math.CalcArea(3, 4);
            Assert.True(result == 12, $"{result} is not equal to the number we were thinking");
        }

        [Fact]
        public void CalcAverageTest()
        {
            var math = new AdvMath();
            var list = new List<double> { 1, 2, 3, 4 };
            var result = math.CalcAverage(list);
            Assert.True(result == 2.5, $"{result} is not equal to the average we were thinking");
        }

        [Fact]
        public void CalcValueSquaredTest()
        {
            var math = new AdvMath();
            var result = math.CalcValueSquared(3);
            Assert.True(result == 9, $"{result} is not equal to the value squared we were thinking");
        }

        [Fact]
        public void CalcPyTheoremTest()
        {
            var math = new AdvMath();
            var result = math.CalcPyTheorem(3, 4);
            Assert.True(result == 5, $"{result} is not equal to the hypotenuse we were thinking");
        }
    }
}
