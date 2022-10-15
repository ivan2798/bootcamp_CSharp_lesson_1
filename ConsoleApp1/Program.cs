using System;

// Hello World! program
namespace ConsoleApp1
{
    class Hello
    {
        // intellisense
        static void Main(string[] args)
        {
            const double PI = 3.1416;

            Console.WriteLine("Introduce la medida del radio");

            double radio = double.Parse(Console.ReadLine());

            double area = Math.Pow(PI, radio);

            Console.WriteLine($"El area del circulo es: {area}");

        }
    }
}