class Program
{
    static void Main(string[] args)
    {
        ManejadorDeArchivos manejador = new ManejadorDeArchivos();

        List<TarjetaCredito> tarjetasDB = manejador.SimularDatosDB();

        // Leer file de tarjetas
        string rutaArchivoEntrada = "tarjetas.txt";
        List<TarjetaCredito> tarjetasArchivo = manejador.LeerTarjetasDesdeArchivo(rutaArchivoEntrada);
        // Escribir file Consolidado.txt
        string rutaArchivoSalida = "Consolidado.txt"; // Se guarda en la ruta \bin\Debug\net8.0 del proyecto
        manejador.EscribirConsolidado(rutaArchivoSalida, tarjetasDB, tarjetasArchivo);

        Console.WriteLine("Proceso de consolidación completado.");
    }
}
