using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    [TestClass()]
    public class StringCalculatorTests
    {

        [TestMethod()]
        public void ShouldReturnZeroWhenStringIsEmpty()
        {
            var calculator = new StringCalculator();
            Assert.AreEqual(0, calculator.Calculate(""));
        }


        [TestMethod()]
        public void ShouldReturnANumberWhenItIsASingleNumber()
        {
            var calculator = new StringCalculator();
            Assert.AreEqual(14, calculator.Calculate("14"));
        }

        [TestMethod()]
        public void ShouldReturnSumOfNumbersWhenSeparatedByAComa()
        {
            var calculator = new StringCalculator();
            Assert.AreEqual(14, calculator.Calculate("7,7"));
        }

        [TestMethod()]
        public void ShouldReturnSumOfNumbersWhenSeparatedByEndline()
        {
            var calculator = new StringCalculator();
            Assert.AreEqual(14, calculator.Calculate("7\n7"));
        }

        [DataTestMethod]
        [DataRow("3\n4,5,3\n3", 18)]
        [DataRow("3,4", 7)]
        [DataRow("3\n4", 7)]
        public void ShouldReturnASumOfNumbersWhenSeparatedCorrectly(string arg, int result)
        {
            var calculator = new StringCalculator();
            Assert.AreEqual(result, calculator.Calculate(arg));
        }

        [TestMethod()]
        public void ShouldThrowAnExceptionWhenNumberIsNegative()
        {
            var calculator = new StringCalculator();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => calculator.Calculate("-12"));
        }

        [TestMethod()]
        public void ShouldIgnoreNumbersOverThousand()
        {
            var calculator = new StringCalculator();
            Assert.AreEqual(14, calculator.Calculate("7\n7,1001"));
        }
    }
}