using System;
using System.Windows.Forms;

namespace GuessNumberGame
{
    public partial class GuessForm : Form
    {
        private Player player;
        private Game game;
        private Random random = new Random();

        public GuessForm(Player player)
        {
            InitializeComponent();
            this.player = player;
            int number = random.Next(1, 101);
            game = new Game { Date = DateTime.Now, Number = number, Attempts = 0 };
            labelPrompt.Text = "Угадайте число от 1 до 100";
        }

        private void buttonGuess_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxGuess.Text, out int guess))
            {
                MessageBox.Show("Введите корректное число!");
                return;
            }
            game.Attempts++;
            if (guess == game.Number)
            {
                game.IsWin = true;
                game.PointsChange = 100 - (game.Attempts - 1) * 10;
                labelFeedback.Text = $"Правильно! Попыток: {game.Attempts}. Баллы: {game.PointsChange}";
                EndGame();
            }
            else if (game.Attempts >= 10)
            {
                game.IsWin = false;
                game.PointsChange = -20;
                labelFeedback.Text = $"Вы проиграли! Число было {game.Number}. Баллы: {game.PointsChange}";
                EndGame();
            }
            else if (guess < game.Number)
                labelFeedback.Text = "Загаданное число больше";
            else
                labelFeedback.Text = "Загаданное число меньше";
        }

        private void EndGame()
        {
            player.Games.Add(game);
            buttonGuess.Enabled = false;
            textBoxGuess.Enabled = false;
        }
    }
}