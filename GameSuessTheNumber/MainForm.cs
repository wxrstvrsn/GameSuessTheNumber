using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GuessNumberGame
{
    // Главная форма: ввод ника, кнопки управления
    public partial class MainForm : Form
    {
        private List<Player> players;

        public MainForm()
        {
            InitializeComponent(); // Инициализация компонентов интерфейса
            players = DataStorage.LoadPlayers();
            // Загружаем список игроков из XML
        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            string nick = textBoxNickname.Text.Trim();
            if (string.IsNullOrEmpty(nick))
            {
                MessageBox.Show("Введите ник!");
                return;
            }
            // Ищем игрока по нику
            Player player = players.FirstOrDefault(p => p.Nickname == nick);
            if (player == null)
            {
                player = new Player(nick);
                players.Add(player);
            }
            // Открываем форму угадывания
            using (var form = new GuessForm(player))
            {
                form.ShowDialog();
            }
            DataStorage.SavePlayers(players);
            // Сохраняем изменения (новые игроки, результаты)
        }

        private void buttonViewGames_Click(object sender, EventArgs e)
        {
            string nick = textBoxNickname.Text.Trim();
            if (string.IsNullOrEmpty(nick))
            {
                MessageBox.Show("Введите ник!");
                return;
            }
            Player player = players.FirstOrDefault(p => p.Nickname == nick);
            if (player == null)
            {
                MessageBox.Show("Игрок не найден!");
                return;
            }
            using (var form = new PlayerGamesForm(player))
            {
                form.ShowDialog();
            }
            // Показываем историю игр игрока
        }

        private void buttonViewRating_Click(object sender, EventArgs e)
        {
            using (var form = new RatingsForm(players))
            {
                form.ShowDialog();
            }
            // Показываем рейтинг всех игроков
        }
    }
}