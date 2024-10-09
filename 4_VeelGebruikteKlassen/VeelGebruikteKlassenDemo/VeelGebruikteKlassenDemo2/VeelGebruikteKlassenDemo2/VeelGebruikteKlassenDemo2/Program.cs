// Using System.Text namespace om deze library te kunnen gebruiken. -- Altijd vanboven aan de code.
using System.Text;

// StringBuilder
StringBuilder stringBuilder = new StringBuilder();
stringBuilder.AppendLine("Tot ziens - Primark:");           // voegt tekst toe met newLine
stringBuilder.AppendLine();                                 // voegt newLine toe
stringBuilder.AppendLine("1 x Jas (geel model) - 10 euro");
stringBuilder.AppendLine("1 x paar sloefen zwart - 8 euro");
stringBuilder.AppendLine();
stringBuilder.Append("Kom snel terug!!!");                  // voegt tekst toe zonder een nieuwe regel

Console.WriteLine(stringBuilder.ToString());



StringBuilder gridBuilder = new StringBuilder();
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        gridBuilder.Append("X");
    }
    gridBuilder.AppendLine();
}

Console.WriteLine(gridBuilder.ToString());


// Random

Random rng = new Random();
Console.WriteLine(rng.Next(0, 10));
Console.WriteLine(rng.NextDouble());


Console.ReadLine();
