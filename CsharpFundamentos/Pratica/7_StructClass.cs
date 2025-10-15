/*
    Struct vs. Class (Tipos de Valor vs. Referência):

    Crie uma struct Ponto com coordenadas X e Y.
    Crie uma class Coordenada também com X e Y.
    Em seu programa principal, atribua uma instância de Ponto a outra variável (p2 = p1) e modifique p1. Depois, faça o mesmo com a Coordenada (c2 = c1).
    Exiba os valores finais para demonstrar a diferença entre Tipo de Valor (cópia) e Tipo de Referência (apontador).
    Conceitos chave: Struct, Class, Value Type vs. Reference Type.
*/
public class StructClass
{
    public void Testar()
    {
        Ponto ponto = new();
        Coordenada coordenada = new();

        ponto.x = 0;
        ponto.y = 0;
        coordenada.x = 1;
        coordenada.y = 1;

        Ponto ponto2 = ponto;
        Coordenada coordenada2 = coordenada;

        ponto2.x = 2;
        ponto2.y = 3;

        coordenada2.x = 4;
        coordenada2.y = 5;

        System.Console.WriteLine(ponto.x);
        System.Console.WriteLine(ponto.y);
        System.Console.WriteLine(ponto2.x);
        System.Console.WriteLine(ponto2.y);

        System.Console.WriteLine(coordenada.x);
        System.Console.WriteLine(coordenada.y);
        System.Console.WriteLine(coordenada2.x);
        System.Console.WriteLine(coordenada2.y);
    }
}

public struct Ponto
{
    public int x { get; set; }
    public int y { get; set; }
}

public class Coordenada
{
    public int x { get; set; }
    public int y { get; set; }
}