using System.Collections;
using System;

namespace Practica2_Ejercicio9
{
	//Este es el que realmente sabe recorrer.“yo sé recorrer un ArrayList”
	public class IteradorDeArrayList:  Iterador
	{
    private ArrayList elementos;
    private int indice;

    // recibe la colección (no el ArrayList directamente desde afuera)
    public IteradorDeArrayList(ArrayList elementos)
    {
        this.elementos = elementos;
        primero();
    }

    public void primero()
    {
        indice = 0;
    }

    public void siguiente()
    {
        indice++;
    }

    public bool fin()
    {
        return indice >= elementos.Count;
    }
//Aqui es deonde el indice y la lista se conectan. de esta manera indice puede reorrerla
    public Comparable actual()
    {
        return (Comparable)elementos[indice];
    }		
	}
}
