using System;
using System.Collections.Generic;
using System.Linq;

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

            var fc = new Factura(1);
            var nc = new NotaDeCredito(1);
            var nc2 = new NotaDeCredito(2);

            nc.Imprimir();
            nc2.Imprimir();

            bool si = (fc is DocumentoLegal);
            si = (fc is Factura);

            HacerAlgoConDocumentos(nc);
            HacerAlgoConDocumentos(fc);

            var nnc = NotaDeCredito.LeerDeBaseDeDatos();

            //NotaDeCredito ndc = null;
            //ndc.imprimir();

            //var algo = (DocumentoLegal) fc;
            Object algo = (DocumentoLegal) fc; // Object es la unica variable que puede apuntar a cualquier cosa
            algo = "string";
            algo = 3;

            var Facturas = new Factura[3];
            Facturas[0] = new Factura(1);
            Facturas[1] = new Factura(2);
            Facturas[2] = new Factura(3);

            var Lista = new Lista<Factura>(Facturas);
            int total = Lista.Total();

            var lista = new Lista<DocumentoLegal>(null);

            var list = new List<DocumentoLegal>();
            var dic = new Dictionary<string, Factura>();
            dic.Add("Lagash", new Factura(4));

            list.Sort(new ComparadorMontoDL());

            Func<int, int> f = delegate(int i)
            {
                return i + 1;
            };

            f(4);

            Func<DocumentoLegal, bool> siEsPar = (DocumentoLegal dl) => (dl.Monto % 2) == 0;

            list.Where(siEsPar);
            list.Where(dl => (dl.Monto % 2) == 0);

            Func<int, int, int> g = delegate(int i, int j)
            {
                return i+ 1;
            };

            try
            {
                fc.Imprimir();
            }
            catch(NoHayPapel)
            {
                Console.WriteLine("Compra papel");
            }
            catch
            {
                Console.WriteLine("reporteError@lagash.com");
            }

        }

        static void HacerAlgoConDocumentos(DocumentoLegal dl)
        {
            dl.Imprimir();
        }
    }

    class ComparadorMontoDL : IComparer<DocumentoLegal>
    {
        public int Compare(DocumentoLegal x, DocumentoLegal y)
        {
            if (x.Monto > y.Monto) return 1;
            if (x.Monto < y.Monto) return -1;
            return 0;
        }
    }

    class NoHayPapel : Exception
    {
        public string Impresora {get; set;}
    }
}
