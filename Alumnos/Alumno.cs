using System;

public class Alumno
{
    public int Legajo { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }

    private DateTime fechaNacimiento;
    public DateTime FechaNacimiento
    {
        set { fechaNacimiento = value; }
    }

    private DateTime fechaIngreso;
    public DateTime FechaIngreso
    {
        set { fechaIngreso = value; }
    }

    public int Edad
    {
        get { return DateTime.Now.Year - fechaNacimiento.Year; }
    }

    public bool Activo { get; set; }

    private int cantMateriasAprobadas;
    public int CantMateriasAprobadas
    {
        set { cantMateriasAprobadas = value; }
    }

    public Alumno() { }

    public Alumno(int legajo, string nombre, string apellido, DateTime fechaNac, DateTime fechaIng, bool activo, int cantMatAprob)
    {
        Legajo = legajo;
        Nombre = nombre;
        Apellido = apellido;
        FechaNacimiento = fechaNac;
        FechaIngreso = fechaIng;
        Activo = activo;
        CantMateriasAprobadas = cantMatAprob;
    }

    public int Antiguedad(string unidad)
    {
        int años = DateTime.Now.Year - fechaIngreso.Year;
        int meses = DateTime.Now.Month - fechaIngreso.Month;
        if (fechaIngreso.AddYears(años) > DateTime.Now) años--;
        if (unidad == "años") return años;
        if (unidad == "meses") return años * 12 + meses;
        if (unidad == "días") return (int)((DateTime.Now - fechaIngreso).TotalDays);
        return 0;
    }

    public int MateriasNoAprobadas()
    {
        return 36 - cantMateriasAprobadas;
    }

    public int EdadDeIngreso()
    {
        return fechaIngreso.Year - fechaNacimiento.Year;
    }

    public DateTime GetFechaNacimiento()
    {
        return fechaNacimiento;
    }

    public DateTime GetFechaIngreso()
    {
        return fechaIngreso;
    }

    ~Alumno()
    {
        Console.WriteLine($"Alumno Liberado: {Legajo} - {Nombre} {Apellido}");
    }
}
