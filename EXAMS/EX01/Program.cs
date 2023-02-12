using System;
using System.Text;

namespace _01_decoder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Move {number of letters}");//•	"Move {number of letters}":
            //Console.WriteLine("Moves the first n letters to the back of the string");//o Moves the first n letters to the back of the string
            //Console.WriteLine("Insert {index} {value}");//•	"Insert {index} {value}":
            //Console.WriteLine("Inserts the given value before the given index in the string");//o Inserts the given value before the given index in the string
            //Console.WriteLine("ChangeAll {substring} {replacement}");//•	"ChangeAll {substring} {replacement}":
            //Console.WriteLine("Changes all occurrences of the given substring with the replacement text");//o Changes all occurrences of the given substring with the replacement text

            string inputMessage = Console.ReadLine();
            StringBuilder sb = new StringBuilder(inputMessage);

            while (true)
            {
                string[] command = Console.ReadLine().Split("|",StringSplitOptions.RemoveEmptyEntries);
                if (command[0]=="Decode")
                {
                    break;
                }
                else
                {
                    
                    if (command[0]== "Move")
                    {
                        int n = int.Parse(command[1]);
                        string tring = sb.ToString();
                        tring=tring.Substring(0, n);
                        


                        sb.Append(tring);
                        sb.Remove(0, tring.Length);
                        

                    }
                    else if (command[0] == "Insert")
                    {
                        sb.Insert(int.Parse(command[1]), command[2]);
                    }
                    else if (command[0] == "ChangeAll")
                    {
                        string origin = command[1];
                        string replcement = command[2];
                        sb.Replace(origin, replcement);
                    }

                }
                //Console.WriteLine(sb);
            }
            
            
            Console.WriteLine($"The decrypted message is: {sb.ToString()}");
        }
    }
}
