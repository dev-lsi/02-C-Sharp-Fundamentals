using System;
using System.Numerics;
using System.Text.RegularExpressions;

namespace _02._Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            
            Regex digitRegex = new Regex(@"[0-9]");
            MatchCollection digitMatches = digitRegex.Matches(text);
            BigInteger coolThreshold = new BigInteger(1);
            foreach (var item in digitMatches)
            {
                string digit=item.ToString();
                int curr=int.Parse(digit);
                coolThreshold *= curr;
            }
            Console.WriteLine($"Cool threshold: {coolThreshold}");

            Regex inputRegex = new Regex(@"::[A-Z][a-z]{2,}::|\*\*[A-Z][a-z]{2,}\*\*");
            MatchCollection inputMatches = inputRegex.Matches(text);
            Console.WriteLine($"{inputMatches.Count} emojis found in the text. The cool ones are:");

            
            BigInteger sum = new BigInteger(0);
            
            foreach (var word in inputMatches)
            {
                string emjoi=word.ToString();
                sum = 0;
                foreach (var ch in emjoi)
                {
                    int digValue = (int)ch;
                    if (digValue !=42 && digValue !=58) 
                    {
                        sum = sum + digValue;
                    }
                    
                        
                }
                if(sum < coolThreshold)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(emjoi);
                }
            }


            //"{countOfAllEmojis} emojis found in the text. The cool ones are:
            //{ cool emoji 1}
            //{ cool emoji 2}
            //{ cool emoji N}


        }
    }
}
