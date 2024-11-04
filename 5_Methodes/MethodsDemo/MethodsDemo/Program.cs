using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDemo
{

    public class Character
    {
        public string Name { get; set; }
        public int AttackPower { get; set; }
        public int Defense { get; set; }

        // Constructor
        public Character(string name, int attackPower, int defense)
        {
            Name = name;
            AttackPower = attackPower;
            Defense = defense;
        }

        // Method to calculate damage
        public int CalculateDamage(Character target)
        {
            // Basic damage calculation
            int damage = AttackPower - target.Defense;

            // Ensure damage is not negative
            return damage > 0 ? damage : 0;
        }
    }

    class Program
    {
        static void Main()
        {
            // Create two characters
            Character attacker = new Character("Warrior", 50, 10);
            Character defender = new Character("Knight", 30, 20);

            // Calculate damage dealt to the defender
            int damageDealt = defender.CalculateDamage(attacker);

            // Output the result
            Console.WriteLine($"{defender.Name} deals {damageDealt} damage to {attacker.Name}.");
            Console.ReadLine();

        }


    }
}
