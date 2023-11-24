using System;
public class CalcularIMC
{
    public decimal Peso2;
    public decimal Altura2;

public CalcularIMC (decimal peso2, decimal altura2)
{
    Altura2 = altura2;
    Peso2 = peso2;
        
}
    public decimal calculoIMC2()
    {
        decimal peso2 = (decimal)Peso2;
        decimal altura2 = (decimal) Altura2;

        decimal IMC2 = peso2 / ( altura2 * altura2);

        return IMC2;
    }
}
