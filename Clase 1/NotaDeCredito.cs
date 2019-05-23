using System;

class NotaDeCredito : DocumentoLegal
{
    public NotaDeCredito(int numero) : base(numero)
    {

    }
    public override void Imprimir()
    {
        Console.WriteLine("Soy la nc: " + this.GetNumero());
    }

    public static NotaDeCredito LeerDeBaseDeDatos()
    {
        return null;
    } 
}