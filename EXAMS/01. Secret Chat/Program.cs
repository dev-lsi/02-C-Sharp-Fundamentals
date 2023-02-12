using System;
using System.Text;

namespace _01._Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            string concealed = Console.ReadLine();
            string message = string.Empty;
            StringBuilder sb = new StringBuilder(concealed);

            while (true)
            {
                string commandString = Console.ReadLine();
                if (commandString == "Reveal")
                {
                    break;
                }
                else
                {
                    string[] command = commandString.Split(":|:");
                    //"InsertSpace:|:{index}":inserts space at the given index
                    if (command[0]=="InsertSpace")
                    {
                        sb.Insert(int.Parse(command[1]), ' ');
                        Console.WriteLine(sb.ToString());
                    }
                    else if (command[0]=="Reverse")
                    {
                        string substring = command[1];
                        string mess = sb.ToString();
                        
                        if (!mess.Contains(substring))
                        {
                            Console.WriteLine("error");
                        }
                        else
                        {
                            int startIndex=mess.IndexOf(substring);
                            mess=mess.Remove(startIndex, substring.Length);
                            
                            StringBuilder reverseSB = new StringBuilder();
                            for (int i = substring.Length - 1; i >= 0; i--)
                            {
                                reverseSB.Append(substring[i]);
                            }
                            sb = new StringBuilder(mess);
                            sb.Append(reverseSB.ToString());
                            Console.WriteLine(sb.ToString());
                        }
                    }
                    else if (command[0] == "ChangeAll")//ChangeAll:|:{substring}:|:{replacement}
                    {
                        string substring = command[1];
                        string replacement = command[2];
                        sb.Replace(substring, replacement);
                        Console.WriteLine(sb.ToString());
                    }
                }
            }
            Console.WriteLine($"You have a new text message: {sb.ToString()}");
        }
    }
}
