﻿using System;
using System.Collections.Generic;
using System.Linq;


//kintamieji visada is mazosios, jeigu keli zodziai vienasDuTrys 
//klases visada vienaskaita ir is didziosios

namespace WorkingWithLists
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //List<string> names = new List<string>();
            //names.Add("Ramunas");
            //names.Add("Vaidas");
            //names.Add("Tautvydas");
            //names.Add("Vilma");

            //List<string> first = new List<string> { "One", "Two", "Three" };
            //List<string> second = new List<string>() { "Four", "Five" };

            //names.AddRange(first);

            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //Console.WriteLine(" ");

            //names.ForEach(x => { Console.WriteLine(x); });

            //Console.WriteLine(names.Count());
            //names.Remove("Vaidas");
            //Console.WriteLine(names.Count());
            //names.ForEach(x => { Console.WriteLine(x); });
            //names.RemoveAt(2);

            //1

            //Random rand = new Random();

            //List<int> sarasas = new List<int>();
            //for (int i = 0; i < 25; i++)
            //{
            //    sarasas.Add(rand.Next(5, 26));
            //}
            //foreach (int i in sarasas)
            //{
            //    Console.WriteLine(i);
            //}

            ////2
            ////a
            //int count = 0;
            //foreach (int i in sarasas)
            //{
            //    if (i > 10)
            //        count++;
            //}
            //Console.WriteLine("Daugiau uz 10 yra " + count);

            ////b
            //int max = sarasas.Max();
            //List<int> didSar = new List<int>();

            //for (int i = 0; i < sarasas.Count; i++)
            //{
            //    if (sarasas[i] == max)
            //        didSar.Add(i);
            //}


            //Console.WriteLine("Didziausias skaicius yra " + max + " o ju numeriai yra:" );

            //foreach (int i in didSar)
            //{
            //    Console.WriteLine(i);
            //}

            ////c
            //int sum = 0;
            //for (int i = 0;i < sarasas.Count;i = i + 2)
            //{
            //    sum = sum + sarasas[i];
            //}

            //Console.WriteLine("Lyginiu indeksu reiksmiu suma yra " + sum);

            ////d
            //Console.WriteLine(" ");
            //List<int> skirtSarasas = new List<int>();

            //for (int i = 0;i < sarasas.Count; i++)
            //{
            //    int skirt = sarasas[i] - i;
            //    skirtSarasas.Add(skirt);
            //}
            //foreach (int i in skirtSarasas)
            //{
            //    Console.WriteLine(i);
            //}

            ////e

            //List<int> lygSarasas = new List<int>();
            //List<int> neLygSarasas = new List<int>();


            //for (int i = 0; i < sarasas.Count; i = i + 2)
            //{
            //    lygSarasas.Add(sarasas[i]);
            //}

            //for (int i = 1; i < sarasas.Count; i = i + 2)
            //{
            //    neLygSarasas.Add(sarasas[i]);
            //}
            //Console.WriteLine(" ");

            //lygSarasas.ForEach(x => Console.WriteLine(x));
            //Console.WriteLine(" ");
            //neLygSarasas.ForEach(x => Console.WriteLine(x));

            ////f
            //Console.WriteLine(" ");
            //for (int i = 0;i < lygSarasas.Count;i++)
            //{
            //    if (lygSarasas[i] > 15)
            //        lygSarasas[i] = 0;
            //}

            //lygSarasas.ForEach((x) => Console.WriteLine(x));

            ////g
            //Console.WriteLine(" ");
            //for (int i = 0; i < sarasas.Count; i++)
            //{
            //    if (sarasas[i] > 10)
            //    {
            //        Console.WriteLine("Daugiau uz 10 pirmas indeksas yra " + i);
            //        return;
            //    }
            //}


            //3
            //Random rand = new Random();
            //List<char> raides = new List<char>();
            //for (int i = 0; i < 200; i++)
            //{
            //    raides.Add((char)rand.Next('A', 'E'));
            //}

            //raides.ForEach(a => Console.WriteLine(a));

            //int sumA , sumB , sumC , sumD;
            //sumA = sumB = sumC = sumD = 0;


            //for (int i = 0;i < raides.Count();i++)
            //{
            //    if (raides[i] == 'A')
            //        sumA++;
            //    else
            //    if (raides[i] == 'B')
            //        sumB++;
            //    else
            //    if (raides[i] == 'C')
            //        sumC++;
            //    else
            //    if (raides[i] == 'D')
            //        sumD++;
            //}
            //Console.WriteLine(" ");
            //Console.WriteLine("A yra " + sumA + " B yra " + sumB + " C yra " + sumC + " D yra " + sumD);

            ////4

            //Console.WriteLine(" ");
            //for (int i = 0; i < raides.Count(); i++)
            //{
            //    for (int j = 0; j < raides.Count() ; j++)
            //    {
            //        if (raides[i] < raides[j])
            //        {
            //            char tempValue = raides[i];
            //            raides[i] = raides[j];
            //            raides[j] = tempValue;
            //        }

            //    }
            //}

            //raides.ForEach(a => Console.WriteLine(a));

            //5

            //Random rand = new Random();
            //List<char> raides1 = new List<char>();
            //for (int i = 0; i < 200; i++)
            //{
            //    raides1.Add((char)rand.Next('A', 'E'));
            //}

            //List<char> raides2 = new List<char>();
            //for (int i = 0; i < 200; i++)
            //{
            //    raides2.Add((char)rand.Next('A', 'E'));
            //}

            //List<char> raides3 = new List<char>();
            //for (int i = 0; i < 200; i++)
            //{
            //    raides3.Add((char)rand.Next('A', 'E'));
            //}

            //List<string> raides4 = new List<string>();
            //for (int i = 0; i < 200; i++)
            //{
            //    raides4.Add(Convert.ToString(raides1[i]) + Convert.ToString(raides2[i]) + Convert.ToString(raides3[i]));
            //}


            ////raides4.ForEach(a => Console.WriteLine(a));

            //int unikaliKombinacija = raides4.Count;
            //List<int> pasikartojantys = new List<int>();

            //for (int i = 0; i < raides4.Count() - 1; i++)
            //{
            //    for (int j = i + 1; j < raides4.Count(); j++)
            //    {
            //        if (raides4[i] == raides4[j])
            //        {
            //            unikaliKombinacija = unikaliKombinacija - 1;
            //            pasikartojantys.Add(i);
            //            pasikartojantys.Add(j);
            //            break;
            //        }

            //    }
            //}
            //Console.WriteLine("Unikaliu reiksmiu yra:");
            //Console.WriteLine(raides4.Count() - pasikartojantys.Distinct().Count());
            //Console.WriteLine("Unikaliu kombinaciju yra " + unikaliKombinacija);


            //6

            Random rand = new Random();
            int[] skaiciai = new int[10];
            skaiciai[0]= rand.Next(5,26);
            skaiciai[1]= rand.Next(5,26);
            for (int i = 2; i < 10; i++)
            {
                skaiciai[i] = skaiciai[i-1] + skaiciai[i-2];
            }

            for (int i = 0; i < skaiciai.Length; i++)
            {
                Console.WriteLine(skaiciai[i]);
            }


        }
    }
}