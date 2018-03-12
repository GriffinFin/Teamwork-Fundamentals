using System;

namespace Project04_BeverageLabels
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // The name of product.
            string name = Console.ReadLine();

            // The volume of product.
            var volume = double.Parse(Console.ReadLine());

            // Energy content per 100 ml.
            var energyContent = double.Parse(Console.ReadLine());

            // Sugar content per 100 ml.
            var sugarContent = double.Parse(Console.ReadLine());

            // Calculate the  energy for the given volume.
            energyContent *= (volume / 100);

            // Calculate the  sugar for the given volume.
            sugarContent *= (volume / 100);
            
            // Print the volume and the products name
            Console.WriteLine($"{volume}ml {name}:");

            // Print: how many energy and sugar content the product.
            Console.WriteLine($"{energyContent}kcal, {sugarContent}g sugars");
        }
    }
}