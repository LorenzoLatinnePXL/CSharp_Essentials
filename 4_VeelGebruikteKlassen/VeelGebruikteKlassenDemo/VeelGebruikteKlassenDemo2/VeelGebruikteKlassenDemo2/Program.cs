using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeelGebruikteKlassenDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // StringBuilder

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Tot ziens - Primark:");           // voegt tekst toe met newLine
            stringBuilder.AppendLine();                                 // voegt newLine toe
            stringBuilder.AppendLine("1 x Jas (geel model) - €10");
            stringBuilder.AppendLine("1 x paar sloefen zwart - €8");
            stringBuilder.AppendLine();
            stringBuilder.Append("Kom snel terug!!!");                  // voegt tekst toe zonder een nieuwe regel

            Console.WriteLine(stringBuilder.ToString());

            Console.ReadLine();
        }
    }
}
