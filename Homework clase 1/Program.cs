using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework
{
    class Program
    {
        /*Hacer un array de 10 posiciones
          imprimir la suma de las 10 posiciones.
          Mencionar si es divisible por 3. */
        static void Main(string[] args)
        {
            int[] numeros = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int sumatoria = numeros.Sum();
            // Sin LINQ.
            /*
            int sumatoria = 0;
            for (int i = 0; i < 10; i++) 
            {
                sumatoria += numeros[i];
            }
            */
            Console.WriteLine("Suma: " + sumatoria);
            if (0 == (sumatoria % 3))
            {
                Console.WriteLine("Es divisible por 3");
            }
            else
            {
                Console.WriteLine("NO es divisible por 3");
            }
        }
    }
}
