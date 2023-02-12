using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace TEST01
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Regex regex = new Regex(@">>([A-Z][a-z]*[A-Za-z_]*)<<([0-9]+[.0-9]*)!([0-9]+)");
            int counter = 1;
            double sum = 0;
            List<string> result = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Purchase")
                {
                    break;
                }
                else
                {
                   
                    if (regex.IsMatch(input))
                    {
                        //if (counter == 1)
                        //{
                        //    Console.WriteLine("Bought furniture:");
                        //    counter++;
                        //}
                        
                        Match match = regex.Match(input);
                        //Console.WriteLine(match.Value);
                        //Console.WriteLine(match.Groups[1].Value);
                        result.Add(match.Groups[1].Value);

                        //Console.WriteLine(match.Groups[2].Value);
                        //Console.WriteLine(match.Groups[3].Value);

                        sum = sum + (double.Parse(match.Groups[2].Value) * double.Parse(match.Groups[3].Value));
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            Console.WriteLine("Bought furniture:");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total money spend: {sum:f2}");
        }
    }
}
