using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headSetPrice = double.Parse(Console.ReadLine());
            double mousePrice= double.Parse(Console.ReadLine());
            double keyBoardPrice= double.Parse(Console.ReadLine());
            double displayPrice= double.Parse(Console.ReadLine());

            int headSetCrashes = Crashes(lostGames,2);
            int mouseCrashes = Crashes(lostGames, 3);
            int keyBoardCrashes = Crashes(lostGames, 6);
            int displayCrashes = Crashes(keyBoardCrashes, 2);

            headSetPrice = headSetPrice * headSetCrashes;
            mousePrice = mousePrice * mouseCrashes;
            keyBoardPrice = keyBoardPrice * keyBoardCrashes;
            displayPrice = displayPrice * displayCrashes;

            double expenses = headSetPrice + mousePrice + keyBoardPrice + displayPrice;
            
            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
        static int Crashes(int lostGames,int n)
        {
            int crashesTimes = 0;
            for (int i = 1; i <= lostGames; i++)
            {
                if (i % n == 0)
                {
                    crashesTimes++;
                    continue;
                }
                else
                {
                    continue;
                }
            }

            return crashesTimes;
        }
    }
}
