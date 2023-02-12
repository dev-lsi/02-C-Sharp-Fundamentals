using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            int seqLength = 1;
            int leftStartIndex = 0;
            int bestSeqLength = 0;
            int currNUMBER = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                seqLength = FindSequence(arr,i);
                if (seqLength > bestSeqLength)
                {
                    bestSeqLength = seqLength;
                    leftStartIndex = i;
                    currNUMBER = arr[i];
                }
            }

            for (int i = 0; i < bestSeqLength; i++)
            {
                Console.Write($"{currNUMBER} ");
            }
            
        }
        //find sequence
        static int FindSequence(int[] arr, int currIndex)
        {
            int seqLength = 1;
            for (int i = currIndex; i < arr.Length-1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    seqLength++;
                    continue;
                }
                else
                {
                    break;
                }

            }

            return seqLength;
        }
    }
}
