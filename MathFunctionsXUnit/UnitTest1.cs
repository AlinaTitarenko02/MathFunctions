using System;
using Xunit;
using MyMath;
namespace Math.Tests
{
    public class MathUnitTest
    {
        // xunit
        [Fact]
        public void Eqauation_WhenAEqualsBPassed_ShouldThrowArgumentException()
        {
            // arrange
            int a = 5;
            int b = 5;
            //assert
            Assert.Throws<ArgumentException>(() => MathFunctions.Equation(a, b));
        }
        //1.1
        [Theory]
        [InlineData(5, 6, 61)]
        [InlineData(4, 6, 28)]
        [InlineData(3, 2, -19)]
        public void Equation_WhenValidABPassed_ShouldCalculateEquation(int a, int b, int expected)
        {
            var result = MathFunctions.Equation(a, b);
            Assert.Equal(expected, result);
        }
        //1.2
        [Theory]
        [InlineData(5, 6, 6, 5)]
        [InlineData(4, 6, 6, 4)]
        [InlineData(3, 2, 2, 3)]
        public void Swap_WhenCalled_ShouldSwapValues(int a, int b, int expectedA, int expectedB)
        {
            MathFunctions.Swap(ref a, ref b);
            Assert.Equal(a, expectedA);
            Assert.Equal(b, expectedB);
        }
        //1.3
        [Fact]
        public void Division_WhenDivideByZero_ShouldThrowArgumentException()
        {
            // arrange
            int a = 5;
            int b = 0;
            int t = 0;
            int d = 0;
            //assert
            Assert.Throws<ArgumentException>(() => MathFunctions.Division(a, b, ref t, ref d));
        }
        //1.4
        [Theory]
        [InlineData(4, -2, 2, 1)]
        [InlineData(6, 4, 1, -0.5)]
        [InlineData(3, 2, -1, -1)]
        public void LinearEquation_WhenValidABCPassed_ShouldCalculateEquation(int a, int b, int c, double expected)
        {
            Assert.Equal(expected, MathFunctions.LinearEquation(a, b, c));
        }
        //1.4
        [Fact]
        public void LinearEquation_WhenAEqualZero_ShouldThrowArgumentException()
        {
            // arrange
            int a = 0;
            int b = 0;
            int c = 5;
            //assert
            Assert.Throws<ArgumentException>(() => MathFunctions.LinearEquation(a, b, c));
        }
        //1.5
        [Fact]
        public void EquationOfStraightLine_WhenX1EqualX2_ShouldThrowArgumentException()
        {
            // arrange
            int x1 = 2;
            int x2 = 2;
            int y1 = 2;
            int y2 = 4;
            //assert
            Assert.Throws<ArgumentException>(() => { MathFunctions.EquationOfStraightLine(x1, y1, x2, y2, out double k, out double b); });
        }
    }
}