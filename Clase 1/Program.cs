using System;

namespace LU
{
    class Program
    {
        static void Main(string[] args)
        {
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
            Console.WriteLine("Monto: " + transferencia);
        } 
    }
}
