enum DiasDaSemana : byte
{
    Domingo = 1,
    Segunda,
    Terca,
    Quarta,
    Quinta,
    Sexta,
    Sabado
}

public class Enum
{
    public void TestarEnum()
    {
        Console.WriteLine($"Dia número: { (byte)DiasDaSemana.Domingo } Dia texto: { DiasDaSemana.Domingo }");
    }
}