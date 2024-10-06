using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRekenen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een geheel getal: ");
            int getal1 = int.Parse(Console.ReadLine());
            Console.Write("Geef nog een geheel getal: ");
            int getal2 = int.Parse(Console.ReadLine());

            int som = getal1 + getal2;
            int verschil = getal1 - getal2;
            float product = getal1 * getal2;
            float quotient = getal1 / getal2;

            Console.WriteLine($"De som van {getal1} en {getal2} is {som} \n" +
                $"Het verschil tussen {getal1} en {getal2} is {verschil} \n" +
                $"Het product van {getal1} en {getal2} is {product} \n" +
                $"Het quotiënt van {getal1} en {getal2} is {quotient:0.00} ");

            Console.ReadLine();

        }
    }
}
