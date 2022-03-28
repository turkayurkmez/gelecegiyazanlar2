using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
   public class Player
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        public List<Dice> DiceObjects { get; set; } = new List<Dice>(2);

        public void ThrowDice()
        {
            foreach (var dice in DiceObjects)
            {
                dice.GenerateNumber();
                Score += dice.Number;
            } 
        }

        public int Score { get; set; }


    }
}
