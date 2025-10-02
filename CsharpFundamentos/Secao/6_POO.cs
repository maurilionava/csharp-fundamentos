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