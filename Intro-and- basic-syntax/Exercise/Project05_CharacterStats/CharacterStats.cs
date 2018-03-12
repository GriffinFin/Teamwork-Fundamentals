using System;

namespace Project05_CharacterStats
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int healthCurrent = int.Parse(Console.ReadLine());
            int healthMax = int.Parse(Console.ReadLine());
            int energyCurrent = int.Parse(Console.ReadLine());
            int energyMax = int.Parse(Console.ReadLine());
            
            string health = new string('|', healthCurrent);
            string healthMissing = new string('.', (healthMax - healthCurrent));
            string energy = new string('|', energyCurrent);
            string energyMissing = new string('.', (energyMax - energyCurrent));
            
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: |{health}{healthMissing}|");
            Console.WriteLine($"Energy: |{energy}{energyMissing}|");
        }
    }
}