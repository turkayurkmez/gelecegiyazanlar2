using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
  public  class Dice
    {
        public int Number { get; private set; }
        public void GenerateNumber()
        {
            Number = new Random().Next(1, 7);
        }

    }
}
