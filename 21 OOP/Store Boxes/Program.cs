using System;
using System.Collections.Generic;
using System.Linq;

namespace Store_Boxes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Boxes> listOfBoxes = new List<Boxes>();

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                
                //"{Serial Number} {Item Name} {Item Quantity} {itemPrice}"
                if (input[0] == "end")
                {
                    break;
                }
                else
                {
                    string serialNumber = input[0];
                    string itemName = input[1];
                    int itemQuantity = int.Parse(input[2]);
                    double itemPrice = double.Parse(input[3]);
                    double priceForABox = itemQuantity * itemPrice;

                    Item newItem = new Item();
                    newItem.Price = itemPrice;
                    newItem.Name = itemName;

                    Boxes newBox = new Boxes();
                    newBox.item = newItem;
                    newBox.ItemQuantity = itemQuantity;
                    newBox.SerialNumber = serialNumber;
                    newBox.PriceForABox = priceForABox;
                    listOfBoxes.Add(newBox);
                }
            }
            


            //{ boxSerialNumber}
            //-- { boxItemName} – ${ boxItemPrice}: { boxItemQuantity}
            //-- ${
            //    boxPrice

            foreach (var b in listOfBoxes.OrderByDescending(x=>x.PriceForABox))
            {
                Console.WriteLine(b.SerialNumber);
                Console.WriteLine($"-- { b.item.Name} - ${ b.item.Price:f2}: { b.ItemQuantity}");
                Console.WriteLine($"-- ${b.PriceForABox:f2}");
            }

        }
    }
    public class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }

    }

    public class Boxes
    {
        //Serial Number, Item, Item Quantity and Price for a Box
        public string SerialNumber { get; set; }
        public Item item { get; set; }

        public int ItemQuantity { get; set; }

        public double PriceForABox { get; set; }

    }
}
