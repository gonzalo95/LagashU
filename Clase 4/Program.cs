using System;

namespace Clase_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Derivada d = new Derivada();
            Derivada2 d2 = new Derivada2();
            ((Base)d).Mostrar();
            d.Mostrar();
            d2.Mostrar();
        }
    }

    abstract class Base
    {
        public virtual void Mostrar()
        {
            Console.WriteLine("Mostrar en clase base");
        }
    }

    class Derivada: Base
    {
        public override void Mostrar()
        {
            Console.WriteLine("Mostrar en clase derivada");
        }
    }

    class Derivada2 : Base
    {
        public override void Mostrar()
        {
            base.Mostrar();
        }
    }
}
