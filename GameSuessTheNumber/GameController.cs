// GameController.cs
using System;

namespace GuessNumberGame
{
    public class GameController
    {
        private readonly Player _player;
        private readonly Game _game;
        private readonly Random _random = new Random();

        public Game Game => _game;

        public GameController(Player player)
        {
            _player = player;
            _game = new Game
            {
                Date = DateTime.Now,
                Number = _random.Next(1, 101),
                Attempts = 0
            };
        }

        public string ProcessGuess(int guess, out bool finished)
        {
            finished = false;
            _game.Attempts++;

            if (guess == _game.Number)
            {
                _game.IsWin = true;
                _game.PointsChange = 100 - (_game.Attempts - 1) * 10;
                _player.Games.Add(_game);
                finished = true;
                return $"Правильно! Попыток: {_game.Attempts}. Баллы: {_game.PointsChange}";
            }

            if (_game.Attempts >= 10)
            {
                _game.IsWin = false;
                _game.PointsChange = -20;
                _player.Games.Add(_game);
                finished = true;
                return $"Вы проиграли! Число было {_game.Number}. Баллы: {_game.PointsChange}";
            }

            return guess < _game.Number ? "Загаданное число больше" : "Загаданное число меньше";
        }
    }
}