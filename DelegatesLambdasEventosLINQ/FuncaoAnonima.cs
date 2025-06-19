/* 
    função que não possui nome e pode ser atribuída a uma variável do tipo delegate
    função inline que pode ser atribuída a um delegate
    são dois os tipos de funções anônimas: métodos anônimos e expressões lambdas
*/
public class FuncaoAnonima
{
    public void TestarFuncaoAnonima()
    {
        List<string> nomes = new List<string>();
        nomes.Add("");

        // passando referência ao método 
        // string resultado = nomes.Find(Metodo);

        // criando o método no lugar do parâmetro
        // string? resultado = nomes.Find(delegate (string nome)
        // {
        //     return nome.Equals("");
        // });

        // expressão lambda
        string? resultado = nomes.Find(nome => nome.Equals("")); 
        Console.WriteLine(resultado);
    }

    // substituído por implementação no parâmetro ou por expressão lambda
    static bool Metodo(string nome)
    {
        return nome.Equals("");
    }
}