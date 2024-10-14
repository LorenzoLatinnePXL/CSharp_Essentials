using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteratie_Oefeningen_Monitoriaat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Oefening 1
            Console.WriteLine("Oefening 1: Eerste 10 natuurlijke getallen");
            for (int i = 0; i <= 10; i++)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
            Console.WriteLine();

            // Oefening 2
            Console.WriteLine("Oefening 2: Eerste 10 even natuurlijke getallen");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i * 2} ");
            }
            Console.WriteLine();
            Console.WriteLine();

            // Oefening 3
            Console.WriteLine("Oefening 3: Oneven natuurlijke getallen tot gegeven getal");
            Console.WriteLine("Geef een geheel getal.");
            string input = Console.ReadLine();
            bool isValidNumber = int.TryParse(input, out int iterator);
            if (isValidNumber)
            {
                for (int i = 0; i < iterator; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.Write($"{i} ");
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine();

            // Oefening 4
            Console.WriteLine("Oefening 4: Faculteit van een gegeven getal");
            Console.WriteLine("Geef een geheel getal.");
            string input2 = Console.ReadLine();
            bool isValidNumber2 = int.TryParse(input2, out int iterator2);
            int factorialSteps = 1;

            if (isValidNumber2)
            {
                for (int i = 0; i < iterator2; i++)
                {
                    factorialSteps += factorialSteps * i;
                }
                Console.WriteLine($"!{input2} = {factorialSteps}");
            }

            // Oefening 5
            Console.WriteLine("Oefening 5: Berekenen van het kwadraat tot een gegeven getal");
            Console.WriteLine("Geef een geheel getal.");
            string input3 = Console.ReadLine();
            bool isValidNumber3 = int.TryParse(input3, out int iterator3);
            if (isValidNumber3)
            {
                for (int i = 1; i <= iterator3; i++)
                {
                    Console.WriteLine($"{i}² = {i * i}");
                }
            }
            Console.WriteLine();

            // Oefening 6
            Console.WriteLine("Oefening 6: Product berekenen van twee gegeven getallen, mogelijks herhalen");
            string antwoord = "ja";
            do
            {
                Console.WriteLine("Geef een eerste geheel getal.");
                string input4 = Console.ReadLine();
                bool isValidNumber4 = int.TryParse(input4, out int product1);


                while (!isValidNumber4)
                {
                    Console.WriteLine("Geef een eerste geheel getal.");
                    input4 = Console.ReadLine();
                    isValidNumber4 = int.TryParse(input4, out product1);
                }
                Console.WriteLine("Geef een tweede geheel getal.");
                string input5 = Console.ReadLine();
                bool isValidNumber5 = int.TryParse(input5, out int product2);
                while (!isValidNumber5)
                {
                    Console.WriteLine("Geef een tweede geheel getal.");
                    input5 = Console.ReadLine();
                    isValidNumber5 = int.TryParse(input5, out product2);
                }
                if (isValidNumber4 && isValidNumber5)
                {
                    Console.WriteLine($"Het product tussen de twee getallen is: {product1 * product2}");
                }

                    Console.WriteLine("Wil je nog een ander product berekenen? Ja/Nee");
                    antwoord = Console.ReadLine().ToLower();
            } while (antwoord == "ja");

            // Oefening 7
            Console.WriteLine("Oefening 7:");

            Console.ReadLine();
        }
    }
}
