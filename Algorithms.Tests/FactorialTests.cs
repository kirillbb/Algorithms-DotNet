using Xunit;

namespace Algorithms.Tests
{
    public class FactorialTests
    {
        [Fact]
        public void Factorial_5_Test()
        {
            // Arrange
            int x = 5;

            // Act
            int result = Factorial.Calculate(x);

            // Assert
            Assert.Equal(120, result);
        }

        [Fact]
        public void Factorial_1_Test()
        {
            // Arrange
            int x = 1;

            // Act
            int result = Factorial.Calculate(x);

            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void Factorial_11_Test()
        {
            // Arrange
            int x = 11;

            // Act
            int result = Factorial.Calculate(x);

            // Assert
            Assert.Equal(39_916_800, result);
        }
    }
}
