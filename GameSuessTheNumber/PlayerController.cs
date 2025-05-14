// PlayerController.cs
using System.Collections.Generic;
using System.Linq;

namespace GuessNumberGame
{
    public class PlayerController
    {
        private readonly List<Player> players;

        public PlayerController()
        {
            players = DataStorage.LoadPlayers();
        }

        public Player GetOrCreatePlayer(string nickname)
        {
            var player = players.FirstOrDefault(p => p.Nickname == nickname);
            if (player == null)
            {
                player = new Player(nickname);
                players.Add(player);
            }
            return player;
        }

        public Player GetPlayer(string nickname)
        {
            return players.FirstOrDefault(p => p.Nickname == nickname);
        }

        public List<Player> GetAllPlayers() => players;

        public void Save() => DataStorage.SavePlayers(players);
    }
}