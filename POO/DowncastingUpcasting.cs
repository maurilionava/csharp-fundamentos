/* 
    upcasting: conversão de classe especializada para classe base (de circulo para forma)
    downcasting: conversão de classe base para classe especializada (de forma para circulo)
*/
public class DowncastingUpcasting
{
    // especializar base - explícito
    public void TestarDowncasting()
    {
        Forma forma = new();
        Circulo circulo = (Circulo)forma; // pode lançar exceção *InvalidCastException*
    }

    // generalizar classe especializada - implícito
    public void TestarUpcasting()
    {
        Circulo circulo = new();
        Forma forma = circulo;
    }
}

public class Forma
{
    protected int xpos, ypos;

    public Forma() { }

    public Forma(int x, int y)
    {
        xpos = x;
        ypos = y;
    }

    public virtual void Desenhar()
    {
        System.Console.WriteLine($"Desenhar forma na posição ({xpos}, {ypos})");
    }
}

public class Circulo : Forma
{
    public Circulo() { }

    public Circulo(int x, int y) : base(x, y) { }

    public override void Desenhar()
    {
        System.Console.WriteLine($"Desenhar circulo na posição ({xpos}, {ypos})");
    }

    public void PintarCirculo()
    {
        System.Console.WriteLine("Pintar o circulo");
    }
}