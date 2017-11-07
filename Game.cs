This is for Step 7
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game2
{
    public class Game
    {
        public string team1 { get; set; }

        public int team1Score { get; set; }

        public string team2 { get; set; }

        public int team2Score { get; set; }


        public Game() { }


        public Game(string team1, int team1Score, string team2, int team2Score)
        {
            this.team1 = team1;
            this.team1Score = team1Score;
            this.team2 = team2;
            this.team2Score = team2Score;


        }
        public override string ToString()
        {
            return String.Format(team1 + " (" + team1Score + ") " + "- " + team2 + " (" + team2Score + ")");
        }
    }
}
