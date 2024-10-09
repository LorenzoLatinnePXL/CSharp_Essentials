using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace VeelGebruikteKlassenDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Math
            // Verschil in Math.Round, Floor & Ceiling
            double division = 15.0 / 4; // 3.75
            double num1 = Math.Floor(division);
            Console.WriteLine($"Floor is {num1}");
            double num2 = Math.Round(division);
            Console.WriteLine($"Round is {num2}");
            double num3 = Math.Ceiling(division);
            Console.WriteLine($"Ceiling is {num3}");
            // String
            // if (voorwaarde = boolean) { uitvoerbare code }
            string text = "  ";
            // isNullOrWhiteSpace telt spaties, tabs, escape chars ook als leeg.
            // isNullrOrEmpty telt spaties, tabs en escape chars niet als leeg.
            if (string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("De tekst is leeg");
            }
            string example = "voorbeeld text";
            string partText = example.Substring(2, 1);
            Console.WriteLine(partText);
            // Char
            // declaratie + initialisatie van een character
            char character = 'a';
            string charInText = "x";
            // converteren van string naar char
            character = char.Parse(charInText);
            bool isConvertable = char.TryParse(charInText, out character);
            Console.WriteLine(character);
            // evalueren van een char mbv System.Char
            if (Char.IsLetter(character))
            {
                Console.WriteLine("Mijn karakter is een letter.");
            }
            if (Char.IsDigit(character))
            {
                Console.WriteLine("Mijn karater is een cijfer.");
            }
            Console.ReadLine();
        }
    }
}