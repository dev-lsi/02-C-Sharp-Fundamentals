using System;
using System.Collections.Generic;
using System.Text;

namespace Team_Work_Projects
{
    public class Team
    {
        public string Creator { get; set; }
        public string TeamName { get; set; }
        public List<string> TeamMembers { get; set; }

        public Team(string creator,string teamName)
        {
            Creator = creator;
            TeamName = teamName;
        }

    }
}
