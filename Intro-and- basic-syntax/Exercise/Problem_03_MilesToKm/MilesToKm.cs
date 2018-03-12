using System;

namespace Project03_MilesToKm
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double miles = Double.Parse(Console.ReadLine());
            double km = miles * 1.60934;
            Console.WriteLine($"{km:f2}");
        }
    }
}