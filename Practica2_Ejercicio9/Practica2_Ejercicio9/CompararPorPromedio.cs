
using System;

namespace Practica2_Ejercicio9
{
	/// <summary>
	/// Description of CompararPorPromedio.
	/// </summary>
	public class CompararPorPromedio:EstrategiaComparacion
	{
		public CompararPorPromedio()
		{
		}
		
		public bool sosIgual(Alumno a1, Alumno a2)
    	{
        	return a1.getPromedio() == a2.getPromedio();
    	}

	    public bool sosMenor(Alumno a1, Alumno a2)
	    {
	        return a1.getPromedio() < a2.getPromedio();
	    }
	
	    public bool sosMayor(Alumno a1, Alumno a2)
	    {
	        return a1.getPromedio() > a2.getPromedio();
	    }
	}
}
