using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assingment4 {
    public partial class Games : Form {
        public Games() {
            InitializeComponent();
            startButton.Enabled = false;

        }

        private void Coin_CheckedChanged(object sender, EventArgs e) {
            coinRadioButton.Checked = true;
            startButton.Enabled = true;
        }

        private void Dice_CheckedChanged(object sender, EventArgs e) {
            startButton.Enabled = true;
        }

        private void Card_CheckedChanged(object sender, EventArgs e) {
            startButton.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e) {
            if (coinRadioButton.Checked){
                Form GameForm = new Two_Up();
                GameForm.Show();
                } else if (diceRadioButton.Checked) {
                Form GameForm = new Which_Dice_Game();
                GameForm.Show();
                } else if (cardRadioButton.Checked) {
                Form GameForm = new Which_Card_Game();
                GameForm.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
