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
    public partial class Which_Card_Game : Form {
        public Which_Card_Game() {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            if (selectComboBox.Text == "Twenty-one") {
                Form Game = new Twenty_One();
                Game.Show();
            } else if (selectComboBox.Text == "Crazy Eights") {
                Form Game = new Crazy_Eights();
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
