using System;

namespace Clase_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            int opcion = 0;
            do
            {
                Console.WriteLine("1.-Add item\n2.-Get item\n3.-Delete item\n4.-Number of item\n5.-Max & min\n6.-Find item\n7.-Print all\n8.-Exit");
                opcion = Int32.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                    Console.Write("Ingrese el elemento: ");
                    stack.Add(Int32.Parse(Console.ReadLine()));
                    break;

                    case 2:
                    try
                    {
                        Console.WriteLine(stack.Get());
                    }
                    catch(ArgumentOutOfRangeException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;

                    case 3:
                    Console.Write("Ingrese el indice: ");
                    stack.Delete(Int32.Parse(Console.ReadLine()));
                    break;

                    case 4:
                    Console.Write("Ingrese el elemento: ");
                    Console.WriteLine(stack.IndexOf(Int32.Parse(Console.ReadLine())));
                    break;

                    case 5:
                    break;

                    case 6:
                    Console.Write("Ingrese el elemento: ");
                    Console.WriteLine(stack.FindItem(Int32.Parse(Console.ReadLine())));
                    break;

                    case 7:
                    Console.WriteLine(stack.PrintAll());
                    break;

                    case 8:
                    Console.WriteLine("Gracias vuelva prontos!");
                    break;

                    default:
                    Console.WriteLine("Opcion invalida\n");
                    break;
                }
            }
            while(opcion != 8);
        }

        /*
            try
            {
            var stack = new Stack<int>();
                stack.Add(1);
                stack.Add(2);
                stack.Add(3);
                stack.Add(4);
                Console.WriteLine(stack.PrintAll());
                Console.WriteLine("Existe el 4: " + stack.FindItem(4));
                Console.WriteLine("Existe el 5: " + stack.FindItem(5));
                Console.WriteLine("Indice del elemento 4: " + stack.IndexOf(4));
                stack.Delete(1);
                Console.WriteLine("Eliminado el elemento 2");
                Console.WriteLine("Nuevo indice del elemento 4: " + stack.IndexOf(4));
                Console.WriteLine(stack.Get());
                Console.WriteLine(stack.Get());
                Console.WriteLine(stack.Get());
            }
            catch(ArgumentOutOfRangeException)
            {
                Console.WriteLine("Stack vacia");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            } 
            */
    }
}
