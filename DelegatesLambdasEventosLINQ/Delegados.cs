/*
    Um *delegate* é um tipo de dado (referência) que define a assinatura de um método
    Tipo de dado que representa referências a métodos com uma lista de parâmetros e um tipode retorno específicos
    São utilizados para implementar eventos, métodos de retorno de chamada e passar métodos como argumentos em outros métodos
    Permite  aflexibilidade de implementar qualquer funcionalidade me tempo de execução

    Declarar o delegate, definir método de destino, invocar ou chamar o delegate
*/
public class Delegados
{
    // [modificador de acesso] delegate [tipo de retorno] [nome do delegate] ([parametros])
    public delegate void Delegado(string parametro);

    // método de destino
    static void MetodoDelegado(string parametro)
    {
        Console.WriteLine("");
    }

    // atribuir o método de destino
    Delegado d1 = new Delegado(MetodoDelegado);
    // ou
    Delegado d2 = MetodoDelegado;
    // ou define expressão lambda
    Delegado d3 = (msg) => Console.WriteLine();
}