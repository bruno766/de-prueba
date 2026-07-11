
using System;

namespace Practica2_Ejercicio9
{
	/// <summary>
	/// Description of EstrategiaComparacion.
	/// </summary>
	public interface EstrategiaComparacion
	{
		bool sosIgual(Alumno a1, Alumno a2);
    	bool sosMenor(Alumno a1, Alumno a2);
    	bool sosMayor(Alumno a1, Alumno a2);
	}
}
