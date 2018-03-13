//CONFIRMED from cleopa8 - username in GitHub and cleopa - username in SoftUni
using System;

namespace Problem_02_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            //We recieve the parameters of the rectangle (width and height)
            //from the Console in the form of Floating Point numbers
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            //Then we proceed to calculate the area of the rectangle
            double area = width * height;
            //Finally we print the result to the Console
            Console.WriteLine($"{area:f2}");
        }
    }
}
