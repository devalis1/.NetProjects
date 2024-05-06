using System;
using System.Collections.Generic;

public class Persona
{
    public string DNI { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    private List<Auto> autos;

    public Persona(string dni, string nombre, string apellido)
    {
        DNI = dni;
        Nombre = nombre;
        Apellido = apellido;
        autos = new List<Auto>();
    }

    public List<Auto> ListaDeAutos()
    {
        return new List<Auto>(autos); 
    }

    public void AgregarAuto(Auto auto)
    {
        if (auto != null && !autos.Contains(auto))
        {
            autos.Add(auto);
            auto.Dueño = this;
        }
    }

    public int CantidadDeAutos()
    {
        return autos.Count;
    }

    ~Persona()
    {
        Console.WriteLine($"Destruido Persona con DNI {DNI}");
    }
}
