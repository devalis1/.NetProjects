using Arboles;
using System;
using System.Collections.Generic;

public class ArbolBinario
{
    private Nodo raiz;

    public ArbolBinario()
    {
        raiz = null;
    }

    // Método para agregar nodos al árbol (asumiendo un árbol binario de búsqueda)
    public void Agregar(string nombre)
    {
        Nodo nuevo = new Nodo(nombre);
        if (raiz == null)
        {
            raiz = nuevo;
        }
        else
        {
            AgregarRecursivo(raiz, nuevo);
        }
    }

    private void AgregarRecursivo(Nodo actual, Nodo nuevo)
    {
        if (string.Compare(nuevo.Nombre, actual.Nombre) < 0)
        {
            if (actual.Izq == null)
            {
                actual.Izq = nuevo;
            }
            else
            {
                AgregarRecursivo(actual.Izq, nuevo);
            }
        }
        else
        {
            if (actual.Der == null)
            {
                actual.Der = nuevo;
            }
            else
            {
                AgregarRecursivo(actual.Der, nuevo);
            }
        }
    }


    public void RecorridoPreOrden()
    {
        RecorridoPreOrden(raiz);
    }

    private void RecorridoPreOrden(Nodo nodo)
    {
        if (nodo != null)
        {
            Console.WriteLine(nodo.Nombre);
            RecorridoPreOrden(nodo.Izq);
            RecorridoPreOrden(nodo.Der);
        }
    }

    public void RecorridoInOrden()
    {
        RecorridoInOrden(raiz);
    }

    private void RecorridoInOrden(Nodo nodo)
    {
        if (nodo != null)
        {
            RecorridoInOrden(nodo.Izq);
            Console.WriteLine(nodo.Nombre);
            RecorridoInOrden(nodo.Der);
        }
    }

    public void RecorridoPostOrden()
    {
        RecorridoPostOrden(raiz);
    }

    private void RecorridoPostOrden(Nodo nodo)
    {
        if (nodo != null)
        {
            RecorridoPostOrden(nodo.Izq);
            RecorridoPostOrden(nodo.Der);
            Console.WriteLine(nodo.Nombre);
        }
    }

    public void RecorridoPorNiveles()
    {
        if (raiz == null) return;

        Queue<Nodo> cola = new Queue<Nodo>();
        cola.Enqueue(raiz);
        while (cola.Count > 0)
        {
            Nodo actual = cola.Dequeue();
            Console.WriteLine(actual.Nombre);

            if (actual.Izq != null)
                cola.Enqueue(actual.Izq);
            if (actual.Der != null)
                cola.Enqueue(actual.Der);
        }
    }

    public Nodo Buscar(string nombre)
    {
        return BuscarRecursivo(raiz, nombre);
    }

    private Nodo BuscarRecursivo(Nodo nodo, string nombre)
    {
        if (nodo == null || nodo.Nombre == nombre)
            return nodo;

        // Búsqueda recursiva en ambos subárboles
        Nodo encontradoIzq = BuscarRecursivo(nodo.Izq, nombre);
        if (encontradoIzq != null) return encontradoIzq;

        Nodo encontradoDer = BuscarRecursivo(nodo.Der, nombre);
        return encontradoDer;
    }
}