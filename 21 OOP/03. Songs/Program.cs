using System;
using System.Collections.Generic;

namespace Songs
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); 
           
            List<Song> songsList = new List<Song>();



            for (int i = 0; i < n; i++)
            {
                string[] songInfo = Console.ReadLine().Split("_");
                
                Song song = new Song();
                song.TypeList = songInfo[0];
                song.Name = songInfo[1];
                song.Time = songInfo[2];
                songsList.Add(song);
            }

            string command = Console.ReadLine();
            if (command != "all")
            {
                string type = command;
                
                foreach (var s in songsList)
                {
                    if (s.TypeList==command)
                    {
                        Console.WriteLine(s.Name);
                    }
                }
            }
            else if(command == "all")
            {
                foreach (var s in songsList)
                {
                    Console.WriteLine($"{s.Name}");
                }
            }
            

        }

        public class Song
        {
            public string TypeList { get; set; }
            public string Name { get; set; }
            public string Time { get; set; }

        }
    }
}
