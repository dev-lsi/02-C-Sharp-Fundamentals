using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> player1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> player2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (player1.Count>0 && player2.Count>0)
            {
                int p1Card = player1[0];
                int p2Card = player2[0];
                
                player1.RemoveAt(0);
                player2.RemoveAt(0);

                if (p1Card>p2Card)
                {
                    player1.Add(p1Card);
                    player1.Add(p2Card);
                }
                else if (p1Card < p2Card)
                {
                    player2.Add(p2Card);
                    player2.Add(p1Card);
                }
                else if(p1Card==p2Card)
                {
                    continue;
                }
            }
            //output
            int sum = 0;
            string winner = string.Empty;
            
            if (player1.Count == 0)
            {
                for (int i = 0; i < player2.Count; i++)
                {
                    sum = sum + player2[i];
                }
                winner = "Second";
            }
            else if (player2.Count == 0)
            {
                for (int i = 0; i < player1.Count; i++)
                {
                    sum = sum + player1[i];
                }
                winner = "First";
            }

            Console.WriteLine($"{winner} player wins! Sum: {sum}");



        }
    }
}
