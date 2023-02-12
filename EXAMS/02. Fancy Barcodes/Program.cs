using System;
using System.Text.RegularExpressions;

namespace _02._Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 0; i < n; i++)
            {
                counter++;
                //Console.WriteLine($"counter= {counter}");
                string input = Console.ReadLine();
                
                Regex regex = new Regex(@"(@#+)[A-Z][A-Za-z0-9]{4,}[A-Z](@#+)");
                
                if (!regex.IsMatch(input))
                {
                    Console.WriteLine("Invalid barcode");
                }
                else
                {
                    Match match = regex.Match(input);
                    string wr = match.ToString();
                    char[] chwr = wr.ToCharArray();
                    string result = string.Empty;
                    foreach (var item in chwr)
                    {
                        if (item >=48&&item<=57)
                        {
                            result += item;
                        }
                    }
                    if (result==string.Empty)
                    {
                        Console.WriteLine("Product group: 00");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: {result}");
                    }
                }
            }
        }
    }
}
