using Xunit;

namespace Algorithms.Tests
{
    public class SelectionSortTests
    {
        [Fact]
        public void SortsArrayInAscendingOrder()
        {
            // Arrange
            int[] arr = { 3, 5, 1, 4, 2 };

            // Act
            SelectionSort.Sort(arr);

            // Assert
            Assert.Equal(new int[] { 1, 2, 3, 4, 5 }, arr);
        }

        [Fact]
        public void SortsArrayWithDuplicateValues()
        {
            // Arrange
            int[] arr = { 3, 5, 1, 4, 2, 5 };

            // Act
            SelectionSort.Sort(arr);

            // Assert
            Assert.Equal(new int[] { 1, 2, 3, 4, 5, 5 }, arr);
        }

        [Fact]
        public void SortsArrayWithNegativeValues()
        {
            // Arrange
            int[] arr = { -3, 5, -1, 4, 0, 2 };

            // Act
            SelectionSort.Sort(arr);

            // Assert
            Assert.Equal(new int[] { -3, -1, 0, 2, 4, 5 }, arr);
        }
    }
}