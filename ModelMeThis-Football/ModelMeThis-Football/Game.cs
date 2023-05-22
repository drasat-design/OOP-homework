using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ModelMeThis_Football
{
    internal class Game
    {
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public Referee Referee { get; set; }
        public Referee[] AssistantReferees { get; set; }
        public List<Goal> Goals { get; set; } = new List<Goal>();

        public int Team1Goals { get; set; }
        public int Team2Goals { get; set; }

        public string GameResult { get; set; }
        public string Winner { get; set; }

        public void AddTeams(Team team1, Team team2)
        {
            if(team1.Players.Count != 11 || team2.Players.Count != 11)
            {
                Console.WriteLine("The teams must have 11 players");
                return;
            }
            Team1 = team1;
            Team2 = team2;
        }
        public void AddGoal(double minute, FootballPlayer player)
        {
            Goal goal = new Goal(minute, player);
            Goals.Add(goal);
            foreach(var person in Team1.Players)
            {
                if (person.Name == player.Name && person.Number == player.Number)
                {
                    Team1Goals++;
                }
            }
            foreach (var person in Team2.Players)
            {
                if (person == player && person.Number == player.Number)
                {
                    Team2Goals++;
                }
            }
            GameResult = $"{Team1Goals} : {Team2Goals}";
        }

        public void FinishGame()
        {
            if(Team1Goals > Team2Goals)
            {
                Winner = "Team 1";
                Console.WriteLine($"Team 1 is the winner! The final score is: {Team1Goals} : {Team2Goals}");
            }
            else if(Team2Goals > Team1Goals)
            {
                Winner = "Team 2";
                Console.WriteLine($"Team 2 is the winner! The final score is: {Team2Goals} : {Team1Goals}");
            } else
            {
                Winner = "Tie";
                Console.WriteLine($"The score is equal: {Team1Goals} : {Team2Goals}");
            }
        }
        public void GetInfo()
        {
            Console.WriteLine("Team 1 has players:");
            foreach(FootballPlayer player in Team1.Players)
            {
                Console.WriteLine(player.Name + " Number: " + player.Number);
            }
            Console.WriteLine("Team 2 has players:");
            foreach (FootballPlayer player in Team2.Players)
            {
                Console.WriteLine(player.Name + " Number: " + player.Number);
            }
            Console.WriteLine($"The score is: {GameResult}");
            FinishGame();

        }
    }
}
