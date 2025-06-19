public class DelegatePredicate
{
    /*
    representa um método que recebe um único argumento do tipo T e retorna um booleano
    usado para testar se um objeto satisfaz condição específica
    */
    public DelegatePredicate()
    {
        // delegate bool Predicate<in T>(T obj);
    }

    public void TesteSemDelegate()
    {
        int numero = 0;

        if (VerificaPar(numero))
            Console.WriteLine();
        else
            Console.WriteLine("");
    }

    static bool VerificaPar(int x)
    {
        if (x % 2 == 0)
            return true;
        else
            return false;
    }

    public void TesteDelegatePredicate()
    {
        int numero = 0;

        /* 
            não é necessário criar um delegate e nem um método, basta usar um predicate com método anônimo e lambda expression
            esta é a abordagem mais resumida, seria possível fazer a declaração do método em separado 
            e ainda declarar o método anônino sem o lambda expression
        */
        Predicate<int> delegatePar = x => x % 2 == 0;

        if (delegatePar(numero))
            Console.WriteLine($"O número {numero} é par");
        else
            Console.WriteLine($"O número {numero} é ímpar");
    }
}