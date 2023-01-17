using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Leagues<Team>
    {
        public List<Team> League = new List<Team>();
        public string SportType;

        public Leagues(string sportType)
        {
            SportType = sportType;
        }
        public void AddTeam(Team teamName, string sportType)
        {
            if (SportType == sportType)
            {
                League.Add(teamName);
            }
            else
            {
                Console.WriteLine($"Dėmesio: komanda \"{teamName}\" nepriklauso \"{SportType}\" lygai.");
            }
        }

        public void PrintAllTeams()
        {
            foreach(Team team in League)
            {
                Console.WriteLine(team);
            }
        }
    }
}
