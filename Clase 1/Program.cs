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
        }

        static void HacerAlgoConDocumentos(DocumentoLegal dl)
        {
            dl.Imprimir();
        }
    }
}
