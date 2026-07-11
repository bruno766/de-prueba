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
	/// Description of CompararPorDNI.
	/// </summary>
	public class CompararPorDNI:EstrategiaComparacion
	{
		public CompararPorDNI()
		{
		}
		
	    public bool sosIgual(Alumno a1, Alumno a2)
	    {
	        return a1.getDNI() == a2.getDNI();
	    }
	
	    public bool sosMenor(Alumno a1, Alumno a2)
	    {
	        return a1.getDNI() < a2.getDNI();
	    }
	
	    public bool sosMayor(Alumno a1, Alumno a2)
	    {
	        return a1.getDNI() > a2.getDNI();
	    }
	}
}
