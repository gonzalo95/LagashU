using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Clase_5
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime  fecha = new DateTime(2019, 5, 27);
            fecha = fecha.AddDays(5);
            Console.WriteLine("Es sabado!: " + fecha.Date);

            Queue cola = new Queue();
            cola.Enqueue("Gonzalo");
            cola.Enqueue("Greco");
            Console.WriteLine(cola.Dequeue());

            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "Gonzalo");
            Console.WriteLine(dic[1]);

            List<string> lista = new List<string>();
            lista.Add("Gonzalo");
            lista.Add("Javier");
            lista.Add("Greco");

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }

            foreach (var nom in lista.Where( (nn) => nn[0] == 'J'))
            {
                Console.WriteLine(nom);
            }

            foreach (var c in "Lagash")
            {
                Console.WriteLine(c);
            }
        }
    }
}
