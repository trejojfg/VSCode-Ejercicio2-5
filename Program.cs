using System;

namespace Ejercicio2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno 
            // y luego calcule y emita por pantalla el promedio final.


            
            float A, B, C, PROM;

            Console.WriteLine("Meta 1º Nota");
            A = float.Parse(Console.ReadLine());
            Console.WriteLine("Meta 2º Nota");
            B = float.Parse(Console.ReadLine());
            Console.WriteLine("Meta 3º Nota");
            C = float.Parse(Console.ReadLine());
            PROM = (A + B + C)/3;

            Console.WriteLine("El promedio de notas es de " + PROM.ToString("0.00"));

        }
    }
}
