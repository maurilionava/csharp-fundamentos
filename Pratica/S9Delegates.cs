
/*
    DELEGATE é um tipo de dado que armazena referências para métodos
    possui lista de parâmetros e tipo de retorno

    [modificador de acesso] delegate [retorno] [nome delegate]([parâmetros])
*/using System.Security.Cryptography.X509Certificates;

public class Delegates
{
    // 1º declaração do delegate
    public delegate void MeuSinglecastDelegate(string mensagem);
    public delegate void MeuMulticastDelegate(string mensagem);

    public void SinglecastDelegate()
    {
        string mensagem = "hello world";

        // 3º atribuição do método de destino ao delegate
        MeuSinglecastDelegate meuDelegate1 = new MeuSinglecastDelegate(ImprimirMensagem);
        MeuSinglecastDelegate meuDelegate2 = ImprimirMensagem;
        MeuSinglecastDelegate meuDelegate3 = (mensagem) => System.Console.WriteLine(mensagem);

        // 4º invocação do delegate
        meuDelegate1.Invoke(mensagem);
        meuDelegate2(mensagem);
        meuDelegate3(mensagem);
    }

    public void MulticastDelegate()
    {
        string mensagem = "hello world";

        MeuMulticastDelegate meuMulticastDelegate1 = new MeuMulticastDelegate(ImprimirMensagem);
        MeuMulticastDelegate meuMulticastDelegate2 = ImprimirMensagem;
        MeuMulticastDelegate meuMulticastDelegate3 = (mensagem) => System.Console.WriteLine(mensagem);

        meuMulticastDelegate1 += ImprimirMensagem;
        meuMulticastDelegate1 += ImprimirDataMensagem;
        meuMulticastDelegate1 += ImprimirTeste;

        meuMulticastDelegate1 -= ImprimirTeste;

        meuMulticastDelegate1.Invoke(mensagem);
        meuMulticastDelegate1(mensagem);
    }

    // declaração de função in-line, sem nome, que pode ser passada como um parâmetro delegate
    // são dois os tipos: métodos anônimos e expressões lambdas
    public void FuncaoAnonima()
    {
        string mensagem = "hello world";

        MeuSinglecastDelegate funcaoAnonima = delegate (string mensagem)
        {
            System.Console.WriteLine(mensagem);
        };

        funcaoAnonima.Invoke(mensagem);
        funcaoAnonima(mensagem);
    }

    // expressão lambda é uma forma simplificada de declarar uma função anônima
    // é um sugar syntax
    public void ExpressaoLambda()
    {
        MeuSinglecastDelegate expressaoLambda = (string mensagem) =>
        {
            System.Console.WriteLine(mensagem);
        };
    }

    /* 
        PREDICATE: verificar condição específica, recebe um argumento e retorna um booleano
        ACTION: executar ação sem retorno, recebe até 16 argumentos e não possui retorno
        FUNC: executar operação e retornar resultado, recebe de 1 até 16 argumentos e retorna um valor
    */
    public void DelegatesPreDefinidos()
    {
        // verificar se argumento atende a determinado critério, se par, vazio, igual, diferente, etc.
        Predicate<int> predicatePar = x => x % 2 == 0;
        // utilizado em callbacks, eventos, métodos sem retorno
        Action<int> actionExibeMensagem = x => System.Console.WriteLine(x);
        Func<double, double> funcRaizQuadrada = x => Math.Sqrt(x);

        predicatePar.Invoke(1);
        predicatePar(1);
    }

    /*
        mecanismo que notifica classes inscritas quando ocorre determinada ação
        no C# um evento é um delegate encapsulado
        publisher e subscriber (manipuladores de eventos)
        : definir delegate; declarar evento na classe de evento com delegate; disparar evento; inscrever assinantes
    */

    //criar o delegate para o evento
    public delegate void PedidoEventHandler();
    //criar evento com delegate definido anteriormente
    public event PedidoEventHandler? OnCriarPedido;
    public void OnEvento()
    {
        System.Console.WriteLine("evento iniciado");

        if (this.OnCriarPedido is not null)
        {
            //invocar evento
            OnCriarPedido();
        }
    }

    // 2º método de destino do delegate
    public void ImprimirMensagem(string mensagem)
    {
        System.Console.WriteLine($"MENSAGEM: {mensagem}");
    }

    public void ImprimirDataMensagem(string mensagem)
    {
        System.Console.WriteLine($"DATA: {DateTime.Now.ToShortDateString} MENSAGEM: {mensagem}");
    }

    public void ImprimirTeste(string mensagem)
    {
        System.Console.WriteLine();
    }
}

public class MetodosDeExtensao
{
    public void Testar()
    {
        string frase = "hello world";
        string fraseInvertida = frase.InverterString();

        System.Console.WriteLine(fraseInvertida);
    }
}

public static class StringExtensions
{
    public static string InverterString(this string palavra)
    {
        char[] charArray = palavra.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}

public class Email
{
    public void Notificar()
    {
        System.Console.WriteLine("notificando via email");
    }
}

public class SMS
{
    public void Notificar()
    {
        System.Console.WriteLine("notificando via SMS");
    }
}

public class Evento
{
    public void Testar()
    {
        Delegates pedido = new();
        Email email = new();
        SMS sms = new();

        pedido.OnCriarPedido += email.Notificar;
        pedido.OnCriarPedido += sms.Notificar;

        pedido.OnEvento();
    }
}