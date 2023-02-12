using System;
using System.Linq;

namespace _10._LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int size = int.Parse(Console.ReadLine());
            int[] initialState = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr = new int[size];
            string[] command = new string[3];
            int[] resultArr = new int[size];
            //fill the arr on start
            for (int i = 0; i < initialState.Length; i++)
            {
                arr[initialState[i]] = 1;
                Console.WriteLine(string.Join("...",arr));
            }
            //take comands
            string strInput = Console.ReadLine();
            
            while (strInput != "end")
            {
                //taking computing the input
                string[] commandArr = strInput.Split().ToArray();
                long startPoss = int.Parse(commandArr[0]);
                string direction = commandArr[1];
                long distance = int.Parse(commandArr[2]);
                long endPoss=0;
                Console.WriteLine($"{startPoss}->{direction}->{distance}");
                //distance == 0 ?????
                if (distance == 0)
                {
                    strInput = Console.ReadLine();
                    continue;
                }
                if (direction == "right")
                {
                    endPoss = startPoss + distance;
                }
                else
                {
                    endPoss = startPoss - distance;
                }
                // if arr start is ot of range
                if (startPoss < 0 || startPoss > arr.Length - 1)
                {
                    strInput = Console.ReadLine();
                    continue;
                }
                // if start poss is empty
                if (arr[startPoss] == 0)
                {
                    strInput = Console.ReadLine();
                    continue;
                }
                
                //check if result is inside
                while (true)
                {
                    
                    if (endPoss < 0 || endPoss > arr.Length - 1)
                    {
                        arr[startPoss] = 0;
                        Console.WriteLine(string.Join("-",arr));
                        strInput = Console.ReadLine();
                        break;
                    }
                    else
                    {
                        if (arr[endPoss] == 1)
                        {
                            endPoss = endPoss+distance;
                            continue;
                        }
                        else
                        {
                            arr[endPoss] = 1;
                            arr[startPoss] = 0;
                            Console.WriteLine(string.Join("-", arr));
                            strInput = Console.ReadLine();
                            break;
                        }
                    }
                    
                }
                
                
            }
            
            //output
            Console.WriteLine(string.Join(" ",arr));
           
        }
    }
}
