
namespace _4._Reverse_Array_of_Strings
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
                       //Първи начин
            string[] arr = Console.ReadLine()
                .Split(" ")
                .ToArray();
            
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                //string currentLetter = arr[i];
                Console.Write(arr[i]);
                Console.Write($" ");
            }



                       //Втори начин
            
           
        }
    }
}
