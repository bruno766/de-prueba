using System.Collections;
using System;

namespace Practica2_Ejercicio9
{
	/// <summary>
	/// Description of Conjunto.
	/// </summary>
	public class Conjunto: Coleccionable, Iterable
	{
    private ArrayList elementos;

    public Conjunto()
    {
        elementos = new ArrayList();
    }

    public void agregar(Comparable elemento)
    {
        
        if (!pertenece(elemento))
        {
            elementos.Add(elemento);
        }
    }

    public bool pertenece(Comparable elemento)
    {
        foreach (Comparable c in elementos)
        {
            if (c.sosIgual(elemento))//compara según la estrategia actual del Alumno
            {
                return true;
            }
        }
        return false;
    }

    public int cuantos()
    {
        return elementos.Count;
    }

    public Comparable minimo()
    {
        Comparable min = (Comparable)elementos[0];

        foreach (Comparable c in elementos)
        {
            if (c.sosMenor(min))
            {
                min = c;
            }
        }

        return min;
    }

    public Comparable maximo()
    {
        Comparable max = (Comparable)elementos[0];

        foreach (Comparable c in elementos)
        {
            if (c.sosMayor(max))
            {
                max = c;
            }
        }

        return max;
    }

    public bool contiene(Comparable elemento)
    {
        return pertenece(elemento);
    }
    
       public Iterador crearIterador()
    {
        return new IteradorDeArrayList(this.elementos);
    }
    

    
	}
}
