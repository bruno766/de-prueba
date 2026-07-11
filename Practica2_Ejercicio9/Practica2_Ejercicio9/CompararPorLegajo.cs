
using System;

namespace Practica2_Ejercicio9
{
	/// <summary>
	/// Description of CompararPorLegajo.
	/// </summary>
	public class CompararPorLegajo:EstrategiaComparacion
	{
		public CompararPorLegajo()
		{
		}
		
		public bool sosIgual(Alumno a1, Alumno a2)
	    {
	        return a1.getLegajo() == a2.getLegajo();
	    }
	
	    public bool sosMenor(Alumno a1, Alumno a2)
	    {
	        return a1.getLegajo() < a2.getLegajo();
	    }
	
	    public bool sosMayor(Alumno a1, Alumno a2)
	    {
	        return a1.getLegajo() > a2.getLegajo();
	    }
	}
}
