using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ethias_Oefening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * ETHIAS - GROET
             * 
             * Voorzie een programma dat door de verzekeringsmaatschappij
             * Ethias gebruikt kan worden om klanten te registreren.
             * 
             * Maak één variabele aan, genaamd groet
             *  - Zorg er voor dat je groet meerdere regels lang is
             *  - Druk de groet af, zodra het programma start
             * 
             */
            string groet = @"__          __  _ _                     _     _ _   ______ _   _     _           
\ \        / / | | |                   | |   (_|_) |  ____| | | |   (_)          
 \ \  /\  / /__| | | _____  _ __ ___   | |__  _ _  | |__  | |_| |__  _  __ _ ___ 
  \ \/  \/ / _ \ | |/ / _ \| '_ ` _ \  | '_ \| | | |  __| | __| '_ \| |/ _` / __|
   \  /\  /  __/ |   < (_) | | | | | | | |_) | | | | |____| |_| | | | | (_| \__ \
    \/  \/ \___|_|_|\_\___/|_| |_| |_| |_.__/|_| | |______|\__|_| |_|_|\__,_|___/
                                              _/ |                               
                                             |__/                               ";
            Console.WriteLine(groet);


            /*
             * ETHIAS - REGISTRATIE FORMULIER
             * Nadat de welkomsgroet getoond is, vraagt het programma om gegevens van de klant in te geven voor registratie
             * 
             * Maak een variabele voor elk van de volgende klantengegevens:
             *  - Voornaam
             *  - Achternaam
             *  - Leeftijd
             *  - IsMan (waar of niet waar)
             *  - Telefoonnummer
             */

            //Console.WriteLine("De gegevens van de klant: ");
            //Console.WriteLine("Wat is uw voornaam?");
            //string voornaam = Console.ReadLine();
            //Console.WriteLine("Wat is uw achternaam?");
            //string achternaam = Console.ReadLine();
            //Console.WriteLine("Wat is uw leeftijd?");
            //int leeftijd = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Wat is uw geslacht?");
            //string geslacht = Console.ReadLine().ToLower();
            //bool isMan = geslacht == "man";
            //Console.WriteLine("Wat is uw telefoonnummer?");
            //string telefoonnummer = Console.ReadLine();



            /*
             * ETHIAS - VERSLAG PRINTEN
             * Nadat het programma alle gegevens heeft ontvangen van de klant
             * wordt er een samenvatting afgedrukt in de console.
             * 
             * Gebruik string interpolatie om de variabelen te injecteren in een 
             * samenvatting. Zorg er voor dat je samenvatting uitlijning bevat.
             */

            //Console.WriteLine("\nUw gegevens:\n");
            //Console.WriteLine(
            //    $"\tVoornaam: {voornaam} \n" +
            //    $"\tAchternaam: {achternaam} \n" +
            //    $"\tLeeftijd: {leeftijd} \n" +
            //    $"\tMannelijk: {isMan} \n" +
            //    $"\tTelefoonnummer: {telefoonnummer}");


            /*
             * ETHIAS - TryParse
             * Pas je Ethias registratie programma aan, zodat het niet meer kan
             * crashen wanneer er ongeldige input wordt ingegeven.
             * 
             * Gebruik TryParse om je waardes te converteren.
             */

            Console.WriteLine("De gegevens van de klant: ");
            Console.WriteLine("Wat is uw voornaam?");
            string voornaam = Console.ReadLine();
            Console.WriteLine("Wat is uw achternaam?");
            string achternaam = Console.ReadLine();
            Console.WriteLine("Wat is uw leeftijd?");
            bool leeftijdCheck = int.TryParse(Console.ReadLine(), out int leeftijd);
            Console.WriteLine("Wat is uw geslacht?");
            string geslacht = Console.ReadLine().ToLower();
            bool isMan = geslacht == "man";
            Console.WriteLine("Wat is uw telefoonnummer?");
            string telefoonnummer = Console.ReadLine();

            Console.WriteLine("\nUw gegevens:\n");
            Console.WriteLine(
                $"\tVoornaam: {voornaam} \n" +
                $"\tAchternaam: {achternaam} \n" +
                $"\tLeeftijd: {leeftijd} \n" +
                $"\tMannelijk: {isMan} \n" +
                $"\tTelefoonnummer: {telefoonnummer}");

            

            Console.ReadLine();
        }
    }
}
