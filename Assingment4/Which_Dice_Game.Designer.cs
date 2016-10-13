namespace Assingment4 {
    partial class Which_Dice_Game {
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
            this.chooseGameLabel = new System.Windows.Forms.Label();
            this.gameSelectComboBox = new System.Windows.Forms.ComboBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chooseGameLabel
            // 
            this.chooseGameLabel.AutoSize = true;
            this.chooseGameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.chooseGameLabel.Location = new System.Drawing.Point(32, 45);
            this.chooseGameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.chooseGameLabel.Name = "chooseGameLabel";
            this.chooseGameLabel.Size = new System.Drawing.Size(356, 37);
            this.chooseGameLabel.TabIndex = 0;
            this.chooseGameLabel.Text = "Choose a Game to Play";
            // 
            // gameSelectComboBox
            // 
            this.gameSelectComboBox.FormattingEnabled = true;
            this.gameSelectComboBox.Items.AddRange(new object[] {
            "Snake Eyes",
            "Ship Captain and Crew"});
            this.gameSelectComboBox.Location = new System.Drawing.Point(63, 135);
            this.gameSelectComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gameSelectComboBox.Name = "gameSelectComboBox";
            this.gameSelectComboBox.Size = new System.Drawing.Size(286, 28);
            this.gameSelectComboBox.TabIndex = 1;
            this.gameSelectComboBox.SelectedIndexChanged += new System.EventHandler(this.gameSelectComboBox_SelectedIndexChanged);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(63, 243);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(288, 49);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Which_Dice_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 402);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.gameSelectComboBox);
            this.Controls.Add(this.chooseGameLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Which_Dice_Game";
            this.Text = "Which_Dice_Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chooseGameLabel;
        private System.Windows.Forms.ComboBox gameSelectComboBox;
        private System.Windows.Forms.Button exitButton;
    }
}