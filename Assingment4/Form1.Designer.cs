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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Coin = new System.Windows.Forms.RadioButton();
            this.Dice = new System.Windows.Forms.RadioButton();
            this.Card = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(60, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game World";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Card);
            this.groupBox1.Controls.Add(this.Dice);
            this.groupBox1.Controls.Add(this.Coin);
            this.groupBox1.Location = new System.Drawing.Point(28, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 150);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Game Type";
            // 
            // Coin
            // 
            this.Coin.AutoSize = true;
            this.Coin.Location = new System.Drawing.Point(37, 31);
            this.Coin.Name = "Coin";
            this.Coin.Size = new System.Drawing.Size(77, 17);
            this.Coin.TabIndex = 0;
            this.Coin.TabStop = true;
            this.Coin.Text = "Coin Game";
            this.Coin.UseVisualStyleBackColor = true;
            this.Coin.CheckedChanged += new System.EventHandler(this.Coin_CheckedChanged);
            // 
            // Dice
            // 
            this.Dice.AutoSize = true;
            this.Dice.Location = new System.Drawing.Point(37, 72);
            this.Dice.Name = "Dice";
            this.Dice.Size = new System.Drawing.Size(78, 17);
            this.Dice.TabIndex = 1;
            this.Dice.TabStop = true;
            this.Dice.Text = "Dice Game";
            this.Dice.UseVisualStyleBackColor = true;
            this.Dice.CheckedChanged += new System.EventHandler(this.Dice_CheckedChanged);
            // 
            // Card
            // 
            this.Card.AutoSize = true;
            this.Card.Location = new System.Drawing.Point(37, 111);
            this.Card.Name = "Card";
            this.Card.Size = new System.Drawing.Size(78, 17);
            this.Card.TabIndex = 2;
            this.Card.TabStop = true;
            this.Card.Text = "Card Game";
            this.Card.UseVisualStyleBackColor = true;
            this.Card.CheckedChanged += new System.EventHandler(this.Card_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(142, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Games
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 325);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Games";
            this.Text = "Games";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Card;
        private System.Windows.Forms.RadioButton Dice;
        private System.Windows.Forms.RadioButton Coin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

