using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
   public class Game
    {
        public Player PlayerOne { get; set; }
        public Player PlayerTwo { get; set; }

        public Player Winner { get; set; }

        public void PlayerOneThrowDice()
        {
            PlayerOne.ThrowDice();
        }

        public void PlayerTwoThrowDice()
        {
            PlayerTwo.ThrowDice();
        }

        

        public void CompareScores()
        {
            if (PlayerOne.Score > PlayerTwo.Score)
            {
                Winner = PlayerOne;
            }
            else if (PlayerOne.Score < PlayerTwo.Score)
            {
                Winner = PlayerTwo;
            }
            else
            {
                Winner = null;
            }
           
        }
    }
}
