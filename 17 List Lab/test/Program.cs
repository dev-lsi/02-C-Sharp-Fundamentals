using System;
using System.Collections.Generic;
using System.Linq;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> myList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List < int > myList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine(string.Join(" ", myList));
            
            myList.Insert(0, 7);
            
            Console.WriteLine(string.Join(" ",myList));
        }
    }
}
