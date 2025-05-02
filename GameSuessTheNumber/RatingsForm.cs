using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GuessNumberGame
{
    public partial class RatingsForm : Form
    {
        public RatingsForm(List<Player> players)
        {
            InitializeComponent();
            var list = players.Select(p => new { p.Nickname, TotalPoints = p.TotalPoints })
                              .OrderByDescending(p => p.TotalPoints)
                              .ToList();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = list;
        }
    }
}
