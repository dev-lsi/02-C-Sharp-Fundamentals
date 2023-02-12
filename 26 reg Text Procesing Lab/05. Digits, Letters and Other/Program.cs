using System;
using System.Text;

namespace _05._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder digitString = new StringBuilder();
            StringBuilder alphaString = new StringBuilder();
            StringBuilder charString  = new StringBuilder();

            foreach (var item in input)
            {
                if (isDigit(item))
                {
                    digitString.Append(item);
                }
                else if(isAlpha(item))
                {
                    alphaString.Append(item);
                }
                else
                {
                    charString.Append(item);
                }
            }
            
            Console.WriteLine(digitString.ToString());
            Console.WriteLine(alphaString.ToString());
            Console.WriteLine(charString.ToString());

        }
        //is Alpha Method
        private static bool isAlpha(char item)
        {
            if (item >= 65 && item <= 90|| item >= 97 && item <= 122)
                
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        //isDigit Method
        private static bool isDigit(char item)
        {
            if (item >= 48 && item <= 57)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
