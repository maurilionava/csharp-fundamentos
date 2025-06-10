public class Classe
{
    /*
        Classe é um tipo estruturado de dados que é definido pelo usuário
        que contém membros
        similar a um projeto de uma casa
        possui atributos(campos, propriedades) e/ou comportamentos(métodos, ações)
        É um modelo para criar objetos (instâncias de uma classe)

        Alocação de memória
        Classe classe; < memória stack
        classe = new Classe(); < armazena referência da memória heap na memória stack
        
        Objeto = instância de uma classe a partir do operador *new*

        O método representa um comportamento da classe a partir de um bloco de código 
        Pode retornar valores de diferentes tipos
        Suas variáveis possuem escopo próprio dentro do bloco do método
        Pode possuir diferentes parâmetros

        Métodos == Funções

        Diferenciar parâmetros (definição do método) e argumentos (valor representado)

        A palavra chave *this* refere-se a instância atual da classe, representa o objeto que está em execução

        Assinatura e sobrecarga de métodos

        Passagem de argumentos por valor(padrão) e por referência(ref e out)

        Classes e métodos estáticos (não são instanciados)
    */

    // *CONSTRUTOR* tipo especial de método usado para criar e inicializar objetos de uma classe a partir do operador *new *
    public Classe() => qtdeDeInstancias += 1; // *EXPRESSION BODY* representação simplificada de método com somente uma linha 
    public Classe(bool verbose) : this() => Console.WriteLine($"Quantidade de instâncias da classe atual: {Classe.qtdeDeInstancias}");
    static Classe() => qtdeDeInstancias = 0;

    // atributos: campos e propriedades
    public static int qtdeDeInstancias; // violação de um dos princípios do paradigma de OO: encapsulamento
    private double valor; // campo de apoio para propriedade
    public double Valor // propriedades: encapsulam o acesso aos dados
    {
        get
        {
            return valor;
        }

        set
        {
            if (value < 0)
                valor = 0;
            else
                valor = value;
        }
    }

    public void TestarAtributoThis(double valor) => this.valor = valor; // *THIS* referencia a instância atual
    public void TestarSobrecargaDeMetodos() => Console.WriteLine();
    public void TestarSobrecargaDeMetodos(string mensagem, int valor) => Console.WriteLine();
    public void TestarParametrosOpcionais(string mensagem = "Hello World") => Console.WriteLine($"{mensagem}"); // o parâmetro opcional deve possuir um valor padrão
    public void TestarParametrosNomeados() => TestarParametrosNomeados(importancia: 0, destino: "", mensagem: "");
    public void TestarParametrosNomeados(string destino, string mensagem, int importancia, string opcional = "opcional")=> Console.WriteLine("Parametros nomeados");

    public void TestarArgumentosPorValor()
    {
        int numero = 10;
        
        Console.WriteLine($"TESTANDO ARGUMENTOS POR VALOR ANTES: {numero}");
        Dobrar(numero);
        Console.WriteLine($"TESTANDO ARGUMENTOS POR VALOR DEPOIS: {numero}");
    }

    // passagem de argumento por referência de área de memória
    public void TestarArgumentosPorReferencia()
    {
        int numero = 10;

        Console.WriteLine($"TESTANDO ARGUMENTOS POR REFERÊNCIA ANTES: {numero}");
        Dobrar(ref numero);
        Console.WriteLine($"TESTANDO ARGUMENTOS POR REFERÊNCIA DEPOIS: {numero}");
    }

    public static int Dobrar(int numero) => numero *= 2;
    public static int Dobrar(ref int numero) => numero *= 2;
}