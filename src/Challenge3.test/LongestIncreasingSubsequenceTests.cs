using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Challenge3.test;

public class LongestIncreasingSubsequenceTests
{
     [Fact]
        public void TestFindLongestIncreasingSubsequence1()
        {
            int[] numbers = { 10, 22, 9, 33, 21, 50, 41, 60, 80 };
            var expected = new List<int> { 10, 22, 33, 50, 60, 80 };
            var actual = Program.FindLongestIncreasingSubsequence(numbers);
            Assert.Equal(expected, actual);
        }
    
        [Fact]
        public void TestFindLongestIncreasingSubsequence2()
        {
            int[] numbers = { 3, 4, -1, 0, 6, 2, 3 };
            var expected = new List<int> { 3, 4, 6 };
            var actual = Program.FindLongestIncreasingSubsequence(numbers);
            Assert.Equal(expected, actual);
        }
    
        [Fact]
        public void TestFindLongestIncreasingSubsequence3()
        {
            int[] numbers = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            var expected = new List<int> { 10 };
            var actual = Program.FindLongestIncreasingSubsequence(numbers);
            Assert.Equal(expected, actual);
        }
}