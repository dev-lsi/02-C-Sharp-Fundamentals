using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int DNAlength = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int[] currArr = new int[DNAlength];
            int[] bestDNA = new int[2] { 0, 0 };
            int[] currDNA = new int[2];
            int counter = 0;
            int bestDNACounter = 1;
            int[] BESTDNASUPER = new int[DNAlength];

            while (input != "Clone them!")
            {
                currArr = input.Split(" ").Select(int.Parse).ToArray();
                counter++;
                currDNA = FindMaxSeqLength(currArr);

                if (currDNA[0] > bestDNA[0])
                {
                    BESTDNASUPER = currArr;
                    bestDNA = currDNA;
                    bestDNACounter = counter;
                }
                else if (currDNA[0] == bestDNA[0])
                {
                    if (currDNA[1] < bestDNA[1])
                    {
                        BESTDNASUPER = currArr;
                        bestDNA = currDNA;
                        bestDNACounter = counter;
                    }
                }

                input = Console.ReadLine();
            }
            int sum = 0;
            for (int i = 0; i < BESTDNASUPER.Length; i++)
            {
                if (BESTDNASUPER[i] == 1)
                {
                    sum++;
                }
            }

            Console.WriteLine($"Best DNA sample {bestDNACounter} with sum: {sum}.");
            Console.WriteLine(string.Join(" ", BESTDNASUPER));

        }



        static int[] FindMaxSeqLength(int[] arr)
        {
            int currLength = 0;
            int maxLength = 0;
            int currIndex = 0;
            int currMaxIndex = 0;
            bool hasOnes = false;
            int counter = 0;
            // int[] output = { maxLength, currMaxIndex };  // [maxLength|startIndex]

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == 1)
                {
                    counter = i;
                    currIndex = i;

                    while (arr[counter] == 1)
                    {
                         
                        currLength++;

                    }
                    if (currLength > maxLength)
                    {
                        maxLength = currLength;
                        currMaxIndex = i;
                    }
                    currLength = 0;
                    continue;
                }
                else
                {
                    continue;
                }
            }

            int[] output = { maxLength, currMaxIndex };

            return
            output;   // [maxLength|startIndex]
        }
    }
}
