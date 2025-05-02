using System;

namespace GuessNumberGame
{
    public class Game
    {
        public DateTime Date { get; set; }
        public bool IsWin { get; set; }
        public int PointsChange { get; set; }
        public int Number { get; set; }
        public int Attempts { get; set; }
        public Game() { }
    }
}