using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            //    o   "End"
            //o   "Translate {char} {replacement}"
            //o   "Includes {substring}"
            //o   "Start {substring}"
            //o   "Lowercase"
            //o   "FindIndex {char}"
            //o   "Remove {startIndex} {count}"

            string text = Console.ReadLine();
            List<string> command = new List<string>();
            
            StringBuilder sb = new StringBuilder(text);
            while (true)
            {
                command = Console.ReadLine().Split(" ").ToList();
                
                if (command[0] == "End")
                {
                    break;
                }
                else if (command[0]== "Translate")//Translate {char} {replacement}
                {
                    char ch = char.Parse(command[1]);
                    char replacement = char.Parse(command[2]);
                    sb.Replace(ch, replacement);
                    Console.WriteLine(sb.ToString());

                }
                else if (command[0] == "Includes")//Includes {substring}
                {
                    string substr = command[1];
                    string text1 = sb.ToString();
                    if (text.Contains(substr))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");

                    }
                }
                else if (command[0] == "Start")//Start {substring}
                {
                    string substr = command[1];
                    string text1 = sb.ToString();
                    int index=text1.IndexOf(substr);
                    if (index == 0)
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (command[0] == "Lowercase")
                {
                    string text1 = sb.ToString();
                    text1=text1.ToLower();
                    sb.Clear();
                    sb.Append(text1);
                    Console.WriteLine(sb.ToString());
                }
                else if (command[0] == "FindIndex")//FindIndex {char}
                {
                    char ch = char.Parse(command[1]);
                    string text1 = sb.ToString();
                    int index=text1.LastIndexOf(ch);
                    Console.WriteLine(index);
                }
                else if (command[0] == "Remove")//Remove {startIndex} {count}
                {
                    int startIndex = int.Parse(command[1]);
                    int count = int.Parse(command[2]);
                    string text1 = sb.ToString();
                    text1=text1.Remove(startIndex, count);
                    Console.WriteLine(text1);
                    sb.Clear();
                    sb.Append(text1);
                }
            }
            //Console.WriteLine(sb.ToString());


        }
    }
}
