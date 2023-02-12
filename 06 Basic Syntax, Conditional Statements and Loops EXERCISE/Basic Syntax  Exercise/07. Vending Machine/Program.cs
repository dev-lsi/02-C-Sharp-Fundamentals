using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double moneyIn = 0;

            while (input != "Start")
            {

                double newMoney = double.Parse(input);
                if (newMoney == 0.1 || newMoney == 0.2 || newMoney == 0.5 || newMoney == 1 || newMoney == 2)
                {
                    moneyIn = moneyIn + newMoney;
                    
                    input = Console.ReadLine();
                    continue;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {newMoney}");
                    input = Console.ReadLine();
                    continue;
                }
            }
            //•	"Nuts" with a price of 2.0
            //•	"Water" with a price of 0.7
            //•	"Crisps" with a price of 1.5
            //•	"Soda" with a price of 0.8
            //•	"Coke" with a price of 1.0
            
            string product = Console.ReadLine();
            
            double productPrice = 0;
            
            while (product != "End")
            {
                if(product== "Nuts" || product == "Water" || product == "Crisps" || product == "Soda" || product == "Coke")
                {
                    switch (product)
                    {
                        case "Nuts":
                            productPrice =2.0;break;
                        case "Water":
                            productPrice =0.7; break;
                        case "Crisps":
                            productPrice =1.5; break;
                        case "Soda":
                            productPrice =0.8; break;
                        case "Coke":
                            productPrice =1.0; break;
                        default:break;
                    } 
                    if(moneyIn >= productPrice)
                    {
                        moneyIn = moneyIn - productPrice;

                        product = product.ToLower();
                        Console.WriteLine($"Purchased {product}");
                        product = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        product = Console.ReadLine();
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                    product = Console.ReadLine();
                    continue;
                }
            }
            Console.WriteLine($"Change: {moneyIn:f2}");

        }
    }
}
