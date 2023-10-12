// See https://aka.ms/new-console-template for more information
public class Program
{
    public static int FindMaximumSubarray(int[] arr)
    {
        // Implement Kadane's algorithm here to find the maximum subarray
        return 0; // Dummy return value, replace it with the maximum sum
    }

    public static void Main(string[] args)
    {
        int[] numbers = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };

        var maxSum = FindMaximumSubarray(numbers);

        Console.WriteLine($"The maximum Subarray-Sum is {maxSum}");
    }
}
