using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectWars
{
   public class Soldier
    {
        //1. İki asker nesnesi çarpışacak.
        //2. Army isminde bir sınıfınız olsun. Soldiers koleksiyonuna asker eklensin.

        public int HitPoint { get; set; }
        public int Health { get; set; } = 100;

        public int Armor { get; set; } = 2;

        public Weapon Weapon { get; set; }

        public void Attack(Soldier enemy)
        {
            
        }

        public bool IsAlive { get; set; }


    }
}
