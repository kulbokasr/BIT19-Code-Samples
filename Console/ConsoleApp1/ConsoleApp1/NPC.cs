using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class NPC  // : Object - visada nutylimai paveldi
    {
        public string Name { get; set; } // speju tavo litas mato viska kaip npc. npc.. name yra tuscias nes pas triusi sukuri nauja neima. bandom.
        public int Level { get; set; } = 3;
        public int Hitpoints { get; set; }
        public int Strength { get; set; }
        public int Dextirity { get; set; }

    

        public void Attack()
        {
            Random random = new Random();
            bool randomBool = random.Next(0,2) == 0;
            if (randomBool)
            { 
                Console.WriteLine("You attacked " + Name + " and you won");
            }
            else
            { 
                Console.WriteLine("You attacked " + Name + " and you lost");
            }
        }

    }
}
