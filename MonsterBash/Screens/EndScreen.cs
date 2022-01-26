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
    public partial class EndScreen : UserControl
    {
        int scoreOne;
        int scoreTwo;
        int scoreThree;
        string nameOne;
        string nameTwo;
        string nameThree;
        int newScore;
        string newName;
        public EndScreen()
        {
            InitializeComponent();
        }
        private void retryButton_Click(object sender, EventArgs e)
        {
            SetScore();
            Form f = this.FindForm();
            SelectionScreen ss = new SelectionScreen();
            f.Controls.Add(ss);
            f.Controls.Remove(this);
        }
        private void menuButton_Click(object sender, EventArgs e)
        {
            SetScore();
            Form f = this.FindForm();
            MenuScreen ms = new MenuScreen();
            f.Controls.Add(ms);
            f.Controls.Remove(this);
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            SetScore();
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
            newScore = Form1.score;

        }
        private void SetScore()
        {
            newName = nameTextBox.Text;
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
            if (scoreOne < newScore)
            {
                scoreThree = scoreTwo;
                scoreTwo = scoreOne;
                scoreOne = newScore;
                nameThree = nameTwo;
                nameTwo = nameOne;
                nameOne = newName;
            }
            else if (scoreTwo < newScore)
            {
                scoreThree = scoreTwo;
                scoreTwo = newScore;
                nameThree = nameTwo;
                nameTwo = newName;
            }
            else if (scoreThree < newScore)
            {
                scoreThree = newScore;
                nameThree = newName;
            }
            XmlWriter writer = XmlWriter.Create("Properties/highscore.xml", null);
            writer.WriteStartElement("highscore");
            writer.WriteElementString("scoreOne", Convert.ToString(scoreOne));
            writer.WriteElementString("nameOne", nameOne);
            writer.WriteElementString("scoreTwo", Convert.ToString(scoreTwo));
            writer.WriteElementString("nameTwo", nameTwo);
            writer.WriteElementString("scoreThree", Convert.ToString(scoreThree));
            writer.WriteElementString("nameThree", nameThree);
            writer.WriteEndElement();
            writer.Close();
            Form1.score = 0;
        }

    }
}
