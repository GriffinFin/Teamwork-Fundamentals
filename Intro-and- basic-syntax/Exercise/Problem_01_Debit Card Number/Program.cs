using System;

namespace Problem_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstDigit = int.Parse(Console.ReadLine());
            int secondDigit = int.Parse(Console.ReadLine());
            int thirdDigit = int.Parse(Console.ReadLine());
            int fourthDigit = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstDigit:D4} {secondDigit:D4} {thirdDigit:D4} {fourthDigit:D4}");

        }
    }
}
