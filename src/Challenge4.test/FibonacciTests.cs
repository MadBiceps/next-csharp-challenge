namespace Challenge4.test;

public class FibonacciTests
{
     [Fact]
        public void TestFibonacciZero()
        {
            Assert.Equal(0, Program.Fibonacci(0));
        }
    
        [Fact]
        public void TestFibonacciOne()
        {
            Assert.Equal(1, Program.Fibonacci(1));
        }
    
        [Fact]
        public void TestFibonacciTwo()
        {
            Assert.Equal(1, Program.Fibonacci(2));
        }
    
        [Fact]
        public void TestFibonacciFive()
        {
            Assert.Equal(5, Program.Fibonacci(5));
        }
    
        [Fact]
        public void TestFibonacciTen()
        {
            Assert.Equal(55, Program.Fibonacci(10));
        }
}