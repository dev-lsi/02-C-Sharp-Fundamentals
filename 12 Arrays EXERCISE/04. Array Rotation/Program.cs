using System;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //int[] resultArr = new int[arr1.Length];

            int rotations = int.Parse(Console.ReadLine());
            //int[] tempArr = new int[rotations];
            int temp = 0;

            for (int i = 0; i < rotations ; i++)
            {
                temp = arr1[0];
                
                for (int j = 1; j < arr1.Length; j++)
                {
                    arr1[j - 1] = arr1[j];
                }
                
                arr1[arr1.Length - 1] = temp;
            }

            Console.WriteLine(string.Join(' ',arr1));

 
        }
    }
}
