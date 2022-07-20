using Xunit;
using Moq;

namespace Calculator.Test.test
{
    public class Mocking_Calculator
    {
        [Fact]
        public void Add_Function_In_Fibo()
        {
            //Arrange
            Mock<ICalculator> mock = new Mock<ICalculator>();
            int expected = 8, result;

            mock.Setup(
                c => c.Add(It.IsAny<int>(), It.IsAny<int>()))
                .Returns((int a, int b) => a + b);

            Series serie = new Series(mock.Object);

            //Act
            result = serie.Fibonacci(6);

            //Assert
            Assert.Equal(expected, result);

        }

        [Fact]
        public void Mul_Function_In_Facto()
        {
            //Arrange
            Mock<ICalculator> mock = new Mock<ICalculator>();
            int expected = 40320, result;

            mock.Setup(
                c => c.Mul(It.IsAny<int>(), It.IsAny<int>()))
                .Returns((int a, int b) => a * b);

            Series serie = new Series(mock.Object);

            //Act
            result = serie.Factorial(8);

            //Assert
            Assert.Equal(expected, result);

        }


    }
}
