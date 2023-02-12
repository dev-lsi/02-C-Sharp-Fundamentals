using System;
using System.Text;

namespace _01._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            while (true)
            {
                string[] command = Console.ReadLine().Split(">>>");
                if(command[0]== "Generate")
                {
                    break;
                }
                else
                {
                    if (command[0] == "Contains") //"Contains>>>{substring}":
                    {
                        string substring = command[1];
                        if (key.Contains(substring))
                        {
                            Console.WriteLine($"{ key } contains { substring}");
                        }
                        else
                        {
                            Console.WriteLine($"Substring not found!");
                        }
                    }
                    else if (command[0] == "Flip") //"Flip>>>Upper/Lower>>>{startIndex}>>>{endIndex}":
                    {
                        string uperLower = command[1];
                        int startIndex = int.Parse(command[2]);
                        int endIndex = int.Parse(command[3]);
                        string substring = key.Substring(startIndex, endIndex - startIndex);
                        if (uperLower == "Upper")
                        {
                            
                            key = key.Insert(endIndex, substring.ToUpper());
                            key = key.Remove(startIndex, endIndex - startIndex);
                        }
                        else if (uperLower == "Lower")
                        {
                            key = key.Insert(endIndex, substring.ToLower());
                            key = key.Remove(startIndex, endIndex - startIndex);
                            
                        }
                        Console.WriteLine(key);
                    }
                    else if (command[0] == "Slice") //"Slice>>>{startIndex}>>>{endIndex}":
                    {
                        int startIndex = int.Parse(command[1]);
                        int endIndex = int.Parse(command[2]);
                        key = key.Remove(startIndex, endIndex - startIndex);
                        Console.WriteLine(key);
                    }

                }
            }
            Console.WriteLine($"Your activation key is: { key }");

        }
    }
}
