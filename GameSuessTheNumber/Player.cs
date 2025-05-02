using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace GuessNumberGame
{
    public class Player
    {
        public string Nickname { get; set; }
        public List<Game> Games { get; set; } = new List<Game>();
        [XmlIgnore]
        public int TotalPoints => Games.Sum(g => g.PointsChange);
        public Player() { }
        public Player(string nick) { Nickname = nick; }
    }
}