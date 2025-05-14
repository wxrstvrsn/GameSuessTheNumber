using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GuessNumberGame
{
    
    public partial class MainForm : Form
    {
        private PlayerController _controller;
        

        public MainForm()
        {
            InitializeComponent(); 
            _controller = new PlayerController();
        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            string nick = textBoxNickname.Text.Trim();
            if (string.IsNullOrEmpty(nick))
            {
                MessageBox.Show("Введите ник!");
                return;
            }

            var player = _controller.GetOrCreatePlayer(nick);

            using (var form = new GuessForm(player))
                form.ShowDialog();

            _controller.Save();
            
        }

        private void buttonViewGames_Click(object sender, EventArgs e)
        {
            string nick = textBoxNickname.Text.Trim();
            if (string.IsNullOrEmpty(nick))
            {
                MessageBox.Show("Введите ник!");
                return;
            }

            var player = _controller.GetPlayer(nick);
            if (player == null)
            {
                MessageBox.Show("Игрок не найден!");
                return;
            }

            using (var form = new PlayerGamesForm(player))
                form.ShowDialog();
        }

        private void buttonViewRating_Click(object sender, EventArgs e)
        {
            using (var form = new RatingsForm(_controller.GetAllPlayers()))
                form.ShowDialog();
        }
    }
}