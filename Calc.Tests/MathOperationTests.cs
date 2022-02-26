using System;
using Xunit;
using Calc;
using System.Collections.Generic;

namespace Calc.Tests
{
    public class MathOperationTests
    {
        [Fact]
        public void AdditionTest_Positive_Number()
        {
            double expected = 19;            
            var cal = new Calculate();
            List<double> inputNumber = new List<double>();
            inputNumber.Add(4);
            inputNumber.Add(3);
            inputNumber.Add(5);
            inputNumber.Add(7);
            double result = cal.Addition(inputNumber);
            Assert.Equal(expected, result);
        }
        
        [Fact]
        public void AdditionTest_Positive_Negative_Number()
        {
            double expected = 3;
            var cal = new Calculate();
            List<double> inputNumber = new List<double>();
            inputNumber.Add(4);
            inputNumber.Add(-3);
            inputNumber.Add(-5);
            inputNumber.Add(7);
            double result = cal.Addition(inputNumber);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void AdditionTest_Positive_Negative_Decimal_Number()
        {
            double expected = 11;
            var cal = new Calculate();
            List<double> inputNumber = new List<double>();
            inputNumber.Add(4);
            inputNumber.Add(4.6);
            inputNumber.Add(-5);
            inputNumber.Add(7.4);
            double result = cal.Addition(inputNumber);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void SubtractionTest_Positive_Number()
        {
            double expected = -19;
            var cal = new Calculate();
            List<double> inputNumber = new List<double>();
            inputNumber.Add(4);
            inputNumber.Add(3);
            inputNumber.Add(5);
            inputNumber.Add(7);
            double result = cal.subtraction(inputNumber);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void SubtractionTest_Positive_Negative_Number()
        {
            double expected = -3;
            var cal = new Calculate();
            List<double> inputNumber = new List<double>();
            inputNumber.Add(4);
            inputNumber.Add(-3);
            inputNumber.Add(-5);
            inputNumber.Add(7);
            double result = cal.subtraction(inputNumber);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void SubtractionTest_Positive_Negative_Decimal_Number()
        {
            double expected = -11;
            var cal = new Calculate();
            List<double> inputNumber = new List<double>();
            inputNumber.Add(4);
            inputNumber.Add(4.6);
            inputNumber.Add(-5);
            inputNumber.Add(7.4);
            double result = cal.subtraction(inputNumber);
            Assert.Equal(expected, result);
        }


        [Fact]
        public void MultiplicationTest_Positive_Number()
        {
            double expected = 20;
            var cal = new Calculate();            
            double result = cal.Multiplication(4,5);
            Assert.Equal(expected, result);
        }
        [Fact]
        public void MultiplicationTest_Positive_Negative_Number()
        {
            double expected = -20;
            var cal = new Calculate();
            double result = cal.Multiplication(4, -5);
            Assert.Equal(expected, result);
        }
        [Fact]
        public void MultiplicationTest_Positive_DecimalNumber()
        {
            double expected = 18;
            var cal = new Calculate();
            double result = cal.Multiplication(4, 4.5);
            Assert.Equal(expected, result);
        }


        [Fact]
        public void DivisionTest_Positive_Number()
        {
            double expected = 2;
            var cal = new Calculate();
            double result = cal.Division(4, 2);
            Assert.Equal(expected, result);
        }
       
        [Fact]
        public void divisionTest_Positive_DecimalNumber()
        {
            double expected = 1.8181818181818181;
            var cal = new Calculate();
            double result = cal.Division(4, 2.2);
            Assert.Equal(expected, result);
        }

    }
}
