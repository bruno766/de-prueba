using System.Collections;
using System;

namespace Practica2_Ejercicio9
{
	/// <summary>
	/// Description of Cola.
	/// </summary>
	public class Cola: Coleccionable, Iterable
	{
		  private ArrayList elementos;

    
    public Cola()
    {
        elementos = new ArrayList();
    }

    
    public void encolar(Comparable elem)
    {
        elementos.Add(elem);
    }

    
    public Comparable desencolar()
    {
        if (estaVacia())
        {
            throw new Exception("La cola está vacía");
        }

        Comparable primero = (Comparable)elementos[0];
        elementos.RemoveAt(0);
        return primero;
    }

    
    public Comparable tope()
    {
        if (estaVacia())
        {
            throw new Exception("La cola está vacía");
        }

        return (Comparable)elementos[0];
    }

    
    public bool estaVacia()
    {
        return elementos.Count == 0;
    }
    
    //Utilizamos los metodos de la interface Coleccionable
    public int cuantos()
    {
        return elementos.Count;
    }

    public void agregar(Comparable c)
    {
        encolar(c); 
    }
        public bool contiene(Comparable c)
    {
        foreach (Comparable elem in elementos)
        {
            if (elem.sosIgual(c))
                return true;
        }
        return false;
    }

    public Comparable minimo()
    {
        if (estaVacia())
            throw new Exception("La cola está vacía");

        Comparable min = (Comparable)elementos[0];

        foreach (Comparable elem in elementos)
        {
            if (elem.sosMenor(min))
                min = elem;
        }

        return min;
    }

    public Comparable maximo()
    {
        if (estaVacia())
            throw new Exception("La cola está vacía");

        Comparable max = (Comparable)elementos[0];

        foreach (Comparable elem in elementos)
        {
            if (elem.sosMayor(max))
                max = elem;
        }

        return max;
    }
    public Iterador crearIterador()
    {
        return new IteradorDeArrayList(this.elementos);
    }
    
	}
}
