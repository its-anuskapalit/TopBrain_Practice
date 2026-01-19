using System;
namespace SumOfPositive
{
    public class Program
    {
        // Method to calculate the sum of positive numbers in the array
        // Stops execution if 0 is encountered
        // Skips negative numbers
        public static int SumOfPositive(int[] arr)
        {
            int sum = 0; // Variable to store sum of positive numbers
            // Loop through each element of the array
            for (int i = 0; i < arr.Length; i++)
            {
                // If element is 0, stop processing further elements
                if (arr[i] == 0)
                {
                    break;
                }
                // If element is negative, skip it and continue to next iteration
                else if (arr[i] < 0)
                {
                    continue;
                }
                // If element is positive, add it to sum
                else
                {
                    sum += arr[i];
                }
            }
            // Return the final calculated sum
            return sum;
        }
        static void Main()
        {
            // Ask user for the size of the array
            Console.WriteLine("Enter size of array");
            int size = int.Parse(Console.ReadLine());

            // Declare array with given size
            int[] arr = new int[size];

            // Take array elements from the user
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter array element for {i}th position");
                arr[i] = int.Parse(Console.ReadLine());
            }
            // Call method to calculate sum of positive numbers
            int sum = SumOfPositive(arr);
            // Display the result
            Console.WriteLine("The sum is " + sum);
        }
    }
}
