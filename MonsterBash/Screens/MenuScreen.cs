using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace MonsterBash
{
    public partial class MenuScreen : UserControl
    {
        int scoreOne;
        string nameOne;
        int scoreTwo;
        string nameTwo;
        int scoreThree;
        string nameThree;

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

            XmlReader reader = XmlReader.Create("Properties/highscore.xml");

            scoreLabel.Text = "";

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text)
                {

                    scoreOne = Convert.ToInt32(reader.ReadString());

                    reader.ReadToNextSibling("nameOne");

                    nameOne = reader.ReadString();



                    reader.ReadToNextSibling("scoreTwo");

                    scoreTwo = Convert.ToInt32(reader.ReadString());

                    reader.ReadToNextSibling("nameTwo");

                    nameTwo = reader.ReadString();



                    reader.ReadToNextSibling("scoreThree");

                    scoreThree = Convert.ToInt32(reader.ReadString());

                    reader.ReadToNextSibling("nameThree");

                    nameThree = reader.ReadString();

                }

            }

            reader.Close();

            scoreLabel.Text = $"Highscores:\n{scoreOne}  {nameOne}\n{scoreTwo}  {nameTwo}\n{scoreThree}  {nameThree}";



        }
    }
}
