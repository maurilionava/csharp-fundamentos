using System.ComponentModel;

 /*
    representa (encapsula) um método sem retorno que pode receber de zero até 16 parâmetros de entrada
    usado para executar uma ação sem retorno de valor em arrays e listas como um parâmetro do método *FIND* 
*/
public class DelegateAction
{
    public DelegateAction()
    {
        // delegate void Action<in T>(T obj);
    }

    int numero = 2;

    public void TesteSemDelegate()
    {
        DuplicarSemDelegate(numero);
    }

    static void DuplicarSemDelegate(int numero)
    {
        int resultado = numero * 2;
        Console.WriteLine(resultado);
    }

    public void TesteDelegateAction()
    {
        Action<int> ActionDuplicar = x => Console.WriteLine(x * 2);

        ActionDuplicar(numero);
    }
}