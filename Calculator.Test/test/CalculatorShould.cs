using Xunit;

namespace Calculator.Test.test
{
    public class CalculatorShould
    {
        [Fact]
        public void Add()
        {
            //Arrange
            Calculator calculator = new Calculator();
            float number1 = 15, number2 = 25;

            //Act
            float result = calculator.Add(number1, number2);

            //Assert
            Assert.Equal(40, result);
        }


        [Fact]
        public void Sub()
        {
            //Arrange
            Calculator calculator = new Calculator();
            float number1 = 15, number2 = 25;

            //Act
            float result = calculator.Sub(number1, number2);

            //Assert
            Assert.Equal(-10, result);

        }

        [Theory]
        [InlineData(5, 9, 45)]
        [InlineData(9, 9, 81)]
        [InlineData(5, -9, -45)]
        [InlineData(-5, -9, 45)]
        [InlineData(10, 0, 0)]
        public void Mul(int number1, int number2, int expected)
        {
            //Arrange
            Calculator calculator = new Calculator();
            //Act
            float result = calculator.Mul(number1, number2);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(5, 10, 2)]
        [InlineData(17, 51, 3)]
        [InlineData(2, 91, 45.5)]
        [InlineData(9, 99, 11)]
        [InlineData(3, 45, 15)]
        public void Div(float number1, float number2, float expected)
        {
            //Arrange
            Calculator calculator = new Calculator();
            //Act
            float result = calculator.Div(number2, number1);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}