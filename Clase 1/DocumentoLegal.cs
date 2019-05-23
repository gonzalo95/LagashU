using System;

interface Imprimible
{
    void Imprimir();
}

interface Grabable
{
    void Grabar();
}
abstract class DocumentoLegal : Imprimible, Grabable
{
    private int Numero;
    private int codEnBaseDeDatos;

    protected int fechaAlta;

/*
    public DateTime Fecha
    {
        get
        {
            return Fecha;
        } 
        protected set
        {
            Fecha = value;
        }
    }
*/

    public int GetNumero()
    {
        return this.Numero;
    }

    protected void SetNumero(int numero)
    {
        this.Numero = numero;
    }

    public DocumentoLegal(int numero)
    {
        this.Numero = numero;
    }

    public virtual void Imprimir(){}

    public void Grabar(){}

    public void Enviar()
    {
        Console.WriteLine("DocumentoLegal.Eviar");
    }

    protected static void Hacer()
    {

    }

    private void GuardarEnBaseDeDatos()
    {
        Console.WriteLine("DocumentoLegal.GuardarEnBaseDeDatos");
    }
}