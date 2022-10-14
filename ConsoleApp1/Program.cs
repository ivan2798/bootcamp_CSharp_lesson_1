using System;

// Hello World! program
namespace ConsoleApp1
{
    class Hello
    {
        // intellisense
        static void Main(string[] args)
        {
            double temperatura = 34.5;

            int temperaturaMexico;

            //conversión explícita
            // casting

            temperaturaMexico = (int) temperatura;

            //conversión implícita
            int habitantesCiudad = 100000000;

            long habitantesCiudad21018 = habitantesCiudad;

            float pesoMaterial = 5.78F;

            double pesoMaterialPrec = pesoMaterial;
            
            Console.WriteLine($"{temperaturaMexico}, {habitantesCiudad}, {pesoMaterialPrec}");



        }
    }
}