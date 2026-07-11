
using System;

namespace Practica2_Ejercicio9
{
	class Program
	{
		public static void Main(string[] args)
		{
		    //  Crear colección (podés cambiar por Cola o Conjunto)
		    Coleccionable pila = new Pila();
		
		    //  Llenar con alumnos
		    llenarAlumnos(pila);
		
		    //  Estrategia por NOMBRE
		    Console.WriteLine("=== Comparación por NOMBRE ===");
		    cambiarEstrategia(pila, new CompararPorNombre());
		    informar(pila);
		
		    //  Estrategia por LEGAJO
		    Console.WriteLine("\n=== Comparación por LEGAJO ===");
		    cambiarEstrategia(pila, new CompararPorLegajo());
		    informar(pila);
		
		    //  Estrategia por PROMEDIO
		    Console.WriteLine("\n=== Comparación por PROMEDIO ===");
		    cambiarEstrategia(pila, new CompararPorPromedio());
		    informar(pila);
		
		    //  Estrategia por DNI
		    Console.WriteLine("\n=== Comparación por DNI ===");
		    cambiarEstrategia(pila, new CompararPorDNI());
		    informar(pila);			
			Console.ReadKey(true);
		}
		
		
		public static void informar(Coleccionable c)
    	{
        	Console.WriteLine("Cantidad: " + c.cuantos());

        	Comparable min = c.minimo();
        	Comparable max = c.maximo();

        	Console.WriteLine("Mínimo: " + min);//Gracias al ToString en la clases de los objetos correspondiente (Alumno)
			Console.WriteLine("Maximo: " + max);//Podemos ver Sin castear. solo con el objeto referencia.

        	
        	Console.Write("Ingrese DNI: ");
    		int dni = int.Parse(Console.ReadLine());

    		Comparable buscado = new Alumno("X", dni, 0, 0);
 

        	if (c.contiene(buscado))
        	{
            	Console.WriteLine("El elemento leído esta en la coleccion");
        	}
        	else
        	{
            	Console.WriteLine("El elemento leído no esta en la coleccion");
        	}
   		}
		
		
		public static void llenarAlumnos(Coleccionable c)
		{
		    Random r = new Random();
		
		    string[] nombres = { "Juan", "Ana", "Luis", "Sofia", "Pedro", "Maria" };
		
		    for (int i = 0; i < 20; i++)
		    {
		        string nombre = nombres[r.Next(nombres.Length)];
		        int dni = r.Next(1000, 5000);
		        int legajo = r.Next(100, 999);
		        double promedio = r.Next(1, 11); 
		
		        Alumno alumno = new Alumno(nombre, dni, legajo, promedio);
		        //Estrategia asignada(como se va a comprar Alumno)
		        alumno.setEstrategia(new CompararPorNombre());
		
		        c.agregar(alumno);
		    }
		}
		
		
		public static void imprimirElementos(Coleccionable c)
		{
		    Iterador it = ((Iterable)c).crearIterador();
		
		    it.primero();
		
		    while (!it.fin())
		    {
		        Comparable elem = it.actual();// elem es tipo Comparable por que esa es la forma genérica de Alumno o Persona
		        Console.WriteLine(elem);		//te devuelvo el elemento actual, pero visto como Comparable
											//Comparable es el tipo común que permite que todo el sistema sea genérico y funcione
		        it.siguiente();
		    }
		}						
		
		
		public static void cambiarEstrategia(Coleccionable c, EstrategiaComparacion estrategia)
		{
		    Iterador it = ((Iterable)c).crearIterador();//se inicializa la instancia con IteradorDeArraylist
		
		    it.primero();
		
		    while (!it.fin())
		    {
		        Comparable elem = it.actual();
		
		        //  casting a Alumno (como indica el ejercicio)
		        Alumno a = (Alumno)elem;
		
		        a.setEstrategia(estrategia);
		
		        it.siguiente();
		    }
		}		
	}
}