using System;
using System.Collections.Generic;
using System.Linq;

namespace LU
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Hacer un array de 10 posiciones
            imprimir la suma de las 10 posiciones.
            Mencionar si es divisible por 3.*/
            /*
            double sueldo = 100;
            int personal = 7;
            double transferencia;
            int[] sueldos = new int[5];

            sueldos[0] = 100;
            sueldos[1] = 200;
            transferencia = sueldo * personal;
            if (0 == (transferencia % 2)) // Verifico si es par.
            {
                Console.WriteLine("Par");
            }
            else
            {
                Console.WriteLine("Impar");
            }
            Console.WriteLine("Monto: " + transferencia);*/

            int[] array = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            /*
            for (int i = 0; i < 10; i++)
            {
                array[i] = i;
            }*/
            int sum = 0;
/*
            for (int i = 0; i < 10; i++) // Sin LINQ.
            {
                sum += array[i];
            }
            */
            sum = array.Sum();
            Console.WriteLine("Suma: " + sum); // Con LINQ.
            if (0 == (sum % 3))
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
