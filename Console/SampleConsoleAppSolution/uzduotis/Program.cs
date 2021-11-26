using System;
using System.Collections.Generic;
using System.Linq;


namespace WorkingWithLists
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1

            //string name = " Ramunas";
            //string surname = " Kulbokas";
            //int birthyear = 1989;
            //int currentyear = 2021;
            //Console.WriteLine("As esu" + name + surname + "." + " Man yra " + (currentyear - birthyear ) + " metai");

            //2

            //string[] students = new string[7];
            //students[0] = "Pirmas";
            //students[1] = "Antras";
            //students[2] = "Trecias";
            //students[3] = "Ketvirtas";
            //students[4] = "Penktas";
            //students[5] = "Sestas";
            //students[6] = "Septintas";

            //for (int i = 0; i < students.Length; i++)
            //{
            //    Console.Write(students[i] + " ");
            //}

            //foreach (string student in students)
            //{ Console.WriteLine(student); }

            //3

            //int[] numbers = new int[5];

            //Random rand = new Random();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //       numbers[i] = rand.Next(5, 11);
            //}

            //int[] numsMore = new int[10];

            //for (int i = 0;i < numbers.Length; i++)
            //{
            //    numsMore[i] = numbers[i];
            //}

            //for (int i = numbers.Length; i < numsMore.Length; i++)
            //{
            //    numsMore[i] = rand.Next(5, 11);
            //}

            //foreach (int i in numsMore)
            //{
            //    Console.WriteLine(i);
            //}


            //4

            //int[,] calculus = new int[10, 10];

            //for (int i = 0; i < calculus.GetLength(0); i++)
            //{
            //    for (int j = 0; j < calculus.GetLength(1); j++)
            //    {
            //        calculus[i, j] = i*j;
            //    }
            //}

            //for (int i = 0; i < calculus.GetLength(0); i++)
            //{
            //    for (int j = 0; j < calculus.GetLength(1); j++)
            //    {
            //       // Console.Write(calculus[i, j] + "\t");
            //        Console.Write("["+calculus[i, j] + "]");

            //    }
            //    Console.WriteLine();
            //}

            //5


            //bool badInput = true;
            //int a = 0, b = 0, c = 0;

            //while (badInput)
            //{
            //    Console.WriteLine("Irasykite tris krastines");
            //    try
            //    {
            //        a = Convert.ToInt32(Console.ReadLine());
            //        b = Convert.ToInt32(Console.ReadLine());
            //        c = Convert.ToInt32(Console.ReadLine());
            //        badInput = false;
            //    }
            //    catch (Exception e) { }

            //}

            //if (a > 0 && a < 11 && b > 0 && b < 11 && c > 0 && c < 11)
            //{

            //    if (a + b > c && a + c > b && b + c > a)
            //    {
            //        Console.WriteLine("Galima");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Negalima");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Skaiciai negalimi");
            //}

            //6

            //Random rand = new Random();
            //int candles = rand.Next(5, 3000);
            //double discount = 1;
            //double price = 1;
            //if (2000 < ((double)candles * price))
            //{
            //    discount = 0.96;
            //}
            //else if (1000 < ((double)candles * price))
            //{
            //    discount = 0.97;
            //}
            //Console.WriteLine("Zvakiu pirko " + candles);
            //Console.WriteLine("Sumokejo " + ((double)candles * price * discount));


        }
    }
}