using System;
using System.Windows.Forms;

namespace GuessNumberGame
{
    public partial class PlayerGamesForm : Form
    {
        public PlayerGamesForm(Player player)
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = player.Games;
        }
    }
}