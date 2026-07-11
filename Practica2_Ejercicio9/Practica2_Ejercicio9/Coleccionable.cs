
using System;

namespace Practica2_Ejercicio9
{
	/// <summary>
	/// Description of Coleccionable.
	/// </summary>
	public interface Coleccionable
	{
		int cuantos();
    	Comparable minimo();
    	Comparable maximo();
    	void agregar(Comparable c);
    	bool contiene(Comparable c);		
	}
}
