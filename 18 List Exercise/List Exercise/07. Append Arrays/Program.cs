using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split("|").ToList();

            List<string> resultList = new List<string>();

            for (int i = 0; i < list.Count; i++)
            {
                resultList.Insert(0,list[i]);
            }

            string result = string.Empty;
           
            for (int i = 0; i < resultList.Count; i++)
            {
                result = result+ " " + resultList[i];
            }

            List<int> final = result.Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
           
            Console.WriteLine(string.Join(" ",final));
        }
    }
}
