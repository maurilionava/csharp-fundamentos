/*
* Delegados são tipos que representam referências a métodos com uma lista específica de parâmetros e um tipo de retorno.
* Eles são semelhantes aos ponteiros de função em C/C++, mas são seguros e orientados a objetos.
* Delegados são usados para implementar eventos e callbacks.
* Eles permitem que métodos sejam passados como parâmetros, facilitando a criação de código flexível e reutilizável.
*/
using System.Reflection.Metadata.Ecma335;

public class Delegados
{
    /*
    * Delegados predefinidos em C#:
    * Predicate<T>: Representa um método que define um conjunto de critérios e retorna um valor booleano. Tem exatamente um parâmetro do tipo T.
    * Action: Representa um método que não retorna um valor. Pode ter de 0 a 16 parâmetros.
    * Func<TResult>: Representa um método que retorna um valor do tipo TResult e pode ter de 0 a 16 parâmetros.
    */
    public void DelegadosPreDefinidos()
    {
        Predicate<int> predicate = (x) => x % 2 == 0;
        Action<int> action = (x) => System.Console.WriteLine(x);
        // Func<string, int> func = (x) => System.Console.WriteLine();
    }

    public delegate bool Predicate<in T>(T obj);
    public delegate void Action<in T>(T obj);
    public delegate bool Func<in T>(T obj);

    public void Testar()
    {
        // atribuir o método de destino ou definir uma expressão lambda ao delegate
        SinglecastDelegate meuDelegate1 = new SinglecastDelegate(MetodoDestino1);
        meuDelegate1.Invoke("MENSAGEM");
        SinglecastDelegate meuDelegate2 = MetodoDestino1;
        meuDelegate2.Invoke("MENSAGEM");

        MulticastDelegate multicastDelegate = MetodoDestino1;
        multicastDelegate += MetodoDestino2;

        // DELEGATE COM MÉTODO ANÔNIMO
        var delegateComMetodoAnonimo = delegate (string mensagem)
        {
            System.Console.WriteLine("EXECUTA AÇÃO");
        };
        var singlecastDelegateComMetodoAnonimo = delegateComMetodoAnonimo;
        singlecastDelegateComMetodoAnonimo.Invoke("MENSAGEM");

        // DELEGATE COM EXPRESSÃO LAMBDA (forma encurtada para representar um método anônimo = sugar syntax)
        SinglecastDelegate meuDelegate3 = (mensagem) => System.Console.WriteLine(mensagem);
        meuDelegate3.Invoke("MENSAGEM");
    }

    // implementar método de destino
    static void MetodoDestino1(string mensagem)
    {
        System.Console.WriteLine(mensagem);
    }

    static void MetodoDestino2(string mensagem)
    {
        System.Console.WriteLine(mensagem);
    }
}

// declarar delegate
public delegate void SinglecastDelegate(string mensagem);
public delegate void MulticastDelegate(string mensagem);