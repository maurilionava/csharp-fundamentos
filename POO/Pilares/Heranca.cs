/*
    A herança é um mecanismo pelo qual uma classe (derivada ou subclasse) pode adquirir
    propriedades e métodos de outra classe (base ou superclasse)

    Relação *É UM*

    Benefícios: reutilização de código, especialização, extensibilidade, encapsulamento
    Desvantagens: acoplamento forte, herança profunda, herança como reutilização excessiva, rigidez do design

    O construtor da classe pai sempre será executado primeiro
*/
public class Base
{
    public Base() => Console.WriteLine("CONSTRUINDO CLASSE BASE");

    private string? TestarComportamentoPrivado() => "MEMBRO PRIVADO"; // inacessível pelas subclasses, utilizar propriedades
    public string? TestarComportamentoPublico() => "MEMBRO PÚBLICO";
    protected string? TestarComportamentoProtegido() => "MEMBRO PROTEGIDO";
}

public class Filho : Base
{
    public Filho() => Console.WriteLine($"CONSTRUINDO CLASSE");
    public Filho(string valor) => Console.WriteLine($"CONSTRUINDO CLASSE {valor}");

    public void TestarAcesso()
    {
        // Console.WriteLine(TestarComportamentoPrivado());
        Console.WriteLine(TestarComportamentoPublico());
        Console.WriteLine(TestarComportamentoProtegido());
    }    
}

public class Neto : Filho
{
    public Neto() : base() => Console.WriteLine("CONSTRUINDO CLASSE NETO");
    public Neto(string valor) : base(valor) => Console.WriteLine("CONSTRUINDO CLASSE NETO");
}