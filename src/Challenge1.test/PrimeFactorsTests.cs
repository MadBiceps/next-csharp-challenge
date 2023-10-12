using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Challenge1.test;

public class PrimeFactorsTests
{
     [Fact]
        public void PrimeFactors_Of56_ReturnsCorrectFactors()
        {
            // Arrange
            var number = 56;
            var expectedFactors = new List<int> { 2, 2, 2, 7 };
    
            // Act
            var actualFactors = Program.PrimeFactors(number);
    
            // Assert
            Assert.Equal(expectedFactors, actualFactors);
        }
}