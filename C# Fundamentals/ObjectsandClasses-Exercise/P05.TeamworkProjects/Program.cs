using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.TeamworkProjects
{
    public class Teams
    {
        private readonly List<string> members; 

        public Teams(string team, string creator)
        {
            this.Team = team;
            this.Creator = creator;
            this.members = new List<string>();
        }

        public string Team { get; set; }
        public string Creator { get; set; }
        public List<string> Members
            => this.members;
        
        public void AddMember(string memberName)
        {
            this.members.Add(memberName);
        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {            
            List<Teams> teams = new List<Teams>();            

            AddTeam(teams);
            AsignMembers(teams);

            PrintResult(teams);
            
        }
        public static void AddTeam(List<Teams> teams)
        {
            int countTeams = int.Parse(Console.ReadLine());

            for (int i = 0; i < countTeams; i++)
            {
                string[] teamToAdd = Console.ReadLine()
                    .Split("-", StringSplitOptions.RemoveEmptyEntries);

                string creator = teamToAdd[0];
                string team = teamToAdd[1];                

                if (teams.Exists(t => t.Team == team))
                {
                    Console.WriteLine($"Team {team} was already created!");
                    continue;
                }
                if (teams.Exists(t => t.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }

                Teams newTeam = new Teams(team, creator);
                teams.Add(newTeam);
                Console.WriteLine($"Team {team} has been created by {creator}!");
            }
        }
        public static void AsignMembers(List<Teams> teams)
        {
            string command = Console.ReadLine();

            while (command != "end of assignment")
            {
                string[] commandArgs = command
                    .Split("->", StringSplitOptions.RemoveEmptyEntries);
                string user = commandArgs[0];
                string team = commandArgs[1];

                if (!teams.Exists(t => t.Team == team))
                {
                    Console.WriteLine($"Team {team} does not exist!");
                }
                else if (teams.Exists(t => t.Creator == user) || teams.Any(m => m.Members.Contains(user)))
                {
                    Console.WriteLine($"Member {user} cannot join team {team}!");
                }
                else
                {
                    Teams teamJoin = teams
                        .First(t => t.Team == team);
                    teamJoin.AddMember(user);
                }

                command = Console.ReadLine();
            }
        }
        public static void PrintResult(List<Teams> teams)
        {
            List<Teams> validTeams = teams
                .Where(t => t.Members.Count > 0)
                .OrderByDescending(t => t.Members.Count)
                .ThenBy(t => t.Team)
                .ToList();

            foreach (var team in validTeams)
            {
                Console.WriteLine($"{team.Team}");
                Console.WriteLine($"- {team.Creator}");

                foreach (var member in team.Members.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");

            List<Teams> teamDisband = teams
                .Where(t => t.Members.Count == 0)
                .OrderBy(t => t.Team)
                .ToList();

            foreach (var team in teamDisband)
            {
                Console.WriteLine($"{team.Team}");
            }
        }
    }
}
