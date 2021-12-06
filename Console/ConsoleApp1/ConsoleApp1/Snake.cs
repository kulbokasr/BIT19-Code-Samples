using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Snake : NPC
    {
  
        public void BiteEnemy()
        {
            Console.WriteLine("You bit enemy dealing -30 damage");
        }
    }
}
