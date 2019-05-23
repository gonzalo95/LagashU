using System;

namespace Homework_clase_2
{
    class Program
    {
        /*Crear un programa que divida 2 numeros enteros sin usar el operador / */
        static void Main(string[] args)
        {
        /* 
            int resto;
            int cociente;

            cociente = Dividir(10, 3, out resto);
            Console.WriteLine("10 / 3");
            Console.WriteLine("Cociente: " + cociente + " Resto: " + resto);

            cociente = DividirRecursiva(10, 3, out resto);
            Console.WriteLine("Recursiva");
            Console.WriteLine("Cociente: " + cociente + " Resto: " + resto);
        */
        int cociente;
        int decimales;

        cociente = DividirConDecimales(10, 3, out decimales);
        Console.WriteLine("10/3");
        Console.WriteLine(cociente + "." + decimales);
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

        public static int DividirConDecimales(int dividendo, int divisor, out int decimales)
        {
            int cociente = 0;
            decimales = 0;
            while(divisor <= dividendo)
            {
                cociente++;
                dividendo -= divisor;
            }            
            if(dividendo != 0)
            {
                for (int i = 0; i < 3; i++)
                {
                    decimales *= 10;
                    dividendo *= 10;
                    while(divisor <= dividendo)
                    {
                        decimales++;
                        dividendo -= divisor;
                    }            
                }
            }
            return cociente;
        }
    }
}
