using System;
using System.Collections.Generic;
using System.Linq;

public class AdministradorDePersonasYAutos
{
    private List<Persona> personas;
    private List<Auto> autos;

    public AdministradorDePersonasYAutos()
    {
        personas = new List<Persona>();
        autos = new List<Auto>();
    }

    public void AgregarPersona(Persona persona)
    {
        if (persona == null || personas.Any(p => p.DNI == persona.DNI))
        {
            throw new Exception("Ya existe alguien con este DNI !!!");
        }
        personas.Add(persona);
    }

    public void EliminarPersona(string dni)
    {
        Persona persona = personas.FirstOrDefault(p => p.DNI == dni);
        if (persona == null)
        {
            throw new Exception("No existe alguien con este DNI !!!");
        }
        personas.Remove(persona);
    }

    public void ModificarPersona(Persona pPersona)
    {
        Persona persona = personas.FirstOrDefault(p => p.DNI == pPersona.DNI);
        if (persona == null)
        {
            throw new Exception("No existe alguien con este DNI !!!");
        }
        persona.Nombre = pPersona.Nombre;
        persona.Apellido = pPersona.Apellido;
    }

    public List<Persona> ObtenerPersonas()
    {
        return new List<Persona>(personas);
    }

    public void AgregarAuto(Auto auto)
    {
        if (auto == null || autos.Any(a => a.Patente == auto.Patente))
        {
            throw new Exception("Ya existe un auto con esta patente !!!");
        }
        autos.Add(auto);
    }

    public void EliminarAuto(string patente)
    {
        Auto auto = autos.FirstOrDefault(a => a.Patente == patente);
        if (auto == null)
        {
            throw new Exception("No existe un auto con esta patente !!!");
        }
        autos.Remove(auto);
    }

    public void ModificarAuto(string patente, string nuevaMarca, string nuevoModelo, string nuevoAño, decimal nuevoPrecio)
    {
        Auto auto = autos.FirstOrDefault(a => a.Patente == patente);
        if (auto == null)
        {
            throw new Exception("No existe un auto con esta patente !!!");
        }
        auto.Marca = nuevaMarca;
        auto.Modelo = nuevoModelo;
        auto.Año = nuevoAño;
        auto.Precio = nuevoPrecio;
    }


    public List<Auto> ObtenerAutos()
    {
        return new List<Auto>(autos);
    }

    public bool ExisteDNI(string dni)
    {
        return personas.Exists(x => x.DNI == dni);
    }

    public bool ExistePatente(string patente)
    {
        return autos.Exists(x => x.Patente == patente);
    }

}

