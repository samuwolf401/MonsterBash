
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
            this.bulletCountLabel.BackColor = System.Drawing.Color.DimGray;
            this.bulletCountLabel.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bulletCountLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.bulletCountLabel.Location = new System.Drawing.Point(18, 20);
            this.bulletCountLabel.Name = "bulletCountLabel";
            this.bulletCountLabel.Size = new System.Drawing.Size(147, 18);
            this.bulletCountLabel.TabIndex = 0;
            this.bulletCountLabel.Text = "Bullets left: 0";
            // 
            // trapCount
            // 
            this.trapCount.AutoSize = true;
            this.trapCount.BackColor = System.Drawing.Color.DimGray;
            this.trapCount.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.trapCount.ForeColor = System.Drawing.Color.Gainsboro;
            this.trapCount.Location = new System.Drawing.Point(187, 22);
            this.trapCount.Name = "trapCount";
            this.trapCount.Size = new System.Drawing.Size(128, 18);
            this.trapCount.TabIndex = 1;
            this.trapCount.Text = "Traps left: 0";
            // 
            // healthLabel
            // 
            this.healthLabel.AutoSize = true;
            this.healthLabel.BackColor = System.Drawing.Color.DimGray;
            this.healthLabel.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.healthLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.healthLabel.Location = new System.Drawing.Point(338, 22);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(104, 18);
            this.healthLabel.TabIndex = 2;
            this.healthLabel.Text = "Health: 00";
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.BackColor = System.Drawing.Color.DimGray;
            this.levelLabel.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.levelLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.levelLabel.Location = new System.Drawing.Point(824, 20);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(81, 18);
            this.levelLabel.TabIndex = 3;
            this.levelLabel.Text = "Level: 0";
            // 
            // waveLabel
            // 
            this.waveLabel.AutoSize = true;
            this.waveLabel.BackColor = System.Drawing.Color.DimGray;
            this.waveLabel.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.waveLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.waveLabel.Location = new System.Drawing.Point(938, 22);
            this.waveLabel.Name = "waveLabel";
            this.waveLabel.Size = new System.Drawing.Size(77, 18);
            this.waveLabel.TabIndex = 4;
            this.waveLabel.Text = "Wave: 0";
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.AutoSize = true;
            this.difficultyLabel.BackColor = System.Drawing.Color.DimGray;
            this.difficultyLabel.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.difficultyLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.difficultyLabel.Location = new System.Drawing.Point(1052, 22);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(123, 18);
            this.difficultyLabel.TabIndex = 5;
            this.difficultyLabel.Text = "Difficulty: 0";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.DimGray;
            this.scoreLabel.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scoreLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.scoreLabel.Location = new System.Drawing.Point(549, 20);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(111, 18);
            this.scoreLabel.TabIndex = 6;
            this.scoreLabel.Text = "Score: 0000";
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
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
