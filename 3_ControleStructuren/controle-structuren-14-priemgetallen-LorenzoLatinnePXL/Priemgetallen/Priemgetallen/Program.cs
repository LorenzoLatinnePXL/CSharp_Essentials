using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priemgetallen
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 100; i++)
            {

                bool isPrime = true;

                if (i <= 1)
                {
                    isPrime = false;
                } 
                else
                {
                    for (int j = 2; j * j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }

                if (i % 10 != 0)
                {
                    if (isPrime)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($"{i}\t");
                    } else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"{i}\t");
                    }
                } 
                else
                {
                    if (isPrime)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{i}\t");
                    } else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{i}\t");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
