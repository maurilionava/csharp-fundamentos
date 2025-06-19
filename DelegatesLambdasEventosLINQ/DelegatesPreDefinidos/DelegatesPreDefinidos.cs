/* 
    Delegates pré definidos da linguagem C# - Predicate, Action, Func
    *delegates* são tipos de dados que representam referências a métodos com determinada assinatura
    lembrando: declarar, inicializar, invocar

    Predicate, Action, Func - são tipos de referências que encapsulam um método e estão prontos para serem utilizados
*/

public class DelegatesPreDefinidos
{
    /*
        representa (encapsula) um método que recebe um único argumento do tipo T e retorna um booleano
        usado para testar se um objeto satisfaz condição específica
    */
    public class TestarPredicate()
    {
        delegate bool Predicate<in T>(T obj);
    }

    /*
        representa (encapsula) um método sem retorno que pode receber de zero até 16 parâmetros de entrada
        usado para executar uma ação sem retorno de valor
    */
    public class TestarAction()
    {
        delegate void Action<in T>(T obj);
    }

    /*
        recebe de 1 até 16 arugmentos do tipo T de entrada e retorna um valor do tipo TResult
        usado para representar método que execuça uma operação e retorna um resultado
    */
    public class TestarFunc()
    {
        delegate TResult Func<in T, out TResult>(T arg);
    }
}