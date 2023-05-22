

namespace ModelMeThis_Football
{
    using System.Linq;
    internal class Program
    {
        static void Main(string[] args)
        {
            Team team1 = new Team();
            Team team2 = new Team();

            Game game = new Game();

            List<FootballPlayer> footballPlayers1 = new List<FootballPlayer>();
            footballPlayers1.Add(new Defender("Defender1", 12, 21, 1.76));
            footballPlayers1.Add(new Defender("Defender2", 2, 20, 1.74));
            footballPlayers1.Add(new Goalkeeper("Goalkeeper1", 22, 22, 1.77));
            footballPlayers1.Add(new Striker("Striker1", 45, 20, 1.76));
            footballPlayers1.Add(new Striker("Striker2", 7, 21, 1.83));
            footballPlayers1.Add(new Striker("Striker3", 3, 26, 1.86));
            footballPlayers1.Add(new Defender("Defender3", 67, 24, 1.91));
            footballPlayers1.Add(new Midfield("Midfield1", 89, 25, 1.90));
            footballPlayers1.Add(new Midfield("Midfield2", 71, 23, 1.74));
            footballPlayers1.Add(new Midfield("Midfield3", 35, 19, 1.87));
            footballPlayers1.Add(new Midfield("Midfield4", 78, 20, 1.70));

            List<FootballPlayer> footballPlayers2 = new List<FootballPlayer>();
            footballPlayers2.Add(new Defender("Defender11", 43, 21, 1.72));
            footballPlayers2.Add(new Defender("Defender12", 3, 20, 1.74));
            footballPlayers2.Add(new Goalkeeper("Goalkeeper11", 82, 22, 1.87));
            footballPlayers2.Add(new Striker("Striker11", 5, 20, 1.91));
            footballPlayers2.Add(new Striker("Striker12", 7, 20, 1.83));
            footballPlayers2.Add(new Striker("Striker13", 90, 23, 1.86));
            footballPlayers2.Add(new Defender("Defender13", 47, 24, 1.91));
            footballPlayers2.Add(new Midfield("Midfield11", 29, 25, 1.90));
            footballPlayers2.Add(new Midfield("Midfield12", 75, 24, 1.74));
            footballPlayers2.Add(new Midfield("Midfield13", 15, 18, 1.85));
            footballPlayers2.Add(new Midfield("Midfield14", 58, 22, 1.73));

            team1.AddPlayers(footballPlayers1.Select(x => x).ToArray());
            team2.AddPlayers(footballPlayers2.Select(x => x).ToArray());
            game.AddTeams(team1, team2);
            game.AddGoal(12.12, new Striker("Striker13", 90, 23, 1.86));
            game.AddGoal(57.54, new Midfield("Midfield2", 71, 23, 1.74));
            game.AddGoal(82.34, new Striker("Striker2", 7, 21, 1.83));
            game.GetInfo();
        }

       
    }
}