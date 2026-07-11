using System.Collections;
using System;

namespace Practica2_Ejercicio9
{
	/// <summary>
	/// Description of Pila.
	/// </summary>
	public class Pila:Coleccionable, Iterable
	{
		 private ArrayList elementos;

    public Pila()
    {
        elementos = new ArrayList();
    }

    public void apilar(Comparable elem)
    {
        elementos.Add(elem);
    }
    
     public Comparable desapilar()
    {
        if (estaVacia())
            throw new Exception("La pila está vacía");

        Comparable ultimo = (Comparable)elementos[elementos.Count - 1];//casteo por que ArrayList guarda tipo object
        elementos.RemoveAt(elementos.Count - 1);
        return ultimo;
    }

    public Comparable tope()
    {
        if (estaVacia())
            throw new Exception("La pila está vacía");

        return (Comparable)elementos[elementos.Count - 1];
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
        apilar(c); 
    }
    
 	public bool contiene(Comparable c)
    {
        foreach (Comparable elem in elementos)
        {
            if (elem.sosIgual(c))//elem es tipo Comparable pero en realidad es un Alumno, accede a logica implementada en la clase Alumno/Persona
                return true;
        }
        return false;
    }
	
 	public Comparable minimo()
    {
        if (estaVacia())
            throw new Exception("La pila está vacía");

        Comparable min = (Comparable)elementos[0]; // casteo por que ArrayList guarda tipo object 
                                                   //necesito tratarlo como Comparable
        foreach (Comparable elem in elementos)//recorre todos los elementos
        {									//compara cada uno con el mínimo actual           
            if (elem.sosMenor(min))        // si encuentro uno más chico lo reemplazo
                min = elem;
        }

        return min;
    } 
     
    public Comparable maximo()
    {
        if (estaVacia())
            throw new Exception("La pila está vacía");

        Comparable max = (Comparable)elementos[0];

        foreach (Comparable elem in elementos)
        {
            if (elem.sosMayor(max))
                max = elem;
        }

        return max;
    }
    
    public Iterador crearIterador()// Aqui se decide qué iterador usar, con qué datos
    {
        return new IteradorDeArrayList(this.elementos);// ← pasa su ArrayList interno al iterador
    }
    
	}
}
