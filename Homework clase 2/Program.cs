using System;

namespace Homework_clase_2
{
    class Program
    {
        /*Crear un programa que divida 2 numero sin usar el operador / */
        static void Main(string[] args)
        {
            int resto;
            int cociente;

            cociente = Dividir(10, 3, out resto);
            Console.WriteLine("10 / 3");
            Console.WriteLine("Cociente: " + cociente + " Resto: " + resto);

            cociente = DividirRecursiva(10, 3, out resto);
            Console.WriteLine("Recursiva");
            Console.WriteLine("Cociente: " + cociente + " Resto: " + resto);
        }

        public static int Dividir(int dividendo, int divisor, out int resto)
        {
            int cociente = 0;
            while(divisor <= dividendo)
            {
                cociente++;
                dividendo -= divisor;
            }
            resto = dividendo;
            return cociente;
        }

        public static int DividirRecursiva(int dividendo, int divisor, out int resto)
        {
            if(divisor <= dividendo)
            {
                resto = dividendo;
                return 1 + DividirRecursiva(dividendo - divisor, divisor, out resto);
            }
                resto = dividendo;
                return 0;
        }
    }
}
