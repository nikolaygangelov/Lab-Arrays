

namespace _7._Equal_Arrays
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int[] arr2 = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int counter = 0;
            int sum = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                sum += arr1[i];
                if (arr1[i] == arr2[i])
                {
                    counter++;
                    if (counter == arr1.Length)
                    {
                        Console.WriteLine($"Arrays are identical. Sum: {sum}");
                    }
                }
                else
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index.");
                    break;
                }
            }
        }
    }
}
