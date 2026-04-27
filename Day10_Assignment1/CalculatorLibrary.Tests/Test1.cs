using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLibrary;

namespace CalculatorLibrary.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Add_ShouldReturnCorrectResult()
        {
            var calc = new Calculator();
            double result = calc.Add(2, 3);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Subtract_ShouldReturnCorrectResult()
        {
            var calc = new Calculator();
            double result = calc.Subtract(5, 3);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Multiply_ShouldReturnCorrectResult()
        {
            var calc = new Calculator();
            double result = calc.Multiply(2, 6);
            Assert.AreEqual(12, result);
        }

        [TestMethod]
        public void Divide_ShouldReturnCorrectResult()
        {
            var calc = new Calculator();
            double result = calc.Divide(10, 2);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Divide_ByZero_ShouldThrowException()
        {
            var calc = new Calculator();

            try
            {
                calc.Divide(10, 0);
                Assert.Fail("Expected exception not thrown");
            }
            catch (DivideByZeroException)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void Subtract_WithZero_ShouldReturnSameValue()
        {
            var calc = new Calculator();
            double result = calc.Subtract(5, 0);
            Assert.AreEqual(5, result);
        }
    }
}