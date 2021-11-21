using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;


namespace _6EPAM.Tests
{
    class OperationsTests
    {
        [TestCase(-10, 5, ExpectedResult = -2)]
        [TestCase(-10, 10, ExpectedResult = -1)]
        [TestCase(5, -2, ExpectedResult = -2)]

        public int DivisionNegativeAndPositiveNumbers(int firstTerm, int secondTerm)
        {
            return Operations.Division(firstTerm, secondTerm);
        }


        [TestCase(10, 5, ExpectedResult = 2)]
        [TestCase(10, 10, ExpectedResult = 1)]
        [TestCase(5, 2, ExpectedResult = 2)]

        public int DivisionTwoPositiveNumbers(int firstTerm, int secondTerm)
        {
            return Operations.Division(firstTerm, secondTerm);
        }


        [TestCase(-10, -5, ExpectedResult = 2)]
        [TestCase(-10, -10, ExpectedResult = 1)]
        [TestCase(-5, -2, ExpectedResult = 2)]

        public int DivisionTwoNegativeNumbers(int firstTerm, int secondTerm)
        {
            return Operations.Division(firstTerm, secondTerm);
        }


        [TestCase(-10, -5, ExpectedResult = -5)]
        [TestCase(-10, -10, ExpectedResult = 0)]
        [TestCase(-5, -2, ExpectedResult = -3)]

        public int MinusTwoNegativeNumbers(int firstTerm, int secondTerm)
        {
            return Operations.Minus(firstTerm, secondTerm);
        }


        [TestCase(10, 5, ExpectedResult = 5)]
        [TestCase(10, 10, ExpectedResult = 0)]
        [TestCase(5, 2, ExpectedResult = 3)]

        public int MinusTwoPositiveNumbers(int firstTerm, int secondTerm)
        {
            return Operations.Minus(firstTerm, secondTerm);
        }


        [TestCase(10, -5, ExpectedResult = 15)]
        [TestCase(10, -10, ExpectedResult = 20)]
        [TestCase(-5, 2, ExpectedResult = -7)]

        public int MinusNegativeAndPositiveNumbers(int firstTerm, int secondTerm)
        {
            return Operations.Minus(firstTerm, secondTerm);
        }


        [TestCase(10, -5, ExpectedResult = -50)]
        [TestCase(10, -10, ExpectedResult = -100)]
        [TestCase(5, -2, ExpectedResult = -10)]

        public int MultiplyNegativeAndPositiveNumbers(int firstTerm, int secondTerm)
        {
            return Operations.Multiply(firstTerm, secondTerm);
        }


        [TestCase(10, -5, ExpectedResult = 5)]
        [TestCase(10, -10, ExpectedResult = 0)]
        [TestCase(5, -2, ExpectedResult = 3)]

        public int PlusNegativeAndPositiveNumbers(int firstTerm, int secondTerm)
        {
            return Operations.Plus(firstTerm, secondTerm);
        }


        [TestCase(int.MaxValue, int.MaxValue)]
        [TestCase(1, int.MaxValue)]
        public void PlusTwoNumbersBiggerThanMaxValue(int firstTerm, int secondTerm)
        {
            Assert.Throws<ArgumentException>(() => Operations.Plus(firstTerm, secondTerm));
        }

        [TestCase(int.MinValue, -1)]
        public void PlusTwoNumbersLessThanMinValue(int firstTerm, int secondTerm)
        {
            Assert.Throws<ArgumentException>(() => Operations.Plus(firstTerm, secondTerm));
        }
        [TestCase(5, 0)]
        public void DivisionByZeroThrowArgumentException(int firstTerm, int secondTerm)
        {
            Assert.Throws<ArgumentException>(() => Operations.Division(firstTerm, secondTerm));
        }

    }
}
