/*
 * Creado por SharpDevelop.
 * Usuario: Diego
 * Fecha: 13/4/2026
 * Hora: 23:45
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica2_Ejercicio9
{
	/// <summary>
	/// Description of CompararPorNombre.
	/// </summary>
	public class CompararPorNombre:EstrategiaComparacion
	{
		public CompararPorNombre()
		{
		}
	    public bool sosIgual(Alumno a1, Alumno a2)
	    {
	        return a1.getNombre() == a2.getNombre();
	    }
	
	    public bool sosMenor(Alumno a1, Alumno a2)//CompareTo compara dos nombres letra por letra y asi decide cual es menor.
	    {
	        return a1.getNombre().CompareTo(a2.getNombre()) < 0;
	    }
	
	    public bool sosMayor(Alumno a1, Alumno a2)
	    {
	        return a1.getNombre().CompareTo(a2.getNombre()) > 0;
	    }		
	}
}
