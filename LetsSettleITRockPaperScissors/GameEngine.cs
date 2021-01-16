using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsSettleITRockPaperScissors
{
    class GameEngine
    {

        public string[] RockPaperScissors { get; set; } = { "Rock", "Paper", "Scissors" };

        private readonly Random random = new Random();

        public int Index { get; set; }

        public GameEngine()
        {
            Index = random.Next(RockPaperScissors.Length);
        }


    }
}
