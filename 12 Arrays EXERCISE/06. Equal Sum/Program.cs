using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;
            
            for (int i = 0; i < arr.Length; i++)
            {
                leftSum = LeftSum(i,arr);
                rightSum = RightSum(i, arr);
                
                if (leftSum == rightSum)
                {
                    Console.WriteLine( i );
                    return;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("no");
        }
        //Left sum
        static int LeftSum(int currIndex,int[] arr)
        {
            if (currIndex == 0)
            {
                return 0;
            }
            
            int leftSum = 0;

            for (int i = 0; i < currIndex; i++)
            {
                leftSum += arr[i];
            }
            return leftSum;
        }
        //Right sum
        static int RightSum(int currIndex, int[]arr)
        {
            if (currIndex == arr.Length-1)
            {
                return 0;
            }

            int rightSum = 0;

            for (int i = currIndex+1; i < arr.Length; i++)
            {
                rightSum += arr[i];
            }
            return rightSum;
        }
    }
}
