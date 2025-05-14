using System;
using System.Windows.Forms;

namespace GuessNumberGame
{
    public partial class GuessForm : Form
    {
        private GameController controller;
        
        public GuessForm(Player player)
        {
            InitializeComponent();
            controller = new GameController(player);
            labelPrompt.Text = "Угадайте число от 1 до 100";
        }

        private void buttonGuess_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxGuess.Text, out int guess))
            {
                MessageBox.Show("Введите корректное число!");
                return;
            }

            string feedback = controller.ProcessGuess(guess, out bool finished);
            labelFeedback.Text = feedback;

            if (finished)
            {
                buttonGuess.Enabled = false;
                textBoxGuess.Enabled = false;
            }
        }
    }
}