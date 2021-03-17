using NUnit.Framework;
using MyMath;
using System;

namespace TestMathFunctions
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Theory]
        public void EquationOfStraigException()
        {
            int a = 5;
            int b = 5;

            FormatException ex = Assert.Throws<FormatException>(() => { MathFunctions.Equation2(a, b); });
            Assert.That(ex.Message, Is.EqualTo("wrong type"));
        }

        //2.1
        [Theory]
        [TestCase(0, 5, -5)]
        [TestCase(6, 5, 11)]
        [TestCase(4, 4, 16)]
        public void Equation2_WhenValidABPassed_ShouldCalculateEquation(int a, int b, int exception)
        {
            var result = MathFunctions.Equation2(a, b);
            var r = result == exception;

            Assert.True(r, $"{a}, {b}  is true");
        }

        //2.2
        [Theory]
        [TestCase(4, 5, 1)]
        [TestCase(-6, 5, 2)]
        [TestCase(4, -4, 4)]
        public void Equation2_WhenValidXYPassed_ShouldCalculateEquation(int x, int y, int exception)
        {
            var result = MathFunctions.Quarters(x, y);
            var r = result == exception;

            Assert.True(r, $"{x}, {y}  is true");
        }

        //2.3
        [Theory]
        [TestCase(4, 5, 10, new int[] { 4, 5, 10 })]
        [TestCase(-6, 5, 2, new int[] { -6, 2, 5 })]
        [TestCase(4, -4, 2, new int[] { -4, 2, 4 })]
        public void OrderOfAscending_WhenValidXYZPassed_ShouldCalculateEquation(int x, int y, int z, int[] exception)
        {
            int[] result = MathFunctions.OrderOfAscending(x, y, z);
            bool r = result[0] == exception[0]
                && result[1] == exception[1]
                && result[2] == exception[2];

            Assert.True(r, $"{x}, {y}, {z}  is true");
        }

        //2.4
        [Theory]
        public void QuadraticEquationException()
        {
            int a = 3;
            int b = 4;
            int c = 5;
            Assert.That(Assert.Throws<ArgumentOutOfRangeException>(() => MathFunctions.QuadraticEquation(a, b, c)).ParamName, Is.EqualTo("d<0"));
        }

        [Theory]
        [TestCase(1, -2, -3, new double[] { 3, -1 })]
        [TestCase(1, 12, 36, new double[] { -6 })]
        public void QuadraticEquation_WhenValidABCPassed_ShouldCalculateEquation(int a, int b, int c, double[] exception)
        {
            double[] result = MathFunctions.QuadraticEquation(a, b, c);
            bool r = false;
            for (int i = 0; i < result.Length - 1; i++)
            {
                r = result[i] == exception[i];
            }

            Assert.True(r, $"{a}, {b}, {c}  is true");
        }

        //2.5
        [Theory]
        [TestCase(11, "Одиннадцать")]
        [TestCase(22, "Двадцатьпять")]
        [TestCase(16, "Шестнадцать")]
        public void UppercaseThisNumber_WhenValidAPassed_StringofNumbers(int a, string exception)
        {
            string result = MathFunctions.UppercaseThisNumber(a);
            bool r = result[0] == exception[0]
                && result[1] == exception[1];

            Assert.True(r, $"{a},  is true");
        }

        [Theory]
        public void UppercaseThisNumbersException()
        {
            int a = 101;
            Assert.That(Assert.Throws<ArgumentOutOfRangeException>(() => MathFunctions.UppercaseThisNumber(a)).ParamName, Is.EqualTo("over 99"));
        }

        //3.2
        [Theory]
        [TestCase(100, "100 200 300 400 500 600 700 800 900 1000 ")]
        [TestCase(250, "250 500 750 1000 ")]
        public void raisingToPowe_WhenValidAPassed_ShouldCalculate(int a, string exception)
        {
            string result = MathFunctions.raisingToPower(a);
            var r = result == exception;

            Assert.True(r, $"{a},  is true");
        }

        //3.3
        [Theory]
        [TestCase(12, 4)]
        [TestCase(24, 5)]
        [TestCase(25, 5)]
        public void numberOfPosInTsquareLesSA_WhenValidAPassed_StringofNumbers(int a, int exception)
        {
            int result = MathFunctions.numberOfPosInTsquareLesSA(a);
            var r = (result == exception);

            Assert.True(r, $"{a}, zaX|" + $"  is true");
        }

        [Theory]
        public void numberOfPosInTsquareLesSAException()
        {
            int a = 7;
            Assert.That(Assert.Throws<ArgumentOutOfRangeException>(() => MathFunctions.numberOfPosInTsquareLesSA(a)).ParamName, Is.EqualTo("number is not a cube of a number"));
        }

        //3.4
        [Theory]
        [TestCase(12, 6)]
        [TestCase(24, 12)]
        [TestCase(25, 5)]
        public void NCDa_WhenValidAPassed_StringofNumbers(int a, int exception)
        {
            int result = MathFunctions.NCDa(a);
            var r = (result == exception);

            Assert.True(r, $"{a}, zaX|" + $"  is true");
        }

        [Theory]
        public void NCDaException()
        {
            int a = 7;
            Assert.That(Assert.Throws<ArgumentOutOfRangeException>(() => MathFunctions.NCDa(a)).ParamName, Is.EqualTo("the number is only divisible by itself"));
        }


        //3.5
        [Theory]
        [TestCase(11, 3, 7)]
        [TestCase(22, 5, 42)]
        [TestCase(1, 4, 0)]
        public void sumOfNumAtoBdivisibleBy7_ValidABPassed_StringofNumbers(int a, int b, int exception)
        {
            int result = MathFunctions.sumOfNumAtoBdivisibleBy7(a, b);
            var r = (result == exception);

            Assert.True(r, $"{a},{b}  is true");
        }

        

        //3.6
        [Theory]
        [TestCase(3, 6)]
        [TestCase(5, 120)]
        [TestCase(4, 24)]
        public void Factorial_ValidNPassed_StringofNumbers(int n, int exception)
        {
            int result = MathFunctions.Factorial(n);
            var r = (result == exception);

            Assert.True(r, $"{n}  is true");
        }

        [Theory]
        public void FactorialException()
        {
            int n = -4;
            Assert.That(Assert.Throws<ArgumentOutOfRangeException>(() => MathFunctions.Factorial(n)).ParamName, Is.EqualTo("number cannot be negative"));
        }

        //3.7
        [Theory]
        [TestCase(3, 6, 3)]
        [TestCase(20, 120, 20)]
        [TestCase(16, 24, 8)]
        public void NODEvclida_ValidABPassed_StringofMaxNod(int a,int b, int exception)
        {
            int result = MathFunctions.NODEvclida(a, b);
            var r = (result == exception);

            Assert.True(r, $"{a}, {b}  is true");
        }

        [Theory]
        public void NODEvclidaException()
        {
            int a = 0;
            int b = 0;
            Assert.That(Assert.Throws<ArgumentOutOfRangeException>(() => MathFunctions.NODEvclida(a, b)).ParamName, Is.EqualTo("divided by ziro"));
        }

        //3.8
        [Theory]
        [TestCase(27, 3)]
        [TestCase(8, 2)]
        [TestCase(216, 6)]
        public void SqrtN_ValidABPassed_StringofSqrtN(int n, int exception)
        {
            int result = MathFunctions.SqrtN(n);
            var r = (result == exception);

            Assert.True(r, $"{n}  is true");
        }

        [Theory]
        public void SqrtNEvclidaException()
        {
            int n = 3;
            Assert.That(Assert.Throws<ArgumentOutOfRangeException>(() => MathFunctions.SqrtN(n)).ParamName, Is.EqualTo("infinite"));
        }

        //3.9
        [Theory]
        [TestCase(312, 2)]
        [TestCase(21, 1)]
        [TestCase(16, 1)]
        public void CountOddElements_ValidABPassed_StringofCount(int n, int exception)
        {
            int result = MathFunctions.CountOddElements(n);
            var r = (result == exception);

            Assert.True(r, $"{n}  is true");
        }

        
        //3.10
        [Theory]
        [TestCase(312, 213)]
        [TestCase(20, 2)]
        [TestCase(16, 61)]
        public void Mirroy_ValidABPassed_StringofMirroyNum(int n, int exception)
        {
            int result = MathFunctions.Mirroy(n);
            var r = (result == exception);

            Assert.True(r, $"{n}  is true");
        }

        ////3.11
        //[Theory]
        //[TestCase(312, 213)]
        //[TestCase(20, 2)]
        //[TestCase(16, 61)]
        //public void RangeTheSumOfEvenDigitssumodd_ValidABPassed_StringofRangeTheSumOfEvenDigitssumodd(int n, int exception)
        //{
        //    int result = MathFunctions.RangeTheSumOfEvenDigitssumodd(n);
        //    var r = (result == exception);

        //    Assert.True(r, $"{n}  is true");
        //}

        //3.12
        [Theory]
        [TestCase(312, 213, true)]
        [TestCase(20, 2, true)]
        [TestCase(16, 65, false)]
        public void Mirroy_ValidABPassed_StringofMirroyNum(int a, int b, bool exception)
        {
            bool result = MathFunctions.RangeTheSumOfEvenDigitssumodd(a, b);
            var r = (result == exception);

            Assert.True(r, $"{a}, {b} is true");
        }

        //4.1
        [Theory]
        [TestCase(new int[] { 3, -1 }, -1)]
        [TestCase(new int[] { 3, -1, 4, -22}, -22)]
        [TestCase(new int[] { 3, 4, 22, 55 }, 3)]
        public void MinOfArray_ValidArrayPassed_StringofNumbersMin(int[] array, int exception)
        {

            int result = MathFunctions.MinOfArray(array);
            var r = (result == exception);

            Assert.True(r, $"{array}  is true");
        }

        //4.2
        [Theory]
        [TestCase(new int[] { 3, -1 }, 3)]
        [TestCase(new int[] { 3, -1, 4, -22 }, 4)]
        [TestCase(new int[] { 3, 4, 22, 55 }, 55)]
        public void MathFunctions_ValidArrayPassed_StringofNumbersMax(int[] array, int exception)
        {
            int result = MathFunctions.MaxOfArray(array);
            var r = (result == exception);

            Assert.True(r, $"{array}  is true");
        }

        //4.3
        [Theory]
        [TestCase(new int[] { 3, -1 }, 1)]
        [TestCase(new int[] { 3, -1, 4, -22 }, 3)]
        [TestCase(new int[] { 3, 4, 22, 55 }, 0)]
        public void MinIndexOfArray_ValidArrayPassed_StringofNumbersMinNumbers(int[] array, int exception)
        {
            int result = MathFunctions.MinIndexOfArray(array);
            var r = (result == exception);

            Assert.True(r, $"{array}  is true");
        }

        //4.4
        [Theory]
        [TestCase(new int[] { 3, -1 }, 0)]
        [TestCase(new int[] { 3, -1, 4, -22 }, 2)]
        [TestCase(new int[] { 3, 4, 22, 55 }, 3)]
        public void MaxIndexOfArray_ValidArrayPassed_StringofNumbersMaxNumbers(int[] array, int exception)
        {
            int result = MathFunctions.MaxIndexOfArray(array);
            var r = (result == exception);

            Assert.True(r, $"{array}  is true");
        }

        //4.5
        [Theory]
        [TestCase(new int[] { 3, -1 }, -1)]
        [TestCase(new int[] { 3, -1, 4, -22 }, -23)]
        [TestCase(new int[] { 3, 4, 22, 55 }, 59)]
        public void MSumOfOdd_ValidArrayPassed_StringofNumbersMaxNumbers(int[] array, int exception)
        {
            int result = MathFunctions.SumOfOdd(array);
            var r = (result == exception);

            Assert.True(r, $"{array}  is true");
        }

        //4.6
        [Theory]
        [TestCase(new int[] { 3, -1 }, new int[] { -1, 3 })]
        [TestCase(new int[] { 3, -1, 4, -22 }, new int[] { -22, 4, -1, 3 })]
        [TestCase(new int[] { 3, 4, 22, 55 }, new int[] { 55, 22, 4, 3 })]
        public void ReversArray_ValidArrayPassed_StringofReversArray(int[] array, int[] exception)
        {
            bool r = false;
            int[] result = MathFunctions.ReversArray(array);
            for (int i = 0; i < array.Length; i++)
            {
                r = (result[i] == exception[i]);
            }

            Assert.True(r, $"{array}  is true");
        }

        //4.7
        [Theory]
        [TestCase(new int[] { 3, -1 }, 2)]
        [TestCase(new int[] { 3, -1, 4, -22 }, 2)]
        [TestCase(new int[] { 3, 4, 22, 55 }, 2)]
        public void CountOfOddElementArray_ValidArrayPassed_StringofNumbersCountOdd(int[] array, int exception)
        {
            int result = MathFunctions.CountOfOddElementArray(array);
            var r = (result == exception);

            Assert.True(r, $"{array}  is true");
        }

        //4.8
        [Theory]
        [TestCase(new int[] { 3, -1 }, new int[] { -1, 3 })]
        [TestCase(new int[] { 3, -1, 4, -22 }, new int[] { 4, -22, 3, -1 })]
        [TestCase(new int[] { 3, 4, 22, 55 }, new int[] { 22, 55, 3, 4 })]
        public void ReversHalfOfArray_ValidArrayPassed_StringofArray(int[] array, int[] exception)
        {
            bool r = false;
            int[] result = MathFunctions.ReversHalfOfArray(array);
            for (int i = 0; i < array.Length; i++)
            {
                r = (result[i] == exception[i]);
            }

            Assert.True(r, $"{array}  is true");
        }

        ////4.9
        //[Theory]
        //[TestCase(new int[] { 3, -1 }, new int[] { -1, 3 })]
        //[TestCase(new int[] { 3, -1, 4, -22 }, new int[] { -22, -1, 3, 4 })]
        //[TestCase(new int[] { 3, 4, 22, 55 }, new int[] { 3, 4, 22, 55 })]
        //public void SortBubleOfArray_ValidArrayPassed_SortArray(int[] array, int[] exception)
        //{
        //    bool r = false;
        //    int[] result = MathFunctions.SortBubleOfArray(array);
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        r = (result[i] == exception[i]);
        //    }

        //    Assert.True(r, $"{array}  is true");
        //}

        //4.10
        [Theory]
        [TestCase(new int[] { 3, -1 }, new int[] { 3, -1 })]
        [TestCase(new int[] { 3, -1, 4, -22 }, new int[] { 4,3, -1, -22})]
        [TestCase(new int[] { 3, 4, 22, 55 }, new int[] { 55, 22, 4, 3 })]
        public void ReversHalf2_ValidArrayPassed_StringofArray(int[] array, int[] exception)
        {
            bool r = false;
            int[] result = MathFunctions.SortInsertOfArray(array);
            for (int i = 0; i < array.Length; i++)
            {
                r = (result[i] == exception[i]);
            }

            Assert.True(r, $"{array}  is true");
        }

    }

}
  