
namespace MonsterBash
{
    partial class GameScreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GameTick = new System.Windows.Forms.Timer(this.components);
            this.bulletCountLabel = new System.Windows.Forms.Label();
            this.trapCount = new System.Windows.Forms.Label();
            this.healthLabel = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.waveLabel = new System.Windows.Forms.Label();
            this.difficultyLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GameTick
            // 
            this.GameTick.Interval = 20;
            this.GameTick.Tick += new System.EventHandler(this.GameTick_Tick);
            // 
            // bulletCountLabel
            // 
            this.bulletCountLabel.AutoSize = true;
            this.bulletCountLabel.Location = new System.Drawing.Point(42, 22);
            this.bulletCountLabel.Name = "bulletCountLabel";
            this.bulletCountLabel.Size = new System.Drawing.Size(74, 15);
            this.bulletCountLabel.TabIndex = 0;
            this.bulletCountLabel.Text = "Bullets left: 0";
            // 
            // trapCount
            // 
            this.trapCount.AutoSize = true;
            this.trapCount.Location = new System.Drawing.Point(153, 22);
            this.trapCount.Name = "trapCount";
            this.trapCount.Size = new System.Drawing.Size(66, 15);
            this.trapCount.TabIndex = 1;
            this.trapCount.Text = "Traps left: 0";
            // 
            // healthLabel
            // 
            this.healthLabel.AutoSize = true;
            this.healthLabel.Location = new System.Drawing.Point(262, 22);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(60, 15);
            this.healthLabel.TabIndex = 2;
            this.healthLabel.Text = "Health: 00";
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Location = new System.Drawing.Point(962, 22);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(46, 15);
            this.levelLabel.TabIndex = 3;
            this.levelLabel.Text = "Level: 0";
            // 
            // waveLabel
            // 
            this.waveLabel.AutoSize = true;
            this.waveLabel.Location = new System.Drawing.Point(1037, 22);
            this.waveLabel.Name = "waveLabel";
            this.waveLabel.Size = new System.Drawing.Size(48, 15);
            this.waveLabel.TabIndex = 4;
            this.waveLabel.Text = "Wave: 0";
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.AutoSize = true;
            this.difficultyLabel.Location = new System.Drawing.Point(1104, 22);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(67, 15);
            this.difficultyLabel.TabIndex = 5;
            this.difficultyLabel.Text = "Difficulty: 0";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(865, 22);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(66, 15);
            this.scoreLabel.TabIndex = 6;
            this.scoreLabel.Text = "Score: 0000";
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.difficultyLabel);
            this.Controls.Add(this.waveLabel);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.healthLabel);
            this.Controls.Add(this.trapCount);
            this.Controls.Add(this.bulletCountLabel);
            this.DoubleBuffered = true;
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(1200, 700);
            this.Load += new System.EventHandler(this.GameScreen_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameScreen_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer GameTick;
        private System.Windows.Forms.Label bulletCountLabel;
        private System.Windows.Forms.Label trapCount;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label waveLabel;
        private System.Windows.Forms.Label difficultyLabel;
        private System.Windows.Forms.Label scoreLabel;
    }
}
