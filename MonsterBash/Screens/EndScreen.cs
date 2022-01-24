using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MonsterBash
{
    public partial class EndScreen : UserControl
    {
        public EndScreen()
        {
            InitializeComponent();
        }

        private void retryButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            SelectionScreen ss = new SelectionScreen();
            f.Controls.Add(ss);
            f.Controls.Remove(this);
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            MenuScreen ms = new MenuScreen();
            f.Controls.Add(ms);
            f.Controls.Remove(this);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void retryButton_Enter(object sender, EventArgs e)
        {
            retryButton.BackColor = Color.LightGray;
            menuButton.BackColor = Color.White;
            exitButton.BackColor = Color.White;
        }
        private void menuButton_Enter(object sender, EventArgs e)
        {
            retryButton.BackColor = Color.White;
            menuButton.BackColor = Color.LightGray;
            exitButton.BackColor = Color.White;
        }

        private void exitButton_Enter(object sender, EventArgs e)
        {
            retryButton.BackColor = Color.White;
            menuButton.BackColor = Color.White;
            exitButton.BackColor = Color.LightGray;
        }

        private void EndScreen_Load(object sender, EventArgs e)
        {
            scoreLabel.Text = $"Final Score = {Form1.score}";
        }
    }
}
