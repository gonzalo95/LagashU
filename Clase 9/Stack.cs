using System;
using System.Collections.Generic;

public class Stack<T>
{
    public List<T> elementos;

    public Stack()
    {
        this.elementos = new List<T>();
    }
    public void Add(T item)
    {
        this.elementos.Add(item);
    }

    public T Get()
    {
        T item = this.elementos[0];
        this.elementos.RemoveAt(0);
        return item;
    }

    public void Delete(int index)
    {
        if (index < this.elementos.Count)
        {
            this.elementos.RemoveAt(index);
        }
    }

    public int IndexOf(T item)
    {
        return this.elementos.IndexOf(item);
    }

    public string PrintAll()
    {
        string salida = "";
        foreach (T item in this.elementos)
        {
            salida += item.ToString();
        }
        return salida;
    }

    public bool FindItem(T item)
    {
        return this.elementos.Contains(item);
    }

    
}