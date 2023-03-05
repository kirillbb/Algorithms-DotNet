using Xunit;

namespace Algorithms.Tests
{
    public class BubbleSortTests
    {
        [Fact]
        public void SortsIntArrayInAscendingOrder()
        {
            // Arrange
            int[] arr = { 5, 2, 8, 1, 4 };

            // Act
            BubbleSort.Sort(arr);

            // Assert
            Assert.Equal(new int[] { 1, 2, 4, 5, 8 }, arr);
        }

        [Fact]
        public void SortsEmptyIntArray()
        {
            // Arrange
            int[] arr = { };

            // Act
            BubbleSort.Sort(arr);

            // Assert
            Assert.Equal(new int[] { }, arr);
        }

        [Fact]
        public void SortsSingleIntArray()
        {
            // Arrange
            int[] arr = { 5 };

            // Act
            BubbleSort.Sort(arr);

            // Assert
            Assert.Equal(new int[] { 5 }, arr);
        }
    }
}