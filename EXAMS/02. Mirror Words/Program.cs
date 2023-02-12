using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _02._Mirror_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            Regex pattern1 = 
                new Regex(@"#([A-Za-z]+)(##)([A-Za-z]+)#|@([A-Za-z]+)(@@)([A-Za-z]+)@");
            var matches1 = pattern1.Matches(input1);
            string matches1String = string.Join(" ", matches1);
            
            Regex pattern2 =
                new Regex(@"([A-Za-z]+)(##)([A-Za-z]+)|([A-Za-z]+)(@@)([A-Za-z]+)");
            MatchCollection matches2 = pattern2.Matches(matches1String);
           

            Dictionary<string, string> dict = new Dictionary<string, string>();
            string[] words = new string[2];
            string word1 = string.Empty;
            string word2 = string.Empty;
            
           
            if (matches1.Count == 0)
            {
               Console.WriteLine("No word pairs found!");
                Console.WriteLine("No mirror words!");
                return;
            }
            else
            {
                Console.WriteLine($"{matches1.Count} word pairs found!");
                
                foreach (var item in matches2)
                {
                   
                    if (item.ToString().Contains("##"))
                    {
                        words=item.ToString().Split("##");
                    }
                    else if (item.ToString().Contains("@@"))
                    {
                        words = item.ToString().Split("@@");
                    }
                    word1 = words[0];
                    word2 = words[1];
                    string revWord = word2;
                    char[] wordChars = revWord.ToCharArray();
                    char[] reversed = new char[wordChars.Length];
                    for (int i = 0; i < wordChars.Length; i++)
                    {
                        reversed[i] = wordChars[wordChars.Length - 1 - i];
                    }
                    revWord = string.Join("",reversed);
                    
                    
                    if (word1 == revWord)
                    {
                        dict.Add(word1, word2);
                    }
                }
            }
            //...................output............................................
            if (dict.Count==0)
            {
                Console.WriteLine("No mirror words!");
                return;
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                List<string> list = new List<string>();
                foreach (var (k,v) in dict)
                {
                    string exit = k + " <=> " + v;
                    list.Add(exit);
                }

                Console.WriteLine(string.Join(", ",list));
            }
                  
                  //"{ wordOne} <=> { wordtwo}, { wordOne} <=> { wordtwo}, … { wordOne} <=> { wordtwo}"

        }
    }
}
