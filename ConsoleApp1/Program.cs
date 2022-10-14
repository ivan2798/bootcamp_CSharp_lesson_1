using System;

// Hello World! program
namespace ConsoleApp1
{
    class Hello
    {
        // intellisense
        static void Main(string[] args)
        {
            int edad = 19;

            edad--;

            //edad++;

            //Console.WriteLine("Tienes una edad de " + edad + " años");

            Console.WriteLine($"Tienes una edad de {++edad} años");



        }
    }
}