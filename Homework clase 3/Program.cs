using System;
using System.Collections.Generic;
using System.IO;

namespace Homework_clase_3
{
    class Program
    {
        /*Hacer un programa que escriba en un archivo de texto
        un listado de personas y telefonos.
        
        El programa tiene que poder leer el archivo y cargarlo en una coleccion.
        
        Si se modifica el archivo tengo que poder leerlo nuevamente. */
        static void Main(string[] args)
        {
            
            int opcion = 0;
            string nombre;
            string telefono;
            do
            {
                Console.WriteLine("1.-Guardar\n2.-Leer\n3.-Salir");
                opcion = int.Parse(Console.ReadLine());
                Console.WriteLine(opcion);

                switch (opcion)
                {
                    case 1:
                        Console.Write("Nombre: ");
                        nombre = Console.ReadLine();

                        Console.Write("Telefono: ");
                        telefono = Console.ReadLine();

                        var dic = new Dictionary<string, string>();
                        dic.Add(nombre, telefono);
                        Archivo.GuardarArchivo(dic, "./test.txt");
                    break;

                    case 2:
                        foreach (var registro in Archivo.LeerArchivo("./test.txt"))
                        {
                            Console.WriteLine(registro.Key + " : " + registro.Value);
                        }
                        break;

                    case 3:
                        opcion = 3;
                        break;

                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }
            }
            while(opcion != 3);
            
            /*
            var data = new Dictionary<string, string>();
            data.Add("C#", "147258369");
            //Archivo.GuardarArchivo(data, "./test.txt");
            var dic = Archivo.LeerArchivo("./test.txt");
            foreach (var registro in dic)
            {
                Console.WriteLine(registro.Key + " : " + registro.Value);
            }*/
        }

        static class Archivo
        {
            public static Dictionary<string, string> LeerArchivo(string path)
            {
                string registro;
                Dictionary<string, string> salida = new Dictionary<string, string>();
                if (File.Exists(path))
                {
                    StreamReader lector = new StreamReader(path);
                    while(!lector.EndOfStream)
                    {
                        registro = lector.ReadLine();
                        var campos = registro.Split(',');
                        if (!salida.ContainsKey(campos[0]) && registro != "")
                        {
                            salida.Add(campos[0], campos[1]);
                        }
                    }
                    lector.Close();
                }
                return salida;
            }

            public static bool GuardarArchivo(Dictionary<string, string> dic, string path)
            {
                if (path != null)
                {
                    StreamWriter escritor = new StreamWriter(path, true);
                    foreach (var clave in dic.Keys)
                    {
                        escritor.WriteLine(clave + "," + dic[clave]);
                    }
                    escritor.Close();
                    return true;
                }
                return false;
            }
        }
    }
}
