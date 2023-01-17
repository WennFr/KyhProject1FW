﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp.Models
{
    public class GameRound
    {
        public int Round { get; set; }
        public Human Human { get; set; } = new Human();
        public Computer Computer { get; set; } = new Computer();
        public int HumanWin { get; set; }
        public int ComputerWin { get; set; }

        public enum action
        {
            Rock,
            Paper,
            Scissors
        }


    }
}
