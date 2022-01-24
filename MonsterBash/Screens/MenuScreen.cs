using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MonsterBash
{
    public partial class MenuScreen : UserControl
    {
        public static int position = 1;
        public static bool Key;
        public static bool space;
        public MenuScreen()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            SelectionScreen ss = new SelectionScreen();
            f.Controls.Add(ss);
            f.Controls.Remove(this);
        }
        private void startButton_Enter(object sender, EventArgs e)
        {
            startButton.BackColor = Color.LightGray;
            exitButton.BackColor = Color.White;
        }

        private void exitButton_Enter(object sender, EventArgs e)
        {
            exitButton.BackColor = Color.LightGray;
            startButton.BackColor = Color.White;
        }

        private void MenuScreen_Load(object sender, EventArgs e)
        {
            instrustionLabel.Text = "How To Play\nB = Place Trap\nN = Dash\nM = Sword Attack\nSpace = Shoot\nFight agiasnt waves of enemies\nThe faster you go the more Points you will get!";
        }
    }
}
