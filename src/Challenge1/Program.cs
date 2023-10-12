// See https://aka.ms/new-console-template for more information

public class Program
{
    public static void Main(string[] args)
    {
        const int number = 56;
        var factors = PrimeFactors(number);

        Console.WriteLine($"Prime factor of {number}: ");
        foreach (var factor in factors)
        {
            Console.Write(factor + " ");
        }
    }
    
    /**
     * Task: Prime factorization:
     * Implement a C# function called PrimeFactors that performs the prime factorization of an integer.
     * The function should return the prime factors in a list.
     */
    public static List<int> PrimeFactors(int number)
    {
        var factors = new List<int>();

        // Implement the algorithm here


        return factors;
    }
}

