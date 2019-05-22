using System;

namespace Clase_2
{
    enum TipoEmpleado
    {
        Empleado,
        LU,
        Contratado
    }
    struct Persona
    {
        public string Nombre;
        public string Apellido;
        public long Sueldo;
        public TipoEmpleado Tipo;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.Nombre = "Gonzalo";
            persona.Apellido = "Greco";
            persona.Sueldo = 100;
            persona.Tipo = TipoEmpleado.LU;
            
            ImprimirPersona(persona);

            var otraPersona = new Persona
            {
                Nombre = "Diego",
                Apellido = "Gonzalez",
                Sueldo = 200,
                Tipo = TipoEmpleado.Empleado
            };

            ImprimirPersona(otraPersona);

            Console.WriteLine(Sumar(2, 2, 5, 8, 7));

            Console.WriteLine(Sumatoria(5));
        }

        public static void ImprimirPersona(Persona p)
        {
            Console.WriteLine(p.Nombre);
            Console.WriteLine(p.Apellido);
            Console.WriteLine(p.Sueldo);
            Console.WriteLine(p.Tipo);
        }

        public static int Sumar(params int[] numeros)
        {
            int suma = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                suma += numeros[i];
            }
            return suma;
        }

        public static int Sumatoria(int numero)
        {
            return (numero == 0) ? 0 : numero + Sumatoria(numero - 1);
        }
    }
}
