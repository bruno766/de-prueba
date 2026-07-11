
using System;

namespace Practica2_Ejercicio9
{
	/// <summary>
	/// Description of Iterable.
	/// </summary>
	public interface Iterable//Esta encapsula a la coleccion  para no saber que se esta recorriendo,“yo te doy la forma correcta de recorrerme”lo implementan las colecciones que van a ser recorreidas por el iterador
	{
		Iterador crearIterador();	
	}
}
