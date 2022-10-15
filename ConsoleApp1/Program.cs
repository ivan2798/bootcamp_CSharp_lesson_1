using System;

// Hello World! program
namespace ConsoleApp1
{
    class Hello
    {
        // intellisense
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el primer número");

            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el segundo número");

            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("El resultado es: " + (num1 + num2));

        }
    }
}