using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //int[] condensedArr = new int[arr.Length - 1];
            while(arr.Length>1)
            {

                int[] condensedArr = new int[arr.Length - 1];

                for (int i = 0; i < arr.Length-1; i++)
                {
                        condensedArr[i] = arr[i] + arr[i + 1];
                }
                
               
                arr = condensedArr;

            }
            Console.WriteLine(arr[0]);
            




        }
    }
}
