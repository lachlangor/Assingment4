namespace Assingment4 {
    partial class Which_Card_Game {
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
            this.exitButton = new System.Windows.Forms.Button();
            this.selectComboBox = new System.Windows.Forms.ComboBox();
            this.chooseGameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(68, 251);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(288, 49);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // selectComboBox
            // 
            this.selectComboBox.FormattingEnabled = true;
            this.selectComboBox.Items.AddRange(new object[] {
            "Twenty-one",
            "Crazy Eights"});
            this.selectComboBox.Location = new System.Drawing.Point(68, 143);
            this.selectComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.selectComboBox.Name = "selectComboBox";
            this.selectComboBox.Size = new System.Drawing.Size(286, 28);
            this.selectComboBox.TabIndex = 4;
            this.selectComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // chooseGameLabel
            // 
            this.chooseGameLabel.AutoSize = true;
            this.chooseGameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.chooseGameLabel.Location = new System.Drawing.Point(22, 52);
            this.chooseGameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.chooseGameLabel.Name = "chooseGameLabel";
            this.chooseGameLabel.Size = new System.Drawing.Size(356, 37);
            this.chooseGameLabel.TabIndex = 3;
            this.chooseGameLabel.Text = "Choose a Game to Play";
            // 
            // Which_Card_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 395);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.selectComboBox);
            this.Controls.Add(this.chooseGameLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Which_Card_Game";
            this.Text = "Which_Card_Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ComboBox selectComboBox;
        private System.Windows.Forms.Label chooseGameLabel;
    }
}