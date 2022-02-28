using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Moq;
using Implementation;

namespace CalculatorTesting
{
    [TestFixture]

    public class CalculatorTests
    {

        [TestCase("122p","as",false)]
        [TestCase("122", "112",true)]
        [TestCase("122.09", "987", true)]
        [TestCase("122.00o", "887", false)]

        public void Validates_IfTheInputs_AreNumeric(string input1, string input2, bool expected)
        {
            Mock<ILogger> mockObj = new Mock<ILogger>();
            Calculator myObj = new Calculator(mockObj.Object);
            bool actual = myObj.Validate(input1, input2);
            NUnit.Framework.Assert.AreEqual(expected, actual);
        }

        [TestCase(1,1,2)]
        [TestCase(1, -1, 0)]
        [TestCase(0.1, 0.9, 1)]
        [TestCase(1, 0.1, 1.1)]

        public void Adds_TwoNumbers_ReturnsSumOfTheNumbers(double number1,double number2,double expected)
        {
            Mock<ILogger> mockObj = new Mock<ILogger>();
            Calculator myObj = new Calculator(mockObj.Object);
            double actual = myObj.Add(number1, number2);
            NUnit.Framework.Assert.AreEqual(expected, actual);
        }


        [TestCase(1, 1, 0)]
        [TestCase(1, -1, 2)]
        [TestCase(-0.1, 0.9, -1)]
        [TestCase(1, 0.1,0.9)]

        public void Subtracts_SecondNumber_From_FirstNumber_ReturnsSubtraction(double number1, double number2, double expected)
        {
            Mock<ILogger> mockObj = new Mock<ILogger>();
            Calculator myObj = new Calculator(mockObj.Object);
            double actual = myObj.Subtract(number1, number2);
            NUnit.Framework.Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1, 1)]
        [TestCase(1, 0, 0)]
        [TestCase(0.1, 9, 0.9)]
        [TestCase(2, -0.1,-0.2 )]

        public void Multiplies_FirstNumber_With_SecondNumber_ReturnsMultiplication(double number1, double number2, double expected)
        {
            Mock<ILogger> mockObj = new Mock<ILogger>();
            Calculator myObj = new Calculator(mockObj.Object);
            double actual = myObj.Multiply(number1, number2);
            NUnit.Framework.Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 0.1, 10)]
        [TestCase(1, -1, -1)]
        [TestCase(1, 0, -1)]
        [TestCase(0.4, 0.2,2)]

        public void Divides_FirstNumber_With_SecondNumber_ReturnsDivision(double number1, double number2, double expected)
        {
            Mock<ILogger> mockObj = new Mock<ILogger>();
            Calculator myObj = new Calculator(mockObj.Object);
            double actual = myObj.Divide(number1, number2);
            NUnit.Framework.Assert.AreEqual(expected, actual);
        }


    }
}
