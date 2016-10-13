namespace Assingment4 {
    partial class Two_Up {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.playerPictureBox = new System.Windows.Forms.PictureBox();
            this.computerPictureBox = new System.Windows.Forms.PictureBox();
            this.winnerLabel = new System.Windows.Forms.Label();
            this.playerTextLabel = new System.Windows.Forms.Label();
            this.computerTextLabel = new System.Windows.Forms.Label();
            this.playerScoreLabel = new System.Windows.Forms.Label();
            this.computerScoreLabel = new System.Windows.Forms.Label();
            this.throwCoinsButton = new System.Windows.Forms.Button();
            this.playAgainButton = new System.Windows.Forms.Button();
            this.cancelGameButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // playerPictureBox
            // 
            this.playerPictureBox.Location = new System.Drawing.Point(38, 71);
            this.playerPictureBox.Name = "playerPictureBox";
            this.playerPictureBox.Size = new System.Drawing.Size(150, 150);
            this.playerPictureBox.TabIndex = 0;
            this.playerPictureBox.TabStop = false;
            // 
            // computerPictureBox
            // 
            this.computerPictureBox.Location = new System.Drawing.Point(250, 71);
            this.computerPictureBox.Name = "computerPictureBox";
            this.computerPictureBox.Size = new System.Drawing.Size(150, 150);
            this.computerPictureBox.TabIndex = 1;
            this.computerPictureBox.TabStop = false;
            // 
            // winnerLabel
            // 
            this.winnerLabel.AutoSize = true;
            this.winnerLabel.Location = new System.Drawing.Point(458, 136);
            this.winnerLabel.Name = "winnerLabel";
            this.winnerLabel.Size = new System.Drawing.Size(51, 20);
            this.winnerLabel.TabIndex = 2;
            this.winnerLabel.Text = "label1";
            this.winnerLabel.Visible = false;
            // 
            // playerTextLabel
            // 
            this.playerTextLabel.AutoSize = true;
            this.playerTextLabel.Location = new System.Drawing.Point(34, 247);
            this.playerTextLabel.Name = "playerTextLabel";
            this.playerTextLabel.Size = new System.Drawing.Size(113, 20);
            this.playerTextLabel.TabIndex = 3;
            this.playerTextLabel.Text = "Player\'s Score:";
            // 
            // computerTextLabel
            // 
            this.computerTextLabel.AutoSize = true;
            this.computerTextLabel.Location = new System.Drawing.Point(246, 247);
            this.computerTextLabel.Name = "computerTextLabel";
            this.computerTextLabel.Size = new System.Drawing.Size(140, 20);
            this.computerTextLabel.TabIndex = 4;
            this.computerTextLabel.Text = "Computer\'s Score:";
            // 
            // playerScoreLabel
            // 
            this.playerScoreLabel.AutoSize = true;
            this.playerScoreLabel.BackColor = System.Drawing.Color.White;
            this.playerScoreLabel.Location = new System.Drawing.Point(153, 247);
            this.playerScoreLabel.Name = "playerScoreLabel";
            this.playerScoreLabel.Size = new System.Drawing.Size(18, 20);
            this.playerScoreLabel.TabIndex = 5;
            this.playerScoreLabel.Text = "0";
            // 
            // computerScoreLabel
            // 
            this.computerScoreLabel.AutoSize = true;
            this.computerScoreLabel.BackColor = System.Drawing.Color.White;
            this.computerScoreLabel.Location = new System.Drawing.Point(392, 247);
            this.computerScoreLabel.Name = "computerScoreLabel";
            this.computerScoreLabel.Size = new System.Drawing.Size(18, 20);
            this.computerScoreLabel.TabIndex = 6;
            this.computerScoreLabel.Text = "0";
            // 
            // throwCoinsButton
            // 
            this.throwCoinsButton.Location = new System.Drawing.Point(26, 360);
            this.throwCoinsButton.Name = "throwCoinsButton";
            this.throwCoinsButton.Size = new System.Drawing.Size(136, 31);
            this.throwCoinsButton.TabIndex = 7;
            this.throwCoinsButton.Text = "Throw Coins";
            this.throwCoinsButton.UseVisualStyleBackColor = true;
            // 
            // playAgainButton
            // 
            this.playAgainButton.Location = new System.Drawing.Point(195, 360);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(126, 32);
            this.playAgainButton.TabIndex = 8;
            this.playAgainButton.Text = "Play Again";
            this.playAgainButton.UseVisualStyleBackColor = true;
            this.playAgainButton.Visible = false;
            // 
            // cancelGameButton
            // 
            this.cancelGameButton.Location = new System.Drawing.Point(368, 360);
            this.cancelGameButton.Name = "cancelGameButton";
            this.cancelGameButton.Size = new System.Drawing.Size(126, 32);
            this.cancelGameButton.TabIndex = 9;
            this.cancelGameButton.Text = "Cancel Game";
            this.cancelGameButton.UseVisualStyleBackColor = true;
            // 
            // Two_Up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 471);
            this.Controls.Add(this.cancelGameButton);
            this.Controls.Add(this.playAgainButton);
            this.Controls.Add(this.throwCoinsButton);
            this.Controls.Add(this.computerScoreLabel);
            this.Controls.Add(this.playerScoreLabel);
            this.Controls.Add(this.computerTextLabel);
            this.Controls.Add(this.playerTextLabel);
            this.Controls.Add(this.winnerLabel);
            this.Controls.Add(this.computerPictureBox);
            this.Controls.Add(this.playerPictureBox);
            this.Name = "Two_Up";
            this.Text = "Two_Up";
            this.Load += new System.EventHandler(this.Two_Up_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox playerPictureBox;
        private System.Windows.Forms.PictureBox computerPictureBox;
        private System.Windows.Forms.Label winnerLabel;
        private System.Windows.Forms.Label playerTextLabel;
        private System.Windows.Forms.Label computerTextLabel;
        private System.Windows.Forms.Label playerScoreLabel;
        private System.Windows.Forms.Label computerScoreLabel;
        private System.Windows.Forms.Button throwCoinsButton;
        private System.Windows.Forms.Button playAgainButton;
        private System.Windows.Forms.Button cancelGameButton;
    }
}