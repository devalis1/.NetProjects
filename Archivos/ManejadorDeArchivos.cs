using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

public class ManejadorDeArchivos
{
    public List<TarjetaCredito> LeerTarjetasDesdeArchivo(string rutaArchivo)
    {
        List<TarjetaCredito> tarjetas = new List<TarjetaCredito>();

        try
        {
            using (StreamReader sr = new StreamReader(rutaArchivo))
            {
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    if (!string.IsNullOrWhiteSpace(linea))
                    {
                        string[] partes = linea.Split(';');
                        if (partes.Length >= 3)
                        {
                            string numeroTarjeta = partes[0].Split(':')[1].Trim();
                            string comercio = partes[1].Split(':')[1].Trim();
                            decimal saldo = decimal.Parse(partes[2].Split(':')[1].Trim(), CultureInfo.InvariantCulture);
                            tarjetas.Add(new TarjetaCredito(numeroTarjeta, comercio, saldo));
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al leer el archivo: " + ex.Message);
        }

        return tarjetas;
    }



    public void EscribirConsolidado(string rutaArchivo, List<TarjetaCredito> tarjetasDB, List<TarjetaCredito> tarjetasArchivo)
    {
        try
        {
            using (StreamWriter sw = new StreamWriter(rutaArchivo))
            {
                sw.WriteLine("NroTarjeta;SaldoConsolidado;Diferencia");

                foreach (var tarjetaArchivo in tarjetasArchivo)
                {
                    var tarjetaDB = tarjetasDB.FirstOrDefault(t => t.NumeroTarjeta == tarjetaArchivo.NumeroTarjeta);
                    if (tarjetaDB != null)
                    {
                        decimal diferencia = tarjetaArchivo.Saldo - tarjetaDB.Saldo;
                        string saldoConsolidado = diferencia == 0 ? "SI" : "NO";
                        string diferenciaStr = diferencia == 0 ? "0" : diferencia.ToString("+#;-#;0");

                        sw.WriteLine($"{tarjetaDB.NumeroTarjeta};{saldoConsolidado};{diferenciaStr}");
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al escribir el archivo: " + ex.Message);
        }
    }


    public List<TarjetaCredito> SimularDatosDB()
    {
        return new List<TarjetaCredito>
        {
            new TarjetaCredito("1234", "A", 3500),
            new TarjetaCredito("4321", "B", 5788),
            new TarjetaCredito("9999", "C", 5500)
        };
    }
}
