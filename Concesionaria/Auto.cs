using System;

public class Auto
{
    public string Patente { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public string Año { get; set; }
    public decimal Precio { get; set; }
    public Persona Dueño { get; set; }

    public Auto(string patente, string marca, string modelo, string año, decimal precio)
    {
        Patente = patente;
        Marca = marca;
        Modelo = modelo;
        Año = año;
        Precio = precio;
    }

    ~Auto()
    {
        Console.WriteLine($"Destruido Auto con patente {Patente}.");
    }
}
