using Arboles;
using System;

class Program
{
    static void Main(string[] args)
    {
        ArbolBinario arbol = new ArbolBinario();

        // Agregar algunos nodos
        arbol.Agregar("5");
        arbol.Agregar("3");
        arbol.Agregar("7");
        arbol.Agregar("2");
        arbol.Agregar("4");
        arbol.Agregar("6");
        arbol.Agregar("8");

        // Realizar recorridos
        Console.WriteLine("Recorrido PreOrden:");
        arbol.RecorridoPreOrden();

        Console.WriteLine("\nRecorrido InOrden:");
        arbol.RecorridoInOrden();

        Console.WriteLine("\nRecorrido PostOrden:");
        arbol.RecorridoPostOrden();

        Console.WriteLine("\nRecorrido Por Niveles:");
        arbol.RecorridoPorNiveles();

        // Probar la búsqueda
        string valorBuscado = "4";
        Nodo encontrado = arbol.Buscar(valorBuscado);
        if (encontrado != null)
        {
            Console.WriteLine($"\nElemento {valorBuscado} encontrado.");
        }
        else
        {
            Console.WriteLine($"\nElemento {valorBuscado} no encontrado.");
        }
    }
}
