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
        public void Multiply_TwoNumbers_ReturnsProduct()
        {
            // Arrange
            double pair1Num1 = 2;
            double pair1Num2 = 5;

            double pair2Num1 = -2;
            double pair2Num2 = 5;

            double pair3Num1 = 4.5;
            double pair3Num2 = 2;

            double pair4Num1 = -0;
            double pair4Num2 = 0;


            // Expected answers
            double pair1ExpectedProduct = pair1Num1 * pair1Num2;
            double pair2ExpectedProduct = pair2Num1 * pair2Num2;
            double pair3ExpectedProduct = pair3Num1 * pair3Num2;
            double pair4ExpectedProduct = pair4Num1 * pair4Num2;

            // Act
            // Method answers
            double pair1MethodProduct = SimpleMath.Multiply(pair1Num1, pair1Num2);
            double pair2MethodProduct = SimpleMath.Multiply(pair2Num1, pair2Num2);
            double pair3MethodProduct = SimpleMath.Multiply(pair3Num1, pair3Num2);
            double pair4MethodProduct = SimpleMath.Multiply(pair4Num1, pair4Num2);

            // Assert
            Assert.AreEqual(pair1ExpectedProduct, pair1MethodProduct);
            Assert.AreEqual(pair2ExpectedProduct, pair2MethodProduct);
            Assert.AreEqual(pair3ExpectedProduct, pair3MethodProduct);
            Assert.AreEqual(pair4ExpectedProduct, pair4MethodProduct);
        }

        [TestMethod]
        public void Divide_DenominatorZero_ThrowsArgumentException()
        {
            // Divide by zero should throw an argument exception with a message
            // "Denominator cannot be zero"
            Assert.Fail();
        }

        // TODO: Test Divide method with two valid numbers

        // TODO: Test subtract method with two valid numbers
    }
}