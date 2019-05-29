using System;
using LU;

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

    public int Monto{get; set;}

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

    public virtual void Imprimir()
    {
        try
        {
            Grabar();
        }
        catch
        {
            Console.WriteLine("No se pudo grabar");
            throw;
        }

        if (true /*NO HAY PAPEL */)
        {
            throw new NoHayPapel{Impresora = "Impresora 1"};
        }

        if (true /*NO HAY TINTA */)
        {
            throw new Exception();
        }

        if (true /*IMPRESORA APAGADA */)
        {
            throw new Exception();
        }
    }

    public void Grabar()
    {
        throw new Exception();
    }

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

class Lista<Tipo> where Tipo : DocumentoLegal
{
    private Tipo[] lista;

    public Lista(Tipo[] miLista)
    {
        this.lista = miLista;
    }

    public int Total()
    {
        int total = 0;
        for(var i = 0; i < lista.Length; i++)
        {
            total += lista[i].Monto;
        }
        return total;
    }
}