/*
* Classes são modelos para criar objetos, encapsulando dados e comportamentos relacionados.
*/
public class ClasseBase
{
    /* DECLARAÇÃO DE VARIÁVEIS */
    protected int v_int = 0;
    protected int v_int1 = 0;
    protected int v_int2 = 0;

    /* 
        CAMPOS E MÉTODOS ESTÁTICOS 
        são campos e métodos da classe e não da instância
        não conseguem ser acessados a partir das instâncias
    */
    public static int qtde_instancias = 0;
    public static DateTime RetornarDataHora() => DateTime.Now;

    /* PROPRIEDADES */
    private int myProperty = 0;
    public int MyProperty
    {
        get { return this.myProperty; }
        private set { this.myProperty = value; }
    }

    /* 
        CONSTRUTOR
        tipo especial de méotodo utilizado para inicializar um objeto
    */
    static ClasseBase()
    {
        System.Console.WriteLine($"{ClasseBase.RetornarDataHora} : CONSTRUTOR ESTÁTICO BASE SEM PARÂMETROS");
        qtde_instancias = 0;
    }

    public ClasseBase()
    {
        System.Console.WriteLine($"{ClasseBase.RetornarDataHora} : CONSTRUTOR BASE SEM PARÂMETROS");
        ClasseBase.qtde_instancias += 1;
    }
    public ClasseBase(int v_int) : this()
    {
        System.Console.WriteLine($"{ClasseBase.RetornarDataHora} : CONSTRUTOR BASE COM PARÂMETRO");
        ClasseBase.qtde_instancias += 1;
    }

    /* MÉTODOS */
    /* EXPRESSÃO LAMBDA E ARGUMENTO OPCIONAL */
    private bool Metodo(string v_string, int v_int, bool v_bool = true) => v_bool;

    /* SOBRECARGA */
    private bool Metodo(bool v_bool = true) => v_bool;
    private bool Metodo(string v_string, bool v_bool = true) => v_bool;
    private bool Metodo(string v_string, decimal v_decimal, bool v_bool = true) => v_bool;

    /* VIRTUAL (BASE) E OVERRIDE (DERIVADA) */
    protected virtual void Sobrescrever() => System.Console.WriteLine($"METODO SOBRESCREVER DA CLASSE BASE");

    /* RETORNO */
    private float Retorno1() => 0.0f;
    private double Retorno2()
    {
        return 0.0d;
    }

    /* PASSAGEM DE ARGUMENTO POR VALOR */
    private int ArgumentoPorValor(int v_int1, int v_int2) => v_int1 + v_int2;

    /* PASSAGEM DE ARGUMENTO POR REFERÊNCIA (REF E OUT) */
    private void ArgumentoPorReferenciaRef(ref int v_int1, ref int v_int2)
    {
        v_int1 = 11;
        v_int1 = 22;
    }

    private void InvocarArgumentoPorReferenciaRef()
    {
        ArgumentoPorReferenciaRef(ref v_int1, ref v_int2);
    }

    private void ArgumentoPorReferenciaOut(out int v_int1, out int v_int2)
    {
        v_int1 = 33;
        v_int2 = 44;
    }

    private void InvocarArgumentoPorReferenciaOut()
    {
        ArgumentoPorReferenciaOut(out int v_int88, out int v_int99);
        System.Console.WriteLine($"{v_int88} {v_int99}");
    }

    /* TRATAMENTO DE ERROS */
    public void TratamentoDeErros()
    {
        try { /* bloco de código que pode gerar exceção */ }
        catch (NullReferenceException e) { /* tratamento para exceção específica */ }
        catch (Exception e) { /* tratamento de exceção genérica */ }
        finally { /* bloco de código que será sempre executado */ }
    }

    public void Testar(int v_int = 0)
    {
        /* CLASSES E OBJETOS */
        Object objeto; // declaração da variável na memória stack
        objeto = new(); // inicialização da variável na memória heap

        /* MÉTODO DE INSTÂNCIA COM PARÂMETRO NOMEADO E OPCIONAL */
        Metodo(v_int: 2, v_string: "VALOR");

        /* palavra-chave *this* refere-se a instância do objeto atual */
        this.v_int = v_int;
    }
}

public class ClasseDerivada : ClasseBase
{
    public ClasseDerivada(int v_int) : base(v_int) => System.Console.WriteLine("CONSTRUTOR DERIVADO COM PARAMETRO");

    /* VIRTUAL E OVERRIDE */
    protected override void Sobrescrever() => System.Console.WriteLine($"METODO SOBRESCREVER DA CLASSE BASE");

    /* ENUM TESTE */
    public void TesteEnum()
    {
        System.Console.WriteLine(MesesEnum.Fevereiro);
        System.Console.WriteLine((int)MesesEnum.Fevereiro);
        System.Console.WriteLine((MesesEnum)101);
    }
}

/* STRUCT */
public struct Struct
{
    public int MyProperty { get; set; }
    public int MyProperty2 { get; set; }

    public void Metodo() => System.Console.WriteLine();
}

/* ENUM */
public enum MesesEnum
{
    Janeiro = 100,
    Fevereiro,
    Marco
}