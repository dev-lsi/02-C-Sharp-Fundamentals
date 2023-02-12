using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Ad_Astra
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex inputRegex = 
                new Regex(@"(#[\w ]+#)([0-9]{2}\/[0-9]{2}\/[0-9]{2})(#[0-9]+#)|(\|[\w ]+\|)([0-9]{2}\/[0-9]{2}\/[0-9]{2})(\|[0-9]+\|)");
            int calories = 0;
            
            var matches = inputRegex.Matches(input);

            int matchesCount = matches.Count;
            List<string> matchesArr = new List<string>();
            foreach (var match in matches)
            {
                //Console.WriteLine(match.ToString());
                matchesArr.Add((match.ToString()));
            }
            foreach (var item in matchesArr)
            {
                string[] command = item.Split(new char[] { '#', '|' });
                //Console.WriteLine("tova e inputa===>:"+command[2]);
                calories += int.Parse(command[3]);
            }
            //Console.WriteLine(string.Join(".....", matchesArr));
            
            //string[] command = matchesArr[0].Split(new char[] { '#', '|' });
           // Console.WriteLine(string.Join("<>", command));


            //...........output.......................................
            int days = calories / 2000;
            Console.WriteLine($"You have food to last you for: {days} days!");

            foreach (var item in matchesArr)
            {
                string[] command = item.Split(new char[] { '#', '|' });
                Console.WriteLine($"Item: {command[1]}, Best before: {command[2]}, Nutrition: {command[3]}");

            }
            //foreach (var match in arr)
            //{
            //    string[] commandArr = match.Split('/');
            //    Console.WriteLine($"Item: {commandArr[0]}, Best before: {commandArr[1]}, Nutrition: {commandArr[2]}");
            //}

        }
    }
}
