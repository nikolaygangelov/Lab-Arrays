﻿
namespace _5._Sum_Even_Numbers
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 == 0)
                {
                    sum += input[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
