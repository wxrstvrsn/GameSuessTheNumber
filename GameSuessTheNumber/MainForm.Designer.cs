namespace GuessNumberGame
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelNickname;
        private System.Windows.Forms.TextBox textBoxNickname;
        private System.Windows.Forms.Button buttonStartGame;
        private System.Windows.Forms.Button buttonViewGames;
        private System.Windows.Forms.Button buttonViewRating;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelNickname = new System.Windows.Forms.Label();
            this.textBoxNickname = new System.Windows.Forms.TextBox();
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.buttonViewGames = new System.Windows.Forms.Button();
            this.buttonViewRating = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNickname
            // 
            this.labelNickname.AutoSize = true;
            this.labelNickname.Location = new System.Drawing.Point(12, 15);
            this.labelNickname.Name = "labelNickname";
            this.labelNickname.Size = new System.Drawing.Size(80, 13);
            this.labelNickname.TabIndex = 0;
            this.labelNickname.Text = "Введите ник:";
            // 
            // textBoxNickname
            // 
            this.textBoxNickname.Location = new System.Drawing.Point(98, 12);
            this.textBoxNickname.Name = "textBoxNickname";
            this.textBoxNickname.Size = new System.Drawing.Size(174, 20);
            this.textBoxNickname.TabIndex = 1;
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.Location = new System.Drawing.Point(15, 50);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(257, 23);
            this.buttonStartGame.TabIndex = 2;
            this.buttonStartGame.Text = "Начать игру";
            this.buttonStartGame.UseVisualStyleBackColor = true;
            this.buttonStartGame.Click += new System.EventHandler(this.buttonStartGame_Click);
            // 
            // buttonViewGames
            // 
            this.buttonViewGames.Location = new System.Drawing.Point(15, 90);
            this.buttonViewGames.Name = "buttonViewGames";
            this.buttonViewGames.Size = new System.Drawing.Size(257, 23);
            this.buttonViewGames.TabIndex = 3;
            this.buttonViewGames.Text = "Просмотреть мои игры";
            this.buttonViewGames.UseVisualStyleBackColor = true;
            this.buttonViewGames.Click += new System.EventHandler(this.buttonViewGames_Click);
            // 
            // buttonViewRating
            // 
            this.buttonViewRating.Location = new System.Drawing.Point(15, 130);
            this.buttonViewRating.Name = "buttonViewRating";
            this.buttonViewRating.Size = new System.Drawing.Size(257, 23);
            this.buttonViewRating.TabIndex = 4;
            this.buttonViewRating.Text = "Рейтинг игроков";
            this.buttonViewRating.UseVisualStyleBackColor = true;
            this.buttonViewRating.Click += new System.EventHandler(this.buttonViewRating_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 171);
            this.Controls.Add(this.buttonViewRating);
            this.Controls.Add(this.buttonViewGames);
            this.Controls.Add(this.buttonStartGame);
            this.Controls.Add(this.textBoxNickname);
            this.Controls.Add(this.labelNickname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Угадай число";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}