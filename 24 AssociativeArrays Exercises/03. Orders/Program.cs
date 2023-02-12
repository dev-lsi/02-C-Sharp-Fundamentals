using System;
using System.Collections.Generic;

namespace _03._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double[]> prodPriceQuant =
                new Dictionary<string, double[]>();


            while (true)
            {
                string[] input = Console.ReadLine().Split();
                


                if (input[0] == "buy")
                {
                    break;
                }
                else
                {
                    string currProduct = input[0];
                    double currPrice = double.Parse(input[1]);
                    double currQuantity = double.Parse(input[2]);
                    
                    double[] currPriceQuantity = new double[2] { currPrice, currQuantity };
                    
                    

                    if (!prodPriceQuant.ContainsKey(currProduct))
                    {
                        prodPriceQuant.Add(currProduct, currPriceQuantity);
                    }
                    else
                    {
                        double[] oldPriceQantity = prodPriceQuant[currProduct];
                        oldPriceQantity[0] = currPriceQuantity[0];
                        oldPriceQantity[1] = oldPriceQantity[1] + currPriceQuantity[1];
                        prodPriceQuant[currProduct] = oldPriceQantity;
                        //Console.WriteLine($"{currProduct} : {string.Join(",",prodPriceQuant[currProduct])}");
                    }

                }
            }

            foreach (var (product, priceQantity) in prodPriceQuant)
            {
                double total = priceQantity[0] * priceQantity[1];
                Console.WriteLine($"{product} -> {total:f2}");
            }
        }
    }
}
