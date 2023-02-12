using System;
using System.Collections.Generic;

namespace _03._P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int[]> dict = new Dictionary<string, int[]>();
            while (true)
            {
                string[] input = Console.ReadLine().Split("||");
                if(input[0]== "Sail")
                {
                    break;
                }
                else
                {
                    string city = input[0];
                    int pop = int.Parse(input[1]);
                    int gold = int.Parse(input[2]);

                    if (dict.ContainsKey(city))
                    {
                        dict[city][0] += pop;
                        dict[city][1] += gold;
                    }
                    else
                    {
                        dict.Add(city, new int[] { pop, gold });
                    }
                }
            }
            while (true)
            {
                //Plunder=>{town}=>{people}=>{gold}
                string[] command = Console.ReadLine().Split("=>");
                if (command[0]=="End")
                {
                    break;
                }
                else if (command[0] == "Plunder") //Plunder=>{town}=>{people}=>{gold}
                {
                    int killed = int.Parse(command[2]);
                    int stollen = int.Parse(command[3]);
                    string city = command[1];
                    int currPop=dict[city][0];
                    int currGold = dict[city][1];
                    int goldBalance = currGold - stollen;
                    int popBalance = currPop - killed;

                    Console.WriteLine($"{city} plundered! {stollen} gold stolen, {killed} citizens killed.");
                    dict[city][0] = popBalance;
                    dict[city][1] = goldBalance;
                    if (goldBalance <= 0 || popBalance<=0)
                    {
                        Console.WriteLine($"{city} has been wiped off the map!");
                        dict.Remove(city);
                    }



                    //"{town} plundered! {gold} gold stolen, {people} citizens killed."
                    //"{town} has been wiped off the map!"
                }
                else if (command[0] == "Prosper") //"Prosper=>{town}=>{gold}"
                {
                    int goldGiven = int.Parse(command[2]);
                    string city = command[1];
                    if (goldGiven>=0)
                    {
                        int currGold = dict[city][1];
                        dict[city][1] += goldGiven;
                        Console.WriteLine($"{goldGiven} gold added to the city treasury. {city} now has {dict[city][1]} gold.");
                    }
                    else
                    {
                        Console.WriteLine($"Gold added cannot be a negative number!");
                    }
                   
                }

            }
            if (dict.Count>0)
            {
                Console.WriteLine($"Ahoy, Captain! There are { dict.Count } wealthy settlements to go to:");
                foreach (var item in dict)
                {
                    string name = item.Key;
                    //{town1} -> Population: {people} citizens, Gold: {gold} kg
                    Console.WriteLine($"{item.Key} -> Population: {dict[name][0]} citizens, Gold: {dict[name][1]} kg");
                }
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}
