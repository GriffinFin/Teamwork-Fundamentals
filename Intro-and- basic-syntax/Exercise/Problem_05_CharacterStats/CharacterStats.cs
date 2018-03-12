using System;

namespace Project05_CharacterStats
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Receive the name of the character.
            string name = Console.ReadLine();

            // Receive the current health.
            int healthCurrent = int.Parse(Console.ReadLine());

            // Receive the max health.
            int healthMax = int.Parse(Console.ReadLine());

            // Receive the current energy.
            int energyCurrent = int.Parse(Console.ReadLine());

            // Receive the max energy.
            int energyMax = int.Parse(Console.ReadLine());
            
            // How much health we have.
            string health = new string('|', healthCurrent);

            // How much health is missing.
            string healthMissing = new string('.', (healthMax - healthCurrent));

            // How much health we have.
            string energy = new string('|', energyCurrent);

            // How much energy is missing.
            string energyMissing = new string('.', (energyMax - energyCurrent));
            
            // Print the character`s name.
            Console.WriteLine($"Name: {name}");

            // Print: How much health we have and how much health is missing.
            Console.WriteLine($"Health: |{health}{healthMissing}|");

            // Print: How much energy we have and how much energy is missing.
            Console.WriteLine($"Energy: |{energy}{energyMissing}|");
        }
    }
}