using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace MonsterBash
{
    public partial class SelectionScreen : UserControl
    {
        bool gunSelect;
        bool trapSelect;
        bool difficultySelect;
        SoundPlayer click = new SoundPlayer(Properties.Resources.click);
        public SelectionScreen()
        {
            InitializeComponent();
        }

        private void gun1_Click(object sender, EventArgs e)
        {
            click.Play();
            Form1.gunType = "shotgun";
            gunSelect = true;
            if (gunSelect && trapSelect && difficultySelect) Start.BackColor = Color.Green;
            gun1.BackColor = Color.Silver;
            gun2.BackColor = Color.White;
        }

        private void gun2_Click(object sender, EventArgs e)
        {
            click.Play();
            Form1.gunType = "assualtRifle";
            gunSelect = true;
            if (gunSelect && trapSelect && difficultySelect) Start.BackColor = Color.Green;
            gun2.BackColor = Color.Silver;
            gun1.BackColor = Color.White;
        }

        private void trap1_Click(object sender, EventArgs e)
        {
            click.Play();
            Form1.trapType = "bearTrap";
            trapSelect = true;
            if (gunSelect && trapSelect && difficultySelect) Start.BackColor = Color.Green;
            trap1.BackColor = Color.Silver;
            trap2.BackColor = Color.White;
        }

        private void trap2_Click(object sender, EventArgs e)
        {
            click.Play();
            Form1.trapType = "landMine";
            trapSelect = true;
            if (gunSelect && trapSelect && difficultySelect) Start.BackColor = Color.Green;
            trap2.BackColor = Color.Silver;
            trap1.BackColor = Color.White;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            click.Play();
            if (gunSelect && trapSelect && difficultySelect)
            {
                Form f = this.FindForm();
                GameScreen gs = new GameScreen();
                f.Controls.Add(gs);
                f.Controls.Remove(this);
            }

        }

        private void difficulty0_Click(object sender, EventArgs e)
        {
            click.Play();
            Form1.difficultyType = 0;
            difficultySelect = true;
            difficulty0.BackColor = Color.Silver;
            difficulty1.BackColor = Color.White;
            difficulty2.BackColor = Color.White;
            difficulty3.BackColor = Color.White;
            difficulty4.BackColor = Color.White;
            difficulty5.BackColor = Color.White;
            difficulty6.BackColor = Color.White;
            difficulty7.BackColor = Color.White;
            difficulty8.BackColor = Color.White;
            difficulty9.BackColor = Color.White;
            if (gunSelect && trapSelect && difficultySelect) Start.BackColor = Color.Green;
        }

        private void difficulty1_Click(object sender, EventArgs e)
        {
            click.Play();
            Form1.difficultyType = 1;
            difficultySelect = true;
            difficulty0.BackColor = Color.White;
            difficulty1.BackColor = Color.Silver;
            difficulty2.BackColor = Color.White;
            difficulty3.BackColor = Color.White;
            difficulty4.BackColor = Color.White;
            difficulty5.BackColor = Color.White;
            difficulty6.BackColor = Color.White;
            difficulty7.BackColor = Color.White;
            difficulty8.BackColor = Color.White;
            difficulty9.BackColor = Color.White;
            if (gunSelect && trapSelect && difficultySelect) Start.BackColor = Color.Green;
        }

        private void difficulty2_Click(object sender, EventArgs e)
        {
            click.Play();
            Form1.difficultyType = 2;
            difficultySelect = true;
            difficulty0.BackColor = Color.White;
            difficulty1.BackColor = Color.White;
            difficulty2.BackColor = Color.Silver;
            difficulty3.BackColor = Color.White;
            difficulty4.BackColor = Color.White;
            difficulty5.BackColor = Color.White;
            difficulty6.BackColor = Color.White;
            difficulty7.BackColor = Color.White;
            difficulty8.BackColor = Color.White;
            difficulty9.BackColor = Color.White;
            if (gunSelect && trapSelect && difficultySelect) Start.BackColor = Color.Green;
        }

        private void difficulty3_Click(object sender, EventArgs e)
        {
            click.Play();
            Form1.difficultyType = 3;
            difficultySelect = true;
            difficulty0.BackColor = Color.White;
            difficulty1.BackColor = Color.White;
            difficulty2.BackColor = Color.White;
            difficulty3.BackColor = Color.Silver;
            difficulty4.BackColor = Color.White;
            difficulty5.BackColor = Color.White;
            difficulty6.BackColor = Color.White;
            difficulty7.BackColor = Color.White;
            difficulty8.BackColor = Color.White;
            difficulty9.BackColor = Color.White;
            if (gunSelect && trapSelect && difficultySelect) Start.BackColor = Color.Green;
        }

        private void difficulty4_Click(object sender, EventArgs e)
        {
            click.Play();
            Form1.difficultyType = 4;
            difficultySelect = true;
            difficulty0.BackColor = Color.White;
            difficulty1.BackColor = Color.White;
            difficulty2.BackColor = Color.White;
            difficulty3.BackColor = Color.White;
            difficulty4.BackColor = Color.Silver;
            difficulty5.BackColor = Color.White;
            difficulty6.BackColor = Color.White;
            difficulty7.BackColor = Color.White;
            difficulty8.BackColor = Color.White;
            difficulty9.BackColor = Color.White;
            if (gunSelect && trapSelect && difficultySelect) Start.BackColor = Color.Green;
        }

        private void difficulty5_Click(object sender, EventArgs e)
        {
            click.Play();
            Form1.difficultyType = 5;
            difficultySelect = true;
            difficulty0.BackColor = Color.White;
            difficulty1.BackColor = Color.White;
            difficulty2.BackColor = Color.White;
            difficulty3.BackColor = Color.White;
            difficulty4.BackColor = Color.White;
            difficulty5.BackColor = Color.Silver;
            difficulty6.BackColor = Color.White;
            difficulty7.BackColor = Color.White;
            difficulty8.BackColor = Color.White;
            difficulty9.BackColor = Color.White;
            if (gunSelect && trapSelect && difficultySelect) Start.BackColor = Color.Green;
        }

        private void difficulty6_Click(object sender, EventArgs e)
        {
            click.Play();
            Form1.difficultyType = 6;
            difficultySelect = true;
            difficulty0.BackColor = Color.White;
            difficulty1.BackColor = Color.White;
            difficulty2.BackColor = Color.White;
            difficulty3.BackColor = Color.White;
            difficulty4.BackColor = Color.White;
            difficulty5.BackColor = Color.White;
            difficulty6.BackColor = Color.Silver;
            difficulty7.BackColor = Color.White;
            difficulty8.BackColor = Color.White;
            difficulty9.BackColor = Color.White;
            if (gunSelect && trapSelect && difficultySelect) Start.BackColor = Color.Green;
        }

        private void difficulty7_Click(object sender, EventArgs e)
        {
            click.Play();
            Form1.difficultyType = 7;
            difficultySelect = true;
            difficulty0.BackColor = Color.White;
            difficulty1.BackColor = Color.White;
            difficulty2.BackColor = Color.White;
            difficulty3.BackColor = Color.White;
            difficulty4.BackColor = Color.White;
            difficulty5.BackColor = Color.White;
            difficulty6.BackColor = Color.White;
            difficulty7.BackColor = Color.Silver;
            difficulty8.BackColor = Color.White;
            difficulty9.BackColor = Color.White;
            if (gunSelect && trapSelect && difficultySelect) Start.BackColor = Color.Green;
        }

        private void difficulty8_Click(object sender, EventArgs e)
        {
            click.Play();
            Form1.difficultyType = 8;
            difficultySelect = true;
            difficulty0.BackColor = Color.White;
            difficulty1.BackColor = Color.White;
            difficulty2.BackColor = Color.White;
            difficulty3.BackColor = Color.White;
            difficulty4.BackColor = Color.White;
            difficulty5.BackColor = Color.White;
            difficulty6.BackColor = Color.White;
            difficulty7.BackColor = Color.White;
            difficulty8.BackColor = Color.Silver;
            difficulty9.BackColor = Color.White;
            if (gunSelect && trapSelect && difficultySelect) Start.BackColor = Color.Green;
        }

        private void difficulty9_Click(object sender, EventArgs e)
        {
            click.Play();
            Form1.difficultyType = 9;
            difficultySelect = true;
            difficulty0.BackColor = Color.White;
            difficulty1.BackColor = Color.White;
            difficulty2.BackColor = Color.White;
            difficulty3.BackColor = Color.White;
            difficulty4.BackColor = Color.White;
            difficulty5.BackColor = Color.White;
            difficulty6.BackColor = Color.White;
            difficulty7.BackColor = Color.White;
            difficulty8.BackColor = Color.White;
            difficulty9.BackColor = Color.Silver;
            if (gunSelect && trapSelect && difficultySelect) Start.BackColor = Color.Green;
        }

        private void gun1_Enter(object sender, EventArgs e)
        {
            gun1.BackColor = Color.LightGray;
        }

        private void gun1_Leave(object sender, EventArgs e)
        {
            if (Form1.gunType == "shotgun") gun1.BackColor = Color.Silver;
            else gun1.BackColor = Color.White;
        }

        private void gun2_Enter(object sender, EventArgs e)
        {
            gun2.BackColor = Color.LightGray;
        }

        private void gun2_Leave(object sender, EventArgs e)
        {
            if (Form1.gunType == "assualtRifle") gun2.BackColor = Color.Silver;
            else gun2.BackColor = Color.White;
        }

        private void trap1_Enter(object sender, EventArgs e)
        {
            trap1.BackColor = Color.LightGray;
        }

        private void trap1_Leave(object sender, EventArgs e)
        {
            if (Form1.trapType == "bearTrap") trap1.BackColor = Color.Silver;
            else trap1.BackColor = Color.White;
        }

        private void trap2_Enter(object sender, EventArgs e)
        {
            trap2.BackColor = Color.LightGray;trap2.BackColor = Color.LightGray;
        }

        private void trap2_Leave(object sender, EventArgs e)
        {
            if (Form1.trapType == "landMine") trap2.BackColor = Color.Silver;
            else trap2.BackColor = Color.White;
        }

        private void difficulty0_Enter(object sender, EventArgs e)
        {
             difficulty0.BackColor = Color.LightGray;
        }

        private void difficulty0_Leave(object sender, EventArgs e)
        {
            if (Form1.difficultyType == 0) difficulty0.BackColor = Color.Silver;
            else difficulty0.BackColor = Color.White;
        }

        private void difficulty1_Enter(object sender, EventArgs e)
        {
            difficulty1.BackColor = Color.LightGray;
        }

        private void difficulty1_Leave(object sender, EventArgs e)
        {
            if (Form1.difficultyType == 1) difficulty1.BackColor = Color.Silver;
            else difficulty1.BackColor = Color.White;
        }

        private void difficulty2_Enter(object sender, EventArgs e)
        {
            difficulty2.BackColor = Color.LightGray;
        }

        private void difficulty2_Leave(object sender, EventArgs e)
        {
            if (Form1.difficultyType == 2) difficulty2.BackColor = Color.Silver;
            else difficulty2.BackColor = Color.White;
        }

        private void difficulty3_Enter(object sender, EventArgs e)
        {
            difficulty3.BackColor = Color.LightGray;
        }

        private void difficulty3_Leave(object sender, EventArgs e)
        {
            if (Form1.difficultyType == 3) difficulty3.BackColor = Color.Silver;
            else difficulty3.BackColor = Color.White;
        }

        private void difficulty4_Enter(object sender, EventArgs e)
        {
            difficulty4.BackColor = Color.LightGray;
        }

        private void difficulty4_Leave(object sender, EventArgs e)
        {
            if (Form1.difficultyType == 4) difficulty4.BackColor = Color.Silver;
            else difficulty4.BackColor = Color.White;
        }

        private void difficulty5_Enter(object sender, EventArgs e)
        {
            difficulty5.BackColor = Color.LightGray;
        }

        private void difficulty5_Leave(object sender, EventArgs e)
        {
            if (Form1.difficultyType == 5) difficulty5.BackColor = Color.Silver;
            else difficulty5.BackColor = Color.White;
        }

        private void difficulty6_Enter(object sender, EventArgs e)
        {
            difficulty6.BackColor = Color.LightGray;
        }

        private void difficulty6_Leave(object sender, EventArgs e)
        {
            if (Form1.difficultyType == 6) difficulty6.BackColor = Color.Silver;
            else difficulty6.BackColor = Color.White;
        }

        private void difficulty7_Enter(object sender, EventArgs e)
        {
            difficulty7.BackColor = Color.LightGray;
        }

        private void difficulty7_Leave(object sender, EventArgs e)
        {
            if (Form1.difficultyType == 7) difficulty7.BackColor = Color.Silver;
            else difficulty7.BackColor = Color.White;
        }

        private void difficulty8_Enter(object sender, EventArgs e)
        {
            difficulty8.BackColor = Color.LightGray;
        }

        private void difficulty8_Leave(object sender, EventArgs e)
        {
            if (Form1.difficultyType == 8) difficulty8.BackColor = Color.Silver;
            else difficulty8.BackColor = Color.White;
        }

        private void difficulty9_Enter(object sender, EventArgs e)
        {
            difficulty9.BackColor = Color.LightGray;
        }

        private void difficulty9_Leave(object sender, EventArgs e)
        {
            if (Form1.difficultyType == 9) difficulty9.BackColor = Color.Silver;
            else difficulty9.BackColor = Color.White;
        }

        private void Start_Enter(object sender, EventArgs e)
        {
            if (gunSelect && trapSelect && difficultySelect) Start.BackColor = Color.LightGreen;
            else Start.BackColor = Color.Coral;
        }

        private void Start_Leave(object sender, EventArgs e)
        {
            if (gunSelect && trapSelect && difficultySelect) Start.BackColor = Color.Green;
            else Start.BackColor = Color.OrangeRed;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            click.Play();
            Form f = this.FindForm();
            MenuScreen ms = new MenuScreen();
            f.Controls.Add(ms);
            f.Controls.Remove(this);
        }

        private void backButton_Enter(object sender, EventArgs e)
        {
            backButton.BackColor = Color.LightGray;
        }

        private void backButton_Leave(object sender, EventArgs e)
        {
            backButton.BackColor = Color.White;
        }
    }
}

