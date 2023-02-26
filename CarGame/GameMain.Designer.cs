namespace CarGame
{
    partial class GameMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameMain));
            this.deathsValueLabel = new System.Windows.Forms.Label();
            this.highScoreValueLabel = new System.Windows.Forms.Label();
            this.scoreValueLabel = new System.Windows.Forms.Label();
            this.deathLabel = new System.Windows.Forms.Label();
            this.highScoreLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.removingAndSpawningObjects = new System.Windows.Forms.Timer(this.components);
            this.objectsMovement = new System.Windows.Forms.Timer(this.components);
            this.userInfoLabel = new System.Windows.Forms.Label();
            this.difficultyLabelValue = new System.Windows.Forms.Label();
            this.difficultyLabel = new System.Windows.Forms.Label();
            this.playerObject = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.playerObject)).BeginInit();
            this.SuspendLayout();
            // 
            // deathsValueLabel
            // 
            this.deathsValueLabel.AutoSize = true;
            this.deathsValueLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deathsValueLabel.Location = new System.Drawing.Point(110, 38);
            this.deathsValueLabel.Margin = new System.Windows.Forms.Padding(3);
            this.deathsValueLabel.Name = "deathsValueLabel";
            this.deathsValueLabel.Size = new System.Drawing.Size(14, 15);
            this.deathsValueLabel.TabIndex = 15;
            this.deathsValueLabel.Text = "0";
            // 
            // highScoreValueLabel
            // 
            this.highScoreValueLabel.AutoSize = true;
            this.highScoreValueLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.highScoreValueLabel.Location = new System.Drawing.Point(110, 23);
            this.highScoreValueLabel.Margin = new System.Windows.Forms.Padding(3);
            this.highScoreValueLabel.Name = "highScoreValueLabel";
            this.highScoreValueLabel.Size = new System.Drawing.Size(14, 15);
            this.highScoreValueLabel.TabIndex = 14;
            this.highScoreValueLabel.Text = "0";
            // 
            // scoreValueLabel
            // 
            this.scoreValueLabel.AutoSize = true;
            this.scoreValueLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scoreValueLabel.Location = new System.Drawing.Point(110, 8);
            this.scoreValueLabel.Margin = new System.Windows.Forms.Padding(3);
            this.scoreValueLabel.Name = "scoreValueLabel";
            this.scoreValueLabel.Size = new System.Drawing.Size(14, 15);
            this.scoreValueLabel.TabIndex = 13;
            this.scoreValueLabel.Text = "0";
            // 
            // deathLabel
            // 
            this.deathLabel.AutoSize = true;
            this.deathLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deathLabel.Location = new System.Drawing.Point(8, 38);
            this.deathLabel.Margin = new System.Windows.Forms.Padding(3);
            this.deathLabel.Name = "deathLabel";
            this.deathLabel.Size = new System.Drawing.Size(56, 15);
            this.deathLabel.TabIndex = 12;
            this.deathLabel.Text = "Deaths:";
            // 
            // highScoreLabel
            // 
            this.highScoreLabel.AutoSize = true;
            this.highScoreLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.highScoreLabel.Location = new System.Drawing.Point(8, 23);
            this.highScoreLabel.Margin = new System.Windows.Forms.Padding(3);
            this.highScoreLabel.Name = "highScoreLabel";
            this.highScoreLabel.Size = new System.Drawing.Size(84, 15);
            this.highScoreLabel.TabIndex = 11;
            this.highScoreLabel.Text = "High score:";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scoreLabel.Location = new System.Drawing.Point(8, 8);
            this.scoreLabel.Margin = new System.Windows.Forms.Padding(3);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(56, 15);
            this.scoreLabel.TabIndex = 10;
            this.scoreLabel.Text = "Score: ";
            // 
            // removingAndSpawningObjects
            // 
            this.removingAndSpawningObjects.Interval = 500;
            this.removingAndSpawningObjects.Tick += new System.EventHandler(this.removingAndSpawningObjects_Tick);
            // 
            // objectsMovement
            // 
            this.objectsMovement.Interval = 250;
            this.objectsMovement.Tick += new System.EventHandler(this.objectsMovement_Tick);
            // 
            // userInfoLabel
            // 
            this.userInfoLabel.AutoSize = true;
            this.userInfoLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.userInfoLabel.Location = new System.Drawing.Point(228, 217);
            this.userInfoLabel.Name = "userInfoLabel";
            this.userInfoLabel.Size = new System.Drawing.Size(18, 19);
            this.userInfoLabel.TabIndex = 19;
            this.userInfoLabel.Text = "0";
            this.userInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // difficultyLabelValue
            // 
            this.difficultyLabelValue.AutoSize = true;
            this.difficultyLabelValue.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.difficultyLabelValue.Location = new System.Drawing.Point(110, 53);
            this.difficultyLabelValue.Margin = new System.Windows.Forms.Padding(3);
            this.difficultyLabelValue.Name = "difficultyLabelValue";
            this.difficultyLabelValue.Size = new System.Drawing.Size(14, 15);
            this.difficultyLabelValue.TabIndex = 18;
            this.difficultyLabelValue.Text = "0";
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.AutoSize = true;
            this.difficultyLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.difficultyLabel.Location = new System.Drawing.Point(8, 53);
            this.difficultyLabel.Margin = new System.Windows.Forms.Padding(3);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(84, 15);
            this.difficultyLabel.TabIndex = 17;
            this.difficultyLabel.Text = "Difficulty:";
            // 
            // playerObject
            // 
            this.playerObject.BackgroundImage = global::CarGame.Properties.Resources.playerObjectIcon;
            this.playerObject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playerObject.Location = new System.Drawing.Point(-8, 355);
            this.playerObject.Margin = new System.Windows.Forms.Padding(0);
            this.playerObject.Name = "playerObject";
            this.playerObject.Size = new System.Drawing.Size(100, 100);
            this.playerObject.TabIndex = 16;
            this.playerObject.TabStop = false;
            // 
            // GameMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(480, 457);
            this.Controls.Add(this.deathsValueLabel);
            this.Controls.Add(this.highScoreValueLabel);
            this.Controls.Add(this.scoreValueLabel);
            this.Controls.Add(this.deathLabel);
            this.Controls.Add(this.highScoreLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.userInfoLabel);
            this.Controls.Add(this.difficultyLabelValue);
            this.Controls.Add(this.difficultyLabel);
            this.Controls.Add(this.playerObject);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarGame";
            this.Load += new System.EventHandler(this.gameMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameMain_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.playerObject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label deathsValueLabel;
        private System.Windows.Forms.Label highScoreValueLabel;
        private System.Windows.Forms.Label scoreValueLabel;
        private System.Windows.Forms.Label deathLabel;
        private System.Windows.Forms.Label highScoreLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Timer removingAndSpawningObjects;
        private System.Windows.Forms.Timer objectsMovement;
        private System.Windows.Forms.Label userInfoLabel;
        private System.Windows.Forms.Label difficultyLabelValue;
        private System.Windows.Forms.Label difficultyLabel;
        private System.Windows.Forms.PictureBox playerObject;
    }
}

