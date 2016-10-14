using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Low_Level_Objects_Library;

namespace Games_Logic_Library {
    public static class Two_Up_Game {
        private static Coin coin1 = new Coin();
        private static Coin coin2 = new Coin();
        private static int playersScore, computersScore;

        public static void SetupGame() {
            playersScore = 0;
            computersScore = 0;
            Coin coin1 = new Coin();
            Coin coin2 = new Coin();
        }

        public static void TossCoins() {
            coin1.Flip();
            coin2.Flip();
        }

        public static string TossOutcome() {
            if (coin1.IsHeads()) {
                if (coin2.IsHeads()) {
                    return "Heads";
                } else {
                    return "Odds";
                }
                } else {
                    if (coin2.IsHeads()) {
                    return "Odds";
                    } else {
                    return "Tails";
                }
            }
        }
        

        public static bool IsHeads(int whichCoin) {
            if (whichCoin == 1) {
                if (coin1.IsHeads()) {
                    return true;
                } else {
                    return false;
                }
            }
            if (whichCoin == 2) {
                if (coin2.IsHeads()) {
                   return true;
                } else {
                    return false;
                }
            } else {
                return false;
            }
        }

        public static int GetPlayersScore() {
            return playersScore;
        }

        public static int GetComputersScore() {
            return computersScore;
        }
    }
}
