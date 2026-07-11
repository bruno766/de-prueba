
using System;

namespace Practica2_Ejercicio9
{
	/// <summary>
	/// Description of Persona.
	/// </summary>
	public abstract class Persona: Comparable
	{
    private string nombre;
    private int dni;

    
    public Persona(string n, int d)
    {
        nombre = n;
        dni = d;
    }

    
    public string getNombre()
    {
        return nombre;
    }

    public int getDNI()
    {
        return dni;
    }

    // Implementacion de Comparable Por DNI

    public virtual bool sosIgual(Comparable c)
    {
        Persona otra = (Persona)c;
        return this.dni == otra.dni;
    }

    public virtual bool sosMenor(Comparable c)
    {
        Persona otra = (Persona)c;
        return this.dni < otra.dni;
    }

    public virtual bool sosMayor(Comparable c)
    {
        Persona otra = (Persona)c;
        return this.dni > otra.dni;
    }						
	}
}
