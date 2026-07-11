
using System;

namespace Practica2_Ejercicio9
{
	/// <summary>
	/// Description of Alumno.
	/// </summary>
	public class Alumno: Persona
	{
    private int legajo;
    private double promedio;
    private EstrategiaComparacion estrategia;

    // Constructor
    public Alumno(string n, int d, int l, double p) : base(n, d)
    {
        legajo = l;
        promedio = p;
       
    }

    
    public int getLegajo()
    {
        return legajo;
    }

    public double getPromedio()
    {
        return promedio;
    }
    
	public override string ToString()
	{
    	return "Nombre: " + getNombre() +
        " | DNI: " + getDNI() +
        " | Legajo: " + getLegajo() +
        " | Promedio: " + getPromedio();
	}
	//Implemento los metodos de la interface Estrategia...
 	public void setEstrategia(EstrategiaComparacion e)
    {
        this.estrategia = e; //se inicializa la estrategia elegida en LlenarAlumno setEstrategia(new...)
    }
    public override bool sosIgual(Comparable c)
    {												 //El sosIgual que se va a utilizar va a ser el de la clase elegida(Estretegia)
        return estrategia.sosIgual(this, (Alumno)c);// aca el objeto estrategia referencia a la estrategia elegida
    }

    public override bool sosMenor(Comparable c)
    {
        return estrategia.sosMenor(this, (Alumno)c);
    }

    public override bool sosMayor(Comparable c)
    {
        return estrategia.sosMayor(this, (Alumno)c);
    } 	
		
	}
}
