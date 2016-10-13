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
    public partial class Which_Dice_Game : Form {
        public Which_Dice_Game() {
            InitializeComponent();
        }

        private void gameSelectComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (gameSelectComboBox.Text == "Snake Eyes") {
                Form Game = new Snake_Eyes();
                Game.Show();
            } else if (gameSelectComboBox.Text == "Ship Captain and Crew") {
                Form Game = new Ship_Captain_Crew();
                Game.Show();
            }
        }

        private void exitButton_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Do you really want to quit?",
                                            "Quit?",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
            // If the user clicked the Yes button
            if (result == DialogResult.Yes) {
                Close();
            }

        }
    }
}
