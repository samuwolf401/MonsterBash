
namespace MonsterBash
{
    partial class EndScreen
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
            this.label = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.retryButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.Font = new System.Drawing.Font("Algerian", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label.Location = new System.Drawing.Point(200, 50);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(800, 110);
            this.label.TabIndex = 0;
            this.label.Text = "GAME OVER";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scoreLabel
            // 
            this.scoreLabel.Font = new System.Drawing.Font("Algerian", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreLabel.Location = new System.Drawing.Point(400, 220);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(400, 50);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "Final Score = ";
            // 
            // retryButton
            // 
            this.retryButton.BackColor = System.Drawing.Color.White;
            this.retryButton.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.retryButton.Location = new System.Drawing.Point(400, 353);
            this.retryButton.Name = "retryButton";
            this.retryButton.Size = new System.Drawing.Size(400, 100);
            this.retryButton.TabIndex = 2;
            this.retryButton.Text = "Start Over";
            this.retryButton.UseVisualStyleBackColor = false;
            this.retryButton.Click += new System.EventHandler(this.retryButton_Click);
            this.retryButton.Enter += new System.EventHandler(this.retryButton_Enter);
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.White;
            this.menuButton.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuButton.Location = new System.Drawing.Point(400, 459);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(400, 100);
            this.menuButton.TabIndex = 3;
            this.menuButton.Text = "Main Menu";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            this.menuButton.Enter += new System.EventHandler(this.menuButton_Enter);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.White;
            this.exitButton.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitButton.Location = new System.Drawing.Point(400, 565);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(400, 100);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.Enter += new System.EventHandler(this.exitButton_Enter);
            // 
            // EndScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.retryButton);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.label);
            this.Name = "EndScreen";
            this.Size = new System.Drawing.Size(1200, 700);
            this.Load += new System.EventHandler(this.EndScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Button retryButton;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Button exitButton;
    }
}
