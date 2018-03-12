using System;

namespace Project04_BeverageLabels
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            var volume = double.Parse(Console.ReadLine());
            var energyContent = double.Parse(Console.ReadLine());
            var sugarContent = double.Parse(Console.ReadLine());
            
            energyContent *= (volume / 100);
            sugarContent *= (volume / 100);
            
            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{energyContent}kcal, {sugarContent}g sugars");
        }
    }
}