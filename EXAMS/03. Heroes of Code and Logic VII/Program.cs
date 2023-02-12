using System;
using System.Collections.Generic;

namespace _03._Heroes_of_Code_and_Logic_VII
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfHeroes = int.Parse(Console.ReadLine());
            Dictionary<string, int[]> heroData = new Dictionary<string, int[]>();
            //heroData = name [HitP ManaP]
            
            for (int i = 0; i < numberOfHeroes; i++)
            {
                string[] heroesInput = Console.ReadLine().Split();
                string name = heroesInput[0];
                int hitP = int.Parse(heroesInput[1]);
                int manaP = int.Parse(heroesInput[2]);
                heroData.Add(name,new int[] { hitP, manaP });
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split(" - ");
                if (command[0] =="End")
                {
                    break;
                }
                else
                {
                    
                    if (command[0]== "CastSpell") //CastSpell – {hero name} – {MP needed} – {spell name}
                    {

                        int manaNeeded = int.Parse(command[2]);
                        string name = command[1];
                        string spellName = command[3];
                        int currMana = heroData[name][1];
                        if (currMana< manaNeeded)
                        {
                            Console.WriteLine($"{name} does not have enough MP to cast {spellName}!");
                        }
                        else
                        {
                            currMana -= manaNeeded;
                            heroData[name][1] = currMana;
                            Console.WriteLine($"{name} has successfully cast {spellName} and now has {currMana} MP!");
                        }
                    }
                    else if (command[0] == "TakeDamage") //TakeDamage – {hero name} – {damage} – {attacker}
                    {
                        string name = command[1];
                        int damageTaken = int.Parse(command[2]);
                        string attackerName = command[3];
                        int hitP = heroData[name][0];
                        if(hitP <= damageTaken)
                        {
                            Console.WriteLine($"{name} has been killed by {attackerName}!");
                            heroData.Remove(name);
                        }
                        else
                        {
                            Console.WriteLine($"{name} was hit for {damageTaken} HP by {attackerName} and now has {hitP-damageTaken} HP left!");
                            heroData[name][0] = hitP - damageTaken;
                        }
                        
                    }
                    else if (command[0] == "Recharge") //Recharge – {hero name} – {amount}
                    {
                        
                        string name = command[1];
                        int newMana = int.Parse(command[2]);
                        int currMana = heroData[name][1];
                        
                        if (currMana+newMana <= 200)
                        {
                            Console.WriteLine($"{name} recharged for {newMana} MP!");
                            heroData[name][1] = currMana+newMana;
                        }
                        else
                        {
                            Console.WriteLine($"{name} recharged for {200 - currMana} MP!");
                            heroData[name][1] = 200;
                        }
                    }
                    else if (command[0] == "Heal") //Heal – {hero name} – {amount}
                    {
                        
                        string name = command[1];
                        int newHP = int.Parse(command[2]);
                        int currHP = heroData[name][0];
                        if (currHP + newHP >= 100)
                        {
                            Console.WriteLine($"{name} healed for {100-currHP} HP!");
                            heroData[name][0] = 100;
                        }
                        else
                        {
                            Console.WriteLine($"{name} healed for {newHP} HP!");
                            heroData[name][0] = currHP + newHP;
                        }


                    }
                }
            }
            
            foreach (var item in heroData)
            {
                
                int[] data = item.Value; 
                if(data[0] <= 0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(item.Key);
                    Console.WriteLine($"  HP: {data[0]}");
                    Console.WriteLine($"  MP: {data[1]}");
                }

                
            }

        }
    }
}
