using System;
using System.Linq;
using System.Text;

namespace _01._Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string password = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            
            while (true)
            {
                string[] command = Console.ReadLine().Split(" ");

                if (command[0] == "Done")
                {
                    break;
                }
                else
                {
                    if (command[0] == "TakeOdd")
                    {
                        
                        sb.Clear();
                        for (int i = 0; i < password.Length; i++)
                        {
                            if ((i == 1 || i % 2 != 0) && i != 0)
                            {
                                sb.Append(password[i]);
                               
                            }
                        }
                        password = sb.ToString();
                        Console.WriteLine(sb.ToString());

                    }
                    else if (command[0] == "Cut") //"Cut {index} {length}"
                    {
                        int index = int.Parse(command[1]);
                        int len = int.Parse(command[2]);
                        string substring = password.Substring(index, len);
                        password = password.Remove(index, len);
                        Console.WriteLine(password);
                        
                    }
                    else if(command[0] == "Substitute") //"Substitute {substring} {substitute}"
                    {
                        string substring = command[1];
                        string replace = command[2];
                        if (password.Contains(substring))
                        {
                            sb.Clear();
                            sb.Append(password);
                            sb.Replace(substring, replace);
                            password = sb.ToString();
                            Console.WriteLine(password);
                        }
                        else
                        {
                            Console.WriteLine("Nothing to replace!");
                        }
                    }
                }
            }
            
            Console.WriteLine($"Your password is: {password}");// "Your password is: {password}"

            //•	"TakeOdd"
            //o Takes only the characters at odd indices and concatenates them to obtain the
            //new raw password and then prints it.
            //•	"Cut {index} {length}"
            //o Gets the substring with the given length starting from the given index from the password and removes its first occurrence, then prints the password on the console.
            //o The given index and the length will always be valid.
            //•	"Substitute {substring} {substitute}"
            //o If the raw password contains the given substring, replaces all of its occurrences with the substitute text given and prints the result.
            //o If it doesn't, prints "Nothing to replace!".

        }
    }
}
