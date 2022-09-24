using Xunit;

namespace Demo.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Calculator_Sum_ReturnSumValue()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.Sum(10, 10);

            //Assert
            Assert.Equal(20, result);
        }

        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(1, 2, 3)]
        [InlineData(1, 3, 4)]
        [InlineData(1, 4, 5)]
        public void Calculator_Sum_ReturnCorrectValue(double v1, double v2, double total)
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.Sum(v1, v2);

            //Assert
            Assert.Equal(total, result);
        }

        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(1, 2, 3)]
        [InlineData(1, 3, 4)]
        [InlineData(1, 4, 5)]
        public void Calculator_Sum_ReturnCorrectValueTest(double v1, double v2, double total)
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.Sum(v1, v2);

            //Assert
            Assert.Equal(total, result);
        }
    }
}