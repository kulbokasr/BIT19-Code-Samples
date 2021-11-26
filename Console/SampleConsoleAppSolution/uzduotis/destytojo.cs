using System;

namespace _19gr1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //string name = "Naglis";
            //string surname = "Mockevičius";
            //int currentYear = 2021;
            //int birthYear = 2000;
            //Console.WriteLine("Aš esu " +name + " " + surname +". Man yra "+ (currentYear - birthYear) +" metai(u).");

            //string[] students = new string[7];
            //students[0] = "Vilma";
            //students[1] = "Artur";
            //students[2] = "Donatas";
            //students[3] = "Vytautas";
            //students[4] = "Tautvydas";
            //students[5] = "Simonas";
            //students[6] = "Aukse";


            //for (int i = 0; i < students.Length; i++)
            //{
            //    Console.Write(students[i]+" ");
            //}

            //foreach (string student in students)
            //{
            //    Console.WriteLine(student);
            //}


            //int[] numbers = new int[5];

            Random rand = new Random();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = rand.Next(5, 11); 
            //}


            //int[] numsMore = new int[10];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numsMore[i] = numbers[i];
            //}

            //for (int i = numbers.Length; i < numbers.Length + 5; i++)
            //{

            //    numsMore[ i ] = rand.Next(5, 11);
            //}

            //foreach (int num in numsMore)
            //{
            //    Console.WriteLine(num);
            //}

            //int[,] calculus = new int[10, 10];

            //for (int i = 0; i < calculus.GetLength(0); i++) //i=1
            //{
            //    for (int a = 0; a < calculus.GetLength(1) ; a++)
            //    {
            //        calculus[i, a] = i * a;

            //    }
            //}

            //for (int i = 0; i < calculus.GetLength(0); i++) //i=1
            //{
            //    for (int a = 0; a < calculus.GetLength(1); a++)
            //    {
            //        //Console.Write("["+calculus[i,a]+"]");

            //        Console.Write(calculus[i, a] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //Įvedami skaičiai -a, b, c –kraštinių ilgiai, trys kintamieji(naudojame int)(nuo 1 iki 10).
            //    Parašykite C# programą, kuri nustatytų, ar galima sudaryti trikampį ir atsakymą atspausdintų. 
            //    Naudokite Console.ReadLine() priimti įvestis.

            //bool badInput = true;
            //int a=0, b=0, c=0;

            //while (badInput)
            //{
            //    Console.WriteLine("Iveskite teisingus duomenis");
            //    try
            //    {
            //        a = Convert.ToInt32(Console.ReadLine());
            //        b = Convert.ToInt32(Console.ReadLine());
            //        c = Convert.ToInt32(Console.ReadLine());
            //        badInput = false;
            //    }
            //    catch(Exception e){}

            //}


            //if (a > 0 && a < 11 &&
            //        b > 0 && b < 11 &&
            //        c > 0 && c < 11)
            //{



            //    if (a + b > c && a + c > b && b + c > a)
            //    {
            //        Console.WriteLine("Zinoma, kad galima");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Deje trikampio sudaryti nepavyks");

            //    }
            //}
            //else
            //{
            //    Console.WriteLine("netinkami skaiciai");
            //}

            //Įmonė parduoda žvakes po 1 EUR.Perkant daugiau kaip už 1000 EUR taikoma 3 % nuolaida, daugiau kaip už 2000 EUR - 4 % nuolaida.
            //    Parašykite programą, kuri skaičiuos žvakių kainą ir atspausdintų atsakymą kiek žvakių ir kokia kaina perkama.
            //    Žvakių kiekį generuokite ​random​ funkcija nuo 5 iki 3000.


            //int candles = rand.Next(5, 3000);
            //double discount = 1;
            //double price = 1;
            //if(2000  < ((double) candles * price))
            //{
            //    discount = 0.96;
            //}else if (1000  < ( (double) candles * price))
            //{
            //    discount = 0.97;
            //}
            //Console.WriteLine("Zvakiu pirko "+candles);
            //Console.WriteLine("sumokejo "+ ((double) candles * price * discount));


            for (int i = 0; i < 10; i++)
            {

            }

            for (int i = 0; i < 10; i += 2)
            {

            }

            //for (int i = 9; i >= 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            int g = 0;
            for (; g < 10;)
            {
                g += 3;
                Console.WriteLine(g);
                if (g % 3 == 0)
                {
                    g -= 2;
                }

            }

        }
    }
}