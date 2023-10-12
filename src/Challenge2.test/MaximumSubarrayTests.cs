using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Challenge2.test;

public class MaximumSubarrayTests
{
        [Fact]
        public void FindMaximumSubarray_ReturnsCorrectResult()
        {
            // Arrange
            int[] numbers = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            const int expectedMaxSum = 6;
    
            // Act
            var maxSum = Program.FindMaximumSubarray(numbers);
    
            // Assert
            Assert.Equal(expectedMaxSum, maxSum);
        }
    
        [Fact]
        public void FindMaximumSubarray_WithEmptyArray_ReturnsZero()
        {
            // Arrange
            var emptyArray = Array.Empty<int>();
    
            // Act
            var maxSum = Program.FindMaximumSubarray(emptyArray);
    
            // Assert
            Assert.Equal(0, maxSum);
        }
}