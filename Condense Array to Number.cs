

namespace _8._Condense_Array_to_Number
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine()//3
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            //2
            while (arr1.Length > 1)
            {
                int[] arr2 = new int[arr1.Length - 1];
                for (int i = 0; i < arr1.Length - 1; i++)
                {
                    arr2[i] = arr1[i] + arr1[i + 1];
                }
                arr1 = arr2;
            }
            Console.WriteLine(arr1[0]);
        }
    }
}
