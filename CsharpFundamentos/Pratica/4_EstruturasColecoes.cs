/*
* Estrutura de Repetição e Coleção Básica:
* Crie uma List<string> de nomes pré-definidos.
* Imprima no console todos os números pares de 0 a 50 usando o loop for.
* Imprima os elementos da lista de nomes usando o loop foreach.
* Conceitos chave: Loops (for, foreach), Coleções (List<T>).
*/
public class EstruturasColecoes
{
    public void TestarEstruturasDeRepeticao()
    {
        for (var x = 0; x <= 50; x++)
        {
            if (x % 2 == 0)
                System.Console.WriteLine(x);
        }

        var nomes = TestarColecoes();
        foreach(var nome in nomes)
        {
            System.Console.WriteLine(nome);
        }
    }

    public List<string> TestarColecoes()
    {
        var nomesList = new List<string> { "AMANDA", "BRUNA", "CARLA", "DAISY", "EMMA" };

        return nomesList;
    }
}