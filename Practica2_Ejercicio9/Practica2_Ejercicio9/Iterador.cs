
using System;

namespace Practica2_Ejercicio9
{
	/// <summary>
	/// Description of Iterador.
	/// </summary>
	public interface Iterador//Define como recorrer,cualquier cosa que se pueda recorrer, se recorre así
	{
	    void primero();
	    void siguiente();
	    bool fin();
	    Comparable actual();		
	}
}
