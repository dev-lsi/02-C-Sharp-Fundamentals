using System;
using System.Collections.Generic;
using System.Linq;

namespace Team_Work_Projects
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();


            for (int i = 0; i < n; i++)
            {
                string[] newTeamInfo = Console.ReadLine().Split("-");
                string newCreator = newTeamInfo[0];
                string newTeamName = newTeamInfo[1];
                bool isAlreadyCreated = false;
                bool isUserValid = true;
                
                foreach (var team in teams)
                {
                    if (team.TeamName == newTeamName)
                    {
                        Console.WriteLine($"Team {newTeamName} was already created!");
                        isAlreadyCreated = true;
                    }
                    if(team.Creator == newCreator)
                    {
                        Console.WriteLine($"{newCreator} cannot create another team!");
                        isUserValid = false;
                    }
                }
                if (isAlreadyCreated==false && isUserValid==true)
                {
                    Team newTeam = new Team(newCreator, newTeamName);
                    newTeam.TeamMembers = new List<string>();
                    teams.Add(newTeam);
                    Console.WriteLine($"Team {newTeam.TeamName} has been created by {newTeam.Creator}!");
                }
                
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split("->");
                bool isTeamExist = false;
                bool isAlreadyAMember = false;
                bool isAlreadyCreator = false;
                
                if (command[0]== "end of assignment")
                {
                    break;
                }
                else
                {
                    string user = command[0];
                    string teamName = command[1];
                    foreach (var team in teams)
                    {
                        if (team.TeamName == teamName)
                        {
                            isTeamExist = true;
                            if (team.TeamMembers.Contains(user))
                            {
                                isAlreadyAMember = true;
                            }
                            if (team.Creator== user)
                            {
                                isAlreadyCreator = true;
                            }

                        }
                        
                        

                    }
                    if (isTeamExist==false)
                    {
                        Console.WriteLine($"Team {teamName} does not exist!");
                    }
                    if (isAlreadyAMember==true|| isAlreadyCreator==true)
                    {
                        Console.WriteLine($"Member {user} cannot join team {teamName}!");
                    }
                    if (isTeamExist == true && isAlreadyAMember == false && isAlreadyCreator==false)
                    {
                        foreach (var team in teams)
                        {
                            if (team.TeamName == teamName)
                            {
                                team.TeamMembers.Add(user);
                            }
                        }
                    }


                }
            }
            // "{teamNameordered
            //- { creator}
            //-- { member}…

            List<Team> ordered = teams.OrderByDescending(x => x.TeamName).ToList();
            foreach (var team in ordered)
            {
                if (team.TeamMembers.Count != 0)
                {
                    Console.WriteLine($"{team.TeamName}");
                    Console.WriteLine($"- {team.Creator}");
                    foreach (var member in team.TeamMembers)
                    {
                        Console.WriteLine($"-- {member}");
                    }
                }
            }
            Console.WriteLine("Teams to disband:");
            foreach (var team in ordered.OrderBy(x=>x.TeamName))
            {
                if (team.TeamMembers.Count == 0)
                {
                    Console.WriteLine(team.TeamName);
                }
            }


        }
        // end of Main
        public class Team
        {
            public string Creator { get; set; }
            public string TeamName { get; set; }
            public List<string> TeamMembers { get; set; }

            public Team(string creator, string teamName)
            {
                Creator = creator;
                TeamName = teamName;
            }

        }
    }
}
