// expressão lambda é uma simplificação de um método anônimo
public class ExpressaoLambda
{
    public void TestarExpressaoLambda()
    {
        List<string> lista = new() { "valor 01" };

        var resultado = lista.Find(valor => valor.Equals("valor 01"));

        Console.WriteLine(resultado);
    }
}