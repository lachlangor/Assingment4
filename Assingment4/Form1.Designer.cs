namespace Assingment4 {
    partial class Games {
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
            this.worldLabel = new System.Windows.Forms.Label();
            this.buttonsGroupBox = new System.Windows.Forms.GroupBox();
            this.coinRadioButton = new System.Windows.Forms.RadioButton();
            this.diceRadioButton = new System.Windows.Forms.RadioButton();
            this.cardRadioButton = new System.Windows.Forms.RadioButton();
            this.startButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.buttonsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // worldLabel
            // 
            this.worldLabel.AutoSize = true;
            this.worldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.worldLabel.Location = new System.Drawing.Point(90, 31);
            this.worldLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.worldLabel.Name = "worldLabel";
            this.worldLabel.Size = new System.Drawing.Size(198, 37);
            this.worldLabel.TabIndex = 0;
            this.worldLabel.Text = "Game World";
            // 
            // buttonsGroupBox
            // 
            this.buttonsGroupBox.Controls.Add(this.coinRadioButton);
            this.buttonsGroupBox.Controls.Add(this.diceRadioButton);
            this.buttonsGroupBox.Controls.Add(this.cardRadioButton);
            this.buttonsGroupBox.Location = new System.Drawing.Point(42, 98);
            this.buttonsGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonsGroupBox.Name = "buttonsGroupBox";
            this.buttonsGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonsGroupBox.Size = new System.Drawing.Size(338, 231);
            this.buttonsGroupBox.TabIndex = 1;
            this.buttonsGroupBox.TabStop = false;
            this.buttonsGroupBox.Text = "Select Game Type";
            // 
            // coinRadioButton
            // 
            this.coinRadioButton.AutoSize = true;
            this.coinRadioButton.Location = new System.Drawing.Point(56, 48);
            this.coinRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.coinRadioButton.Name = "coinRadioButton";
            this.coinRadioButton.Size = new System.Drawing.Size(114, 24);
            this.coinRadioButton.TabIndex = 0;
            this.coinRadioButton.Text = "Coin Game";
            this.coinRadioButton.UseVisualStyleBackColor = true;
            this.coinRadioButton.CheckedChanged += new System.EventHandler(this.Coin_CheckedChanged);
            // 
            // diceRadioButton
            // 
            this.diceRadioButton.AutoSize = true;
            this.diceRadioButton.Location = new System.Drawing.Point(56, 111);
            this.diceRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.diceRadioButton.Name = "diceRadioButton";
            this.diceRadioButton.Size = new System.Drawing.Size(114, 24);
            this.diceRadioButton.TabIndex = 1;
            this.diceRadioButton.TabStop = true;
            this.diceRadioButton.Text = "Dice Game";
            this.diceRadioButton.UseVisualStyleBackColor = true;
            this.diceRadioButton.CheckedChanged += new System.EventHandler(this.Dice_CheckedChanged);
            // 
            // cardRadioButton
            // 
            this.cardRadioButton.AutoSize = true;
            this.cardRadioButton.Location = new System.Drawing.Point(56, 171);
            this.cardRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cardRadioButton.Name = "cardRadioButton";
            this.cardRadioButton.Size = new System.Drawing.Size(116, 24);
            this.cardRadioButton.TabIndex = 2;
            this.cardRadioButton.TabStop = true;
            this.cardRadioButton.Text = "Card Game";
            this.cardRadioButton.UseVisualStyleBackColor = true;
            this.cardRadioButton.CheckedChanged += new System.EventHandler(this.Card_CheckedChanged);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(42, 383);
            this.startButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(112, 35);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(213, 383);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(112, 35);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Games
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 500);
            this.Controls.Add(this.worldLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.buttonsGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Games";
            this.Text = "Games";
            this.buttonsGroupBox.ResumeLayout(false);
            this.buttonsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label worldLabel;
        private System.Windows.Forms.GroupBox buttonsGroupBox;
        private System.Windows.Forms.RadioButton cardRadioButton;
        private System.Windows.Forms.RadioButton diceRadioButton;
        private System.Windows.Forms.RadioButton coinRadioButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button exitButton;
    }
}

