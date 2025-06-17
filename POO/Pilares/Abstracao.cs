/*
    OBJETIVO: fornecer uma definição comum de base compartilhada para diversas classes
    implementação ausente ou incompleta que serve como base, não podendo ser instanciada
    não usar os modificadores *virtual* ou *static*
*/

public abstract class FormaAbstrata
{
    public string? Cor { get; set; }
    public double Area { get; set; }
    public double Perimetro { get; set; }

    // métodos abstratos
    public abstract void CalcularArea();
    public abstract void CalcularPerimetro();

    public string Descricao() => "Sou a classe abstrata FormaAbstrata";
}

public class Quadrado : FormaAbstrata
{
    public double Lado { get; set; }

    public override void CalcularArea()
    {
        this.Area = Lado * Lado;
        Console.WriteLine($"Área = {this.Area}");
    }

    public override void CalcularPerimetro()
    {
        this.Perimetro = Lado * 4;
        Console.WriteLine($"Perímetro = {this.Perimetro}");
    }
}