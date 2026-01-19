using System;

namespace GCD
{
    public class Program
    {
        // Recursive method to calculate GCD using Euclid's Algorithm
        static int GCD(int a, int b)
        {
            // Find the larger and smaller values between a and b
            int larger = a > b ? a : b;
            int smaller = a < b ? a : b;

            // Base condition: if smaller becomes 0, larger is the GCD
            if (smaller == 0)
            {
                return larger;
            }
            else
            {
                // Recursive call with (smaller, remainder of larger/smaller)
                return GCD(smaller, larger % smaller);
            }
        }

        static void Main()
        {
            // Read first number
            Console.WriteLine("Enter a: ");
            int a = int.Parse(Console.ReadLine()!);

            // Read second number
            Console.WriteLine("Enter b: ");
            int b = int.Parse(Console.ReadLine()!);

            // Call GCD method
            int gcd = GCD(a, b);

            // Display the result
            Console.WriteLine("GCD is: " + gcd);
        }
    }
}
