using System;
using Xunit;

namespace Calculator.Test.test
{
    public class CalculatorFailTest
    {
        [Fact]
        public void DivideByZeroException()
        {
            //Arrange
            Calculator calculator = new Calculator();
            float number1 = 5, number2 = 0;

            //Act
            //Assert
            Assert.Throws<DivideByZeroException>(() => calculator.Div(number1, number2));
        }
    }
}