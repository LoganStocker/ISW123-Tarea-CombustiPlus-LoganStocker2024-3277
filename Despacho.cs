using System;

public class Despacho
{
    public int Numero { get; set; }
    public string Placa { get; set; }
    public string Combustible { get; set; }
    public decimal Galones { get; set; }
    public string Pago { get; set; }
    public decimal Total { get; set; }

    public override string ToString()
    {
        return $"#{Numero:00} {Placa}  {Combustible}  {Galones:0.0} gal  {Pago}  RD$ {Total:N2}";
    }
}
