namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Data types
            int number = 5;
            string text = "text" + " text";
            char singleChar = 'A';
            bool boolValue = false;
            double doubleValue = 5.432;

            var arrayOfInts1 = new[] { 1, 2, 3, 4, 5 };
            arrayOfInts1[0] = 5;
            //arrayOfInts1[9] = 5; - negalima, nes array yra tokio ilgio koks buvo
            var arrayOfInts2 = new List<int> { 1, 2, 3, 4, 5 };
            arrayOfInts2.AddRange(new List<int> { 2, 3, 4, 5 }); // i lista galima prisideti info


            // DateTime dateTimeValue = DateTime.MinValue;




            //Console.WriteLine(consoleInput);

            // String manipulation example: 5 + 4, 4 - 5;


            ////Get first two numbers
            //consoleInput.Substring(0, 2);

            ////Get first number
            //consoleInput.FirstOrDefault();

            //// forloop
            //for (int i = 0; i < consoleElements.Length; i++)
            //{
            //    Console.WriteLine(consoleElements[i]);
            //}

            //// foreach loop
            //foreach (var element in consoleElements)
            //{
            //    Console.WriteLine(element);
            //}

            while (true)
            {
                // Console commands
                Console.WriteLine("Enter your input");

                var consoleInput = Console.ReadLine();

                // Split string into smaller string by spaces
                var consoleElements = consoleInput.Split(" ");

            // try/catch

            try
            {

                var firstInput = consoleElements[0];
                var mathoperator = consoleElements[1];
                var secondInput = consoleElements[2];

                var fisrtNumber = Convert.ToInt32(firstInput);
                var secondNumber = Convert.ToInt32(secondInput);

                // if statement
                if (mathoperator == "+")
                {
                    Console.WriteLine(fisrtNumber + secondNumber);
                }
                if (mathoperator == "-")
                {
                    Console.WriteLine(fisrtNumber - secondNumber);
                }

            }
            catch (Exception ex)
            { Console.WriteLine("Wrong input"); }

            }
        }
    }
}