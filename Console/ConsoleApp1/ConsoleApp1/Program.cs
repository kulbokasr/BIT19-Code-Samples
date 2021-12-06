using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<NPC> animals = new List<NPC>();

            Aligator a = new Aligator();
            Snake s = new Snake();
            AngryRabbit ar = new AngryRabbit();

            animals.Add(a);
            animals.Add(s);
            animals.Add(ar);

            a.Name = "Aligator";
            s.Name = "Snake";
            ar.Name = "AngryRabbit";


            while (true)
            {
                Random rand = new Random();
                int rand1 = rand.Next(0, 3);
                Console.WriteLine($"Do you want to attack {animals[rand1].Name} ? Reply Yes or No");
                var command = Console.ReadLine().ToLower();
                if (command == "yes")
                {
                    animals[rand1].Attack();
                }
                else break;

            }
        }
    }
}
