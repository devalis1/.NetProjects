public class TarjetaCredito
{
    public string NumeroTarjeta { get; set; }
    public string Comercio { get; set; }
    public decimal Saldo { get; set; }

    public TarjetaCredito(string numeroTarjeta, string comercio, decimal saldo)
    {
        NumeroTarjeta = numeroTarjeta;
        Comercio = comercio;
        Saldo = saldo;
    }
}