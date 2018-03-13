using System;

namespace Project3_MilesToKm
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles = double.Parse(Console.ReadLine());
            double res = miles * 1.60934;
            Console.WriteLine("{0:f2}", res);
        }
    }
}
