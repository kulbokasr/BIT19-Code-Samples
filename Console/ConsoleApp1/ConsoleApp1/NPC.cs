using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class NPC  // : Object - visada nutylimai paveldi
    {
        public string Name { get; set; } 
        public int Level { get; set; } = 3;
        public int Hitpoints { get; set; }
        public int Strength { get; set; }
        public int Dextirity { get; set; }

    

        public void Attack()
        {
            var random = new Random();
            var randomBool = random.Next(1,3) == 1;
            if (randomBool)
            { 
                Console.WriteLine("You attacked" + Name + "and you won");
            }
            else
            { 
                Console.WriteLine("You attacked" + Name + "and you won");
            }
        }

    }
}
