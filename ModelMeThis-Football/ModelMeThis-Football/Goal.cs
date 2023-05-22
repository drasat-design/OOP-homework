using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelMeThis_Football
{
    internal class Goal
    {
        public double Minute { get; set; }
        public FootballPlayer Player { get; set; }

        public Goal(double minute, FootballPlayer player)
        {
            Minute = minute;
            Player = player;
        }
    }
}
