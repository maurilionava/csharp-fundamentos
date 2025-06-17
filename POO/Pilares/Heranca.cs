/*
    A herança é um mecanismo pelo qual uma classe (derivada ou subclasse) pode adquirir
    propriedades e métodos de outra classe (base ou superclasse)

    Relação *É UM*

    Benefícios: reutilização de código, especialização, extensibilidade, encapsulamento
    Desvantagens: acoplamento forte, herança profunda, herança como reutilização excessiva, rigidez do design

    O construtor da classe pai sempre será executado primeiro

    A palavra-chave *base* é utilizada pela classe derivada para acessar os membros da classe pai

    Tipos de herança:
        Simples: uma subclasse que deriva de uma classe base (classe poupança que deriva de classe conta)
        Hierárquica: várias subclasses que derivam de uma mesma classe base (classes gerente, vendedor, etc que derivam de funcionario)
        Multinível: subclasse que deriva de subclasse n vezes e que deriva da base (subclasse cachorro que deriva da subclasse mamifero que deriva da base animal)
        Múltipla(implementação): subclasse que deriva de classe base e implementa uma ou mais interfaces
*/

// atenção a palavra-chave *sealed*
sealed class ClasseNaoSobrescrevivel { }
// cannot derive from sealed type 'ClasseNaoSobrescrevivel'CS0509
// public class FilhoDePaiNaoSobrescrevivel : ClasseNaoSobrescrevivel { }

public class Base
{
    public Base() => Console.WriteLine("CONSTRUINDO CLASSE BASE");

    // comportamentos/métodos
    private string? TestarComportamentoPrivado() => "MEMBRO PRIVADO"; // inacessível pelas subclasses, utilizar propriedades
    public string? TestarComportamentoPublico() => "MEMBRO PÚBLICO";
    // atenção a palavra-chave *virtual* que indica a possibilidade de sobrescrição em classe derivada
    protected virtual string? TestarComportamentoProtegido() => "MEMBRO PROTEGIDO";
    protected virtual void valorNaoSobrescrevivel() => Console.WriteLine("");
}

public class Filho : Base
{
    // construtores
    public Filho() => Console.WriteLine($"CONSTRUINDO CLASSE");
    public Filho(string valor) => Console.WriteLine($"CONSTRUINDO CLASSE {valor}");
    
    // comportamentos/métodos
    // atenção a palavra-chave *new* que indica a substituição do membro da classe base
    public new string? TestarComportamentoPublico() => "MEMBRO PÚBLICO";
    // execução do polimorfismo em tempo de compilação ou dinâmico *virtual* + *override*
    protected override string? TestarComportamentoProtegido() => "SOBRESCREVENDO MÉTODO DA CLASSE BASE";
    sealed protected override void valorNaoSobrescrevivel() => Console.WriteLine("");

    public void TestarAcesso()
    {
        // Console.WriteLine(TestarComportamentoPrivado());
        Console.WriteLine(TestarComportamentoPublico());
        Console.WriteLine(TestarComportamentoProtegido());
    }    
}

public class Neto : Filho
{
    // atenção a palavra-chave *base* indicando a invocação do construtor da classe base
    public Neto() : base() => Console.WriteLine("CONSTRUINDO CLASSE NETO");
    public Neto(string valor) : base(valor) => Console.WriteLine("CONSTRUINDO CLASSE NETO");
}