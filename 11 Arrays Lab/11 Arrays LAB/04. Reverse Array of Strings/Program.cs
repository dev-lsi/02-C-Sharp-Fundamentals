using System;
using System.Linq;

namespace _04._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArr = Console.ReadLine().Split().ToArray();

            for (int i = 0; i < strArr.Length; i++)
            {
                
                Console.Write($"{strArr[strArr.Length - i - 1]} ");
            }
        }
    }
}


