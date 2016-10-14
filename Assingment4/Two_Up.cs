using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Games_Logic_Library;

namespace Assingment4 {
    public partial class Two_Up : Form {
        int playerScore = 0;
        int computerScore = 0;

        private void UpdatePictureBoxImage(PictureBox whichPB, bool isHeads) {
            whichPB.Image = Images.GetCoinImage(isHeads);
        }// end UpdatePictureBoxImage

        public Two_Up() {
            InitializeComponent();
            Two_Up_Game.SetupGame();
            UpdateImages();

        }

        public void UpdateImages() {
            UpdatePictureBoxImage(playerPictureBox, Two_Up_Game.IsHeads(1));
            UpdatePictureBoxImage(computerPictureBox, Two_Up_Game.IsHeads(2));
        }



        private void Two_Up_Load(object sender, EventArgs e) {

        }

        private void cancelGameButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void playAgainButton_Click(object sender, EventArgs e) {
            throwCoinsButton.Enabled = true;
            playAgainButton.Visible = false;
            Two_Up_Game.SetupGame();
        }

        private void throwCoinsButton_Click(object sender, EventArgs e) {
            playAgainButton.Visible = true;
            Two_Up_Game.TossCoins();
            string outcome = Two_Up_Game.TossOutcome();
            if (outcome == "Heads") {
                playerScore++;
                winnerLabel.Text = "Heads";
                throwCoinsButton.Enabled = false;
            } else if (outcome == "Tails") {
                computerScore++;
                winnerLabel.Text = "Tails";
                throwCoinsButton.Enabled = false;
            } else {
                winnerLabel.Text = "Odds";
                playAgainButton.Visible = false;
            }
            playerScoreLabel.Text = playerScore.ToString();
            computerScoreLabel.Text = computerScore.ToString();
            UpdateImages();
            winnerLabel.Visible = true;
        }
    }
}
