

namespace _2._Print_Numbers_in_Reverse_Order
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            //Първи начин
            //int n = int.Parse(Console.ReadLine());

            //int[] arr = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = n - 1; i >= 0; i--)
            //{
            //    Console.Write($"{arr[i]} ");
            //}
            //Втори начин
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            for (int i = n - 1; i >= 0; i--)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                arr[i] = currentNumber;
            }
            Console.Write(string.Join(' ', arr));
        }
    }
}
