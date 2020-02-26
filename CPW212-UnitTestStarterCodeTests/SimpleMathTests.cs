﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            double sum = SimpleMath.Add(num1, num2);

            // Assert
            Assert.AreEqual(expectedSum, sum);
        }

        [TestMethod]
        public void Multiply_TwoNumbers_ReturnsProduct()
        {
            // Use a few pairs of values to test the Multiply method
            Assert.Fail();
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