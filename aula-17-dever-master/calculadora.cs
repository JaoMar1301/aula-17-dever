using System;

public class Calcular
{
    public float Numero1;
    public float Numero2;

    public float Soma()
    {
        return  Numero1 + Numero2;
    }
    public float Subtracao()
    {
        return Numero1 - Numero2;
    }
    public float Divisao()
    {
        if(Numero2 != 0)
        {
            return Numero1 / Numero2;
        }else
        {
            Console.WriteLine("0 não é um numero divisivel");
            return 0;
        }
    }
    public float Multuplicação()
    {
        return Numero1 * Numero2;
    }
}