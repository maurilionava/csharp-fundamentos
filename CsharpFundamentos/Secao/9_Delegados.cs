/*
* Delegados são tipos que representam referências a métodos com uma lista específica de parâmetros e um tipo de retorno.
* Eles são semelhantes aos ponteiros de função em C/C++, mas são seguros e orientados a objetos.
* Delegados são usados para implementar eventos e callbacks.
* Eles permitem que métodos sejam passados como parâmetros, facilitando a criação de código flexível e reutilizável.
*/
using System.Reflection.Metadata.Ecma335;

public class Delegados
{
    // 1º declarar delegate
    public delegate void SinglecastDelegate(string mensagem);
    public delegate void MulticastDelegate(string mensagem);

    public void Implementar()
    {
        // 2º definir o método de destino
        static void Metodo(string mensagem) => System.Console.WriteLine();

        // 3º atribuir o método de destino ou atribuir através de uma expressão lambda
        SinglecastDelegate del1 = Metodo;
        MulticastDelegate del2 = Metodo;
        // método anônimo
        del2 += delegate (string mensagem)
        {
            System.Console.WriteLine("MÉTODO ANÔNINO");
        };
        // expressão lambda : sugar syntax para método anônimo
        del2 += (x) => System.Console.WriteLine("EXPRESSÃO LAMBDA (SUGAR SYNTAX PARA MÉTODO ANÔNINO)");

        // 4º invocar delegate
        del1.Invoke("MENSAGEM");
        del2("MENSAGEM");
    }

    /*
    * Delegados predefinidos em C#:
    * Predicate<T>: Representa um método que define um conjunto de critérios e retorna um valor booleano. Tem exatamente um parâmetro do tipo T.
    * Action: Representa um método que não retorna um valor. Pode ter de 0 a 16 parâmetros.
    * Func<TResult>: Representa um método que retorna um valor do tipo TResult e pode ter de 0 a 16 parâmetros.
    */
    public void DelegadosPreDefinidos()
    {
        Predicate<int> predicate = Par;
        predicate = delegate (int valor)
        {
            return valor % 2 == 0;
        };
        predicate = (x) => x % 2 == 0;

        Action<int> action = (x) => System.Console.WriteLine(x * 2);
        
        Func<double, double> func = CalcularRaizQuadrada;
        func = delegate (double valor)
        {
            return Math.Sqrt(valor);
        };
        func = (x) => Math.Sqrt(x);
    }

    public bool Par(int valor)
    {
        return valor % 2 == 0;
    }

    public double CalcularRaizQuadrada(double valor)
    {
        return Math.Sqrt(valor);
    }

    public delegate bool Predicate<in T>(T obj);
    public delegate void Action<in T>(T obj);
    public delegate TResult Func<in T, out TResult>(T obj);
}