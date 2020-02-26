using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPW212_UnitTestStarterCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW212_UnitTestStarterCode.Tests
{
    [TestClass()]
    public class SimpleMathTests
    {
        [TestMethod()]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Add_TwoNumbers_ReturnsSum(double num1, double num2)
        {
            // Arrange
            double expectedSum = num1 + num2;

            // Act
            double methodSum = SimpleMath.Add(num1, num2);

            // Assert
            Assert.AreEqual(expectedSum, methodSum);
        }

        [TestMethod]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Multiply_TwoNumbers_ReturnsProduct(double num1, double num2)
        {
            // Arrange
            // Expected answer
            double expectedProduct = num1 * num2;

            // Act
            double methodProduct = SimpleMath.Multiply(num1, num2);

            // Assert
            Assert.AreEqual(expectedProduct, methodProduct);
        }

        [TestMethod]
        public void Divide_DenominatorZero_ThrowsArgumentException()
        {
            // Arrange
            double num1 = 2;
            double num2 = 0;

            // Act => Assert

            Assert.ThrowsException<ArgumentException>(() => SimpleMath.Divide(num1, num2));
        }
   
        [TestMethod()]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        public void Divide_TwoValidNumbers_ReturnsQuotient(double num1, double num2)
        {
            // Arrange
            double expectedSum = num1 / num2;

            // Act
            double methodSum = SimpleMath.Divide(num1, num2);

            // Assert
            Assert.AreEqual(expectedSum, methodSum);
        }

        [TestMethod()]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Subtract_TwoValidNumbers_ReturnsDifference(double num1, double num2)
        {
            // Arrange
            double expectedSum = num1 - num2;

            // Act
            double methodSum = SimpleMath.Subtract(num1, num2);

            // Assert
            Assert.AreEqual(expectedSum, methodSum);
        }
    }
}