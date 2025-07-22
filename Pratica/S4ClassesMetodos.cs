/*
    aquilo que é definido como estático não pertence ao objeto, pertence a classe, assim não depende de instanciação para ser acessado
    a referência para o seu valor é compartilhado entre todas suas instâncias
*/

using Microsoft.VisualBasic;

public class ClassesMetodos
{
    // construtor estático utilizado para inicializar atributos estáticos
    static ClassesMetodos()
    {
        qtdeInstancias = 0;
    }

    public ClassesMetodos()
    {
        //bloco de código
        System.Console.WriteLine($"[CLASSESMETODOS] executando construtor sem parâmetros");
        this.atributo1 = "atributo";
    }

    public ClassesMetodos(int x, int y = 0) : this()
    {
        //bloco de código
        System.Console.WriteLine($"[CLASSESMETODOS] executando construtor com parâmetros");
    }

    //atributos = campos e propriedades(encapsulamento)
    static int qtdeInstancias;
    private string atributo1; // campo de apoio da propriedade

    // utilizar PROPRIEDADES afim de encapsular o acesso aos atributos
    public string Propriedade1
    {
        get
        {
            return this.atributo1.ToUpper();
        }
        set
        {
            bool validacao = true;

            if (validacao)
            {
                this.atributo1 = value;
            }
        }
    }

    public static void QtdeInstancias()
    {
        qtdeInstancias++;
    }

    //comportamentos = métodos
    public void Sobrecarga()
    {
        //bloco de código
    }

    public void Sobrecarga(int x)
    {
        //bloco de código
    }

    public int Retorno()
    {
        return 0;
    }

    public void ParametroOpcional(int x = 0)
    {
        // bloco de código
    }

    // REF e OUT: alterações no parâmetro afetam o argumento
    public void ParametroRef(ref int x)
    {
        x *= 2;
    }

    // variáveis OUT não precisam ser inicializadas
    public int ParametroOut(out int y)
    {
        y = 2; // deve-se atribuir valor para variável OUT
        return 1;
    }
}

// STRUCT: value type armazenada na memória stack
// alternativa mais leve a classe, é um tipo de dado formado por outros tipos de dados
// utilizar ao invés de classes quando instância pequena e de curta duração
public struct mStruct
{
    string vString = "valor";
    public int MyProperty { get; private set; }

    public mStruct(string vString)
    {
        this.vString = vString;
    }

    public void Metodo()
    {
        // bloco de código
    }
}

// ENUM: value type
// utilizar CAST para numérico ou para nome do ENUM
public enum Enumerador : byte
{
    JANEIRO = 1,
    JULHO = 7,
    NOVEMBRO = 10,
    DEZEMBRO
}

public class TratamentoDeExcecao
{
    public void Testar()
    {
        try
        {
            //bloco de código
            throw new Exception("lançando nova exceção");
        }
        catch (Exception e)
        {
            System.Console.WriteLine("tratamento de exceção específica");
            System.Console.WriteLine($"{e?.Message} \n{e?.StackTrace?.ToString()} \n{e?.InnerException}");
        }
        finally
        {
            System.Console.WriteLine("será sempre executado");
        }
    }
}

public class ModificadoresDeAcesso
{
    public int vPublic = 0;
    private int vPrivate = 1; // acesso somente dentro da classe
    internal int vInternal = 2; // acesso somente a partir do mesmo assembly
    protected int vProtected = 3; // acesso neste assembly ou em outro que possua classe derivada
}

/// <summary>
/// Tipo(classe) sem nome que contém apenas propriedades públicas somente leitura
/// Derivam diretamente de object
/// </summary>
public class TiposAnonimos
{
    public void Testar()
    {
        var mTipo = new
        {
            AtributoTexto = "valor",
            AtributoInteiro = 0,
            TipoAnonimoInterno = new
            {
                AtributoTexto = "",
                AtributoInteiro = ""
            }
        };

        System.Console.WriteLine($"{mTipo.AtributoTexto}, {mTipo.AtributoInteiro}");
        System.Console.WriteLine(mTipo.GetType().ToString()); // obter o nome dado pelo compilador
    }
}

public partial class ClasseParcial
{
    //atributos
    private int valor = 0;
}