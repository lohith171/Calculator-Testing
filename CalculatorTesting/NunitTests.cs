using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Moq;

namespace CalculatorTesting
{
    [TestFixture]

    public class CalculatorTests
    {

        [TestCase("122p","as",false)]
        [TestCase("122", "112",true)]
        [TestCase("122.09", "987", true)]
        [TestCase("122.00o", "887", false)]

        public void Validates_IfTheInputs_AreNumeric(string Input1, string Input2, bool Expected)
        {
            Mock<ILogger> MockObj = new Mock<ILogger>();
            Calculator MyObj = new Calculator(MockObj.Object);
            bool Actual = MyObj.Validate(Input1, Input2);
            NUnit.Framework.Assert.AreEqual(Expected, Actual);
        }

        [TestCase(1,1,2)]
        [TestCase(1, -1, 0)]
        [TestCase(0.1, 0.9, 1)]
        [TestCase(1, 0.1, 1.1)]

        public void Adds_TwoNumbers_ReturnsSumOfTheNumbers(double number1,double number2,double Expected)
        {
            Mock<ILogger> MockObj = new Mock<ILogger>();
            Calculator MyObj = new Calculator(MockObj.Object);
            double Actual = MyObj.Add(number1, number2);
            NUnit.Framework.Assert.AreEqual(Expected, Actual);
        }


        [TestCase(1, 1, 0)]
        [TestCase(1, -1, 2)]
        [TestCase(-0.1, 0.9, -1)]
        [TestCase(1, 0.1,0.9)]

        public void Subtracts_SecondNumber_From_FirstNumber_ReturnsSubtraction(double number1, double number2, double Expected)
        {
            Mock<ILogger> MockObj = new Mock<ILogger>();
            Calculator MyObj = new Calculator(MockObj.Object);
            double Actual = MyObj.Subtract(number1, number2);
            NUnit.Framework.Assert.AreEqual(Expected, Actual);
        }

        [TestCase(1, 1, 1)]
        [TestCase(1, 0, 0)]
        [TestCase(0.1, 9, 0.9)]
        [TestCase(2, -0.1,-0.2 )]

        public void Multiplies_FirstNumber_With_SecondNumber_ReturnsMultiplication(double number1, double number2, double Expected)
        {
            Mock<ILogger> MockObj = new Mock<ILogger>();
            Calculator MyObj = new Calculator(MockObj.Object);
            double Actual = MyObj.Multiply(number1, number2);
            NUnit.Framework.Assert.AreEqual(Expected, Actual);
        }

        [TestCase(1, 0.1, 10)]
        [TestCase(1, -1, -1)]
        [TestCase(1, 0, -1)]
        [TestCase(0.4, 0.2,2)]

        public void Divides_FirstNumber_With_SecondNumber_ReturnsDivision(double number1, double number2, double Expected)
        {
            Mock<ILogger> MockObj = new Mock<ILogger>();
            Calculator MyObj = new Calculator(MockObj.Object);
            double Actual = MyObj.Divide(number1, number2);
            NUnit.Framework.Assert.AreEqual(Expected, Actual);
        }


    }
}
