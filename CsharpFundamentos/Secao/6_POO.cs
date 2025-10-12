public class POO
{

}

public class ClassePai
{
    public ClassePai() => System.Console.WriteLine($"CONSTRUTOR CLASSE PAI SEM PARAMETROS");
    public ClassePai(string valor) => System.Console.WriteLine($"CONSTRUTOR CLASSE PAI COM PARAMETROS");

    protected virtual void MetodoVirtual() => System.Console.WriteLine($"METODO VIRTUAL CLASSE PAI");
    public void Metodo() => System.Console.WriteLine($"METODO CLASSE PAI");
    // public sealed void MetodoSealed() => System.Console.WriteLine($"METODO CLASSE PAI");
}

// herança
public sealed class ClasseFilha : ClassePai
{
    public ClasseFilha() : base() => System.Console.WriteLine($"CONSTRUTOR CLASSE FILHA SEM PARAMETROS");
    public ClasseFilha(string valor) : base(valor) => System.Console.WriteLine($"CONSTRUTOR CLASSE FILHA COM PARAMETROS");

    protected override void MetodoVirtual()
    {
        System.Console.WriteLine($"METODO OVERRIDE CLASSE FILHA");
        base.MetodoVirtual();
    }

    public new void Metodo() => System.Console.WriteLine($"METODO NEW CLASSE FILHA");
}

public sealed class ClasseSelada
{
    // public sealed void MetodoSelado()
    // {

    // }
}

// tipos de herança: simples (conta, contapoupanca), hierarquica (base, filho 1 e filho 2), multinivel(A>B>C), multipla 

// composição e agregação (relacionamento tem-um)

// polimorfismo em tempo de execução e em tempo de compilação

// downcasting(conversao para classe especializada) e upcasting(conversao para classe base)

// operador is e as(operador de conversao)

/// <summary>
/// o modificador abstract demonstra que a solução possui implementação ausente ou incompleta
/// serve como base para outras classes, métodos, etc
/// objetivo: definição comum para outras diversas classes similares
/// </summary>
public abstract class ClasseAbstrata
{

}

/// <summary>
/// contrato sem implementação
/// </summary>
public interface ClasseInterface
{

}