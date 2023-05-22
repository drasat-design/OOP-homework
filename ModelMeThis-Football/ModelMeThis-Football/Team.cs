using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelMeThis_Football
{
    internal class Team
    {
        public Coach Coach { get; set; }
        public List<FootballPlayer> Players { get; set; } = new List<FootballPlayer>();
        public double AverageAge { get; protected set; }

        public void AddPlayers(FootballPlayer[] players)
        {
            if(players.Length > 22)
            {
                Console.WriteLine("There can't be more than 22 players on a team");
                return;
            } else if (players.Length < 11)
            {
                Console.WriteLine("There can't be less than 11 players on a team");
                return;
            }
            Players = players.ToList<FootballPlayer>();
            int numberOfPlayers = 0;
            double CombinedAge = 0;
            foreach(var player in players)
            {
                numberOfPlayers++;
                CombinedAge += player.Age;
            }
            AverageAge = CombinedAge / numberOfPlayers;
        }
    }
}
