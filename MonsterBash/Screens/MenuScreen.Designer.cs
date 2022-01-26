
namespace MonsterBash
{
    partial class MenuScreen
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
            this.startButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.instrustionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.White;
            this.startButton.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startButton.Location = new System.Drawing.Point(14, 433);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(450, 120);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            this.startButton.Enter += new System.EventHandler(this.startButton_Enter);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.White;
            this.exitButton.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitButton.Location = new System.Drawing.Point(14, 559);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(450, 120);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.Enter += new System.EventHandler(this.exitButton_Enter);
            // 
            // scoreLabel
            // 
            this.scoreLabel.BackColor = System.Drawing.Color.White;
            this.scoreLabel.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreLabel.Location = new System.Drawing.Point(14, 106);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(450, 307);
            this.scoreLabel.TabIndex = 2;
            this.scoreLabel.Text = "score stuff";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.IndianRed;
            this.label1.Font = new System.Drawing.Font("Algerian", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(225, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(750, 103);
            this.label1.TabIndex = 3;
            this.label1.Text = "MONSTER BASH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // instrustionLabel
            // 
            this.instrustionLabel.BackColor = System.Drawing.Color.White;
            this.instrustionLabel.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.instrustionLabel.Location = new System.Drawing.Point(487, 106);
            this.instrustionLabel.Name = "instrustionLabel";
            this.instrustionLabel.Size = new System.Drawing.Size(700, 187);
            this.instrustionLabel.TabIndex = 4;
            this.instrustionLabel.Text = "test";
            this.instrustionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.Controls.Add(this.instrustionLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.startButton);
            this.Name = "MenuScreen";
            this.Size = new System.Drawing.Size(1200, 700);
            this.Load += new System.EventHandler(this.MenuScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label instrustionLabel;
    }
}
