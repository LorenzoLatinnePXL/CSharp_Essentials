/* 
 * Deel 1
 * 
 * We gaan een applicatie maken waarin de speler als ridder tegen een goblin moet vechten.
 * We starten met een controle te implementeren die kijkt of de speler nog leeft.
 *  - Declareer en initialiseer een waarde knightHealth (0) en goblinHealth (20).
 *  - Indien de levenspunten van de speler (knightHealth) kleiner of gelijk zijn aan nul,
 *    dan toon je aan de speler dat hij/zij is gestorven. 
 *  - Doe hetzelfde voor de goblin.
 *  - Extra: gebruik de Random klasse om de levenspuntenvan de ridder en goblin in te stellen.
 */

Console.WriteLine("Welcome to the Knight vs Goblin game!");
Console.WriteLine("-------------------------------------");

Random rnd = new Random();

int knightHealth;
int goblinHealth = rnd.Next(1, 20);
int attackKnight = 10;
int attackGoblin = 5;

Console.Write("How much health do you start with? ");

string userHealth = Console.ReadLine();
bool isValidPlayerHealth = int.TryParse(userHealth, out knightHealth);

if (isValidPlayerHealth == false || knightHealth < 0 || knightHealth > 100)
{
    knightHealth = 100;
}

Console.WriteLine($"Knight health: {knightHealth}");
Console.WriteLine($"Goblin health: {goblinHealth}");

Console.WriteLine("Choose your next attack carefully:");
Console.WriteLine("1. Attack");
Console.WriteLine("2. Heal");


// Alles selecteren (CTRL + A) => Code Formatten (CTRL + K + F)

// while code snippet
do
{
    Console.Write("Enter your choice: ");
    string choice = Console.ReadLine();

    // switch code snippet!!
    switch (choice)
    {
        case "1":
            Console.WriteLine($"You attacked the goblin for {attackKnight}.");
            goblinHealth -= attackKnight;
            if (goblinHealth <= 0)
            {
                Console.WriteLine("Victory! You have killed the goblin!");
            }
            else
            {
                Console.WriteLine($"You were attacked by the goblin for {attackGoblin}");
                knightHealth -= attackGoblin;
                if (knightHealth <= 0)
                {
                    Console.WriteLine("Oh dear, you have been defeated.");
                }
                else
                {
                    Console.WriteLine($"You health is: {knightHealth}");
                    Console.WriteLine($"Goblin health is: {goblinHealth}");
                }
            }
            break;

        case "2":
            Console.WriteLine("You heal for 10 health points.");
            knightHealth += 10;
            Console.WriteLine($"You were attacked by the goblin for {attackKnight} damage.");
            knightHealth -= attackGoblin;
            if (knightHealth <= 0)
            {
                Console.WriteLine("Oh dear, you have been defeated.");
            }
            else
            {
                Console.WriteLine($"You health is: {knightHealth}");
                Console.WriteLine($"Goblin health is: {goblinHealth}");
            }
            break;
            
        default:
            Console.WriteLine($"{choice} is not a valid option.");
            Console.WriteLine($"You were attacked by the goblin for {attackKnight} damage.");
            knightHealth -= attackGoblin;
            if (knightHealth <= 0)
            {
                Console.WriteLine("Oh dear, you have been defeated.");
            }
            else
            {
                Console.WriteLine($"You health is: {knightHealth}");
                Console.WriteLine($"Goblin health is: {goblinHealth}");
            }
            break;
    }
} while (knightHealth > 0 && goblinHealth > 0);


Console.ReadLine();

/* 
 * Deel 2
 * 
 * - Indien de speler niet gestorven is, dan druk je af hoeveel levenspunten (knightHealth) 
 *   speler nog heeft. Gebruik hier else voor.
 * - Laat de speler zelf levenspunten ingeven voor de ridder (knightHealth). Zo kiest elke speler 
 *   zelf hoe moeilijk het gevecht is. 
 * - De waarde knightHealth moeten tussen 0 en 100. Indien de speler een ongeldige waarde ingeeft, 
 *   dan wordt de standaard waarde 100 gebruikt.
 *    - Extra: gebruik TryParse om de input van de speler te verwerken, 
 *      zodat het programma niet zal crashen.
 */

/*
 * Deel 3
 * 
 * Declareer en initialiseer een aanvalswaarde voor de ridder, attackKnight (10), 
 * en de goblin, attackGoblin (5).
 * Laat de speler een actie selecteren door een getal in te geven. Gebruik een switch:
 *  - Als ik als speler actie 1 kies, dan val ik aan en wordt attackKnight afgetrokken van 
 *    goblinHealth. Beschrijf in de output wat er gebeurt.
 *  - Als ik als speler actie 2 kies, dan genees ik mezelf 10 levenspunten. Beschrijf in de 
 *    output wat er gebeurt.
 *  - Als de speler een ongeldige actie ingeeft, dan weergeef je dit in de output.
 *  - Extra: voeg extra acties toe die de speler kan kiezen.
 *  - Extra: zorg er voor dat de goblin ook een actie neemt.
 */

/*
 * Deel 4
 * 
 * Gebruik een for lus, zodat de speler exact 4 keer een actie kan selecteren.
 */

/*
 * Deel 5
 * 
 * Vervang de for lus door een while lus die vraagt aan de speler om een actie 
 * uit te voeren zolang als de ridder of goblin nog leeft.
 * 
 * Extra: zorg er voor dat de goblin ook een actie neemt.
 */
