using System;

class Factura : DocumentoLegal
{
    public Factura(int numero) : base(numero)
    {

    }

    public override void Imprimir()
    {
        Console.WriteLine("Soy la fc: " + this.GetNumero());
    }
    public void Pagar()
    {
        Hacer();
        Console.WriteLine("factura.Pagar");
    }
}

class FacturaExportacion : Factura
{

    public string Pais{ get; set; }
    public FacturaExportacion(int numero) : base(numero)
    {

    }

    public override void Imprimir()
    {
        Console.WriteLine("Soy la fc-e: " + this.GetNumero());
    }
}