using Xunit;

namespace Algorithms.Tests
{
    public class BinarySearchTests
    {
        [Fact]
        public void TestBinarySearch_FoundValue()
        {
            // Arrange
            int[] arr = { 1, 3, 5, 7, 9 };
            int x = 5;

            // Act
            int result = BinarySearch.Search(arr, x);

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void TestBinarySearch_FoundValueAtEnd()
        {
            // Arrange
            int[] arr = { 1, 3, 5, 7, 9, 11 };
            int x = 11;

            // Act
            int result = BinarySearch.Search(arr, x);

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void TestBinarySearch_ValueNotFound()
        {
            // Arrange
            int[] arr = { 1, 3, 5, 7, 9 };
            int x = 4;

            // Act
            int result = BinarySearch.Search(arr, x);

            // Assert
            Assert.Equal(-1, result);
        }

        [Fact]
        public void TestBinarySearch_EmptyArray()
        {
            // Arrange
            int[] arr = { };
            int x = 5;

            // Act
            int result = BinarySearch.Search(arr, x);

            // Assert
            Assert.Equal(-1, result);
        }
    }
}