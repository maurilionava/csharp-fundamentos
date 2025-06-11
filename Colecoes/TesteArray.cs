using System.Collections;

public class TesteArray
{
    /*
        Conjunto de elementos de mesmo tipo e tamanho fixo
        Uma dimensão é um vetor, mais dimensões é uma matriz
        Usado para armazenar mais de um valor literal do mesmo tipo em uma variável de mesmo nome
    */
    public void TestarArrayUnidimensional()
    {
        // inicialização
        int[] numeros; // declaração da variável
        numeros = new int[4] { 1, 2, 3, 4 }; // alocação de memória
        int[] numeros1 = new int[] { 1, 2, 3, 4 };
        int[] numeros2 = { 1, 2, 3, 4 };

        // for (int aux = 0; aux < numeros0.Length; aux++)
        // {
        //     Console.WriteLine($"{numeros0[aux]}");
        // }

        ExibirArray(numeros);
    }
    
    /*
        A quantidade de elementos em um array multidimensional é igual a x * y * ...
        Se array [2,3] seu total de elementos é 2*3=6
    */
    public void TestarArrayBidimensional()
    {
        int[,] matriz; // declaração da variável
        matriz = new int[2, 2] { { 00, 01 }, { 10, 11 } }; // alocação de memória

        int[,] matriz2 = {
                { 0, 1 },
                { 2, 3 }
            };

        for (var i = 0; i < matriz.GetLength(0); i++)
        {
            for (var j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write($"{matriz[i, j]} ");
            }

            Console.WriteLine();
        }

        // foreach (var valor in matriz)
        // {
        //     Console.Write($"{valor} ");
        // }
    }

    /*
        *params* permite a passagem de argumentos separados por vírgula sem a criação de um array anteriormente
        TestarSomaComParams(1,2,3,4,5)
    */
    public void TestarSomaComParams(params int[] numeros)
    {
        var soma = 0;

        foreach (var numero in numeros)
        {
            soma += numero;
        }

        Console.WriteLine($"Total da soma: {soma}");
    }

    public void TestarClasseArray()
    {
        string[] valores = { "ECHO", "DELTA", "CHARLIE", "BRAVO", "ALFA" };

        ExibirArray(valores);
        
        Array.Sort(valores);

        ExibirArray(valores);

        string valorPesquisa = "CHARLIE";
        int indicePesquisa = Array.BinarySearch(valores, valorPesquisa);
        Console.WriteLine($"Valor {valorPesquisa} encontrado na posição {indicePesquisa}");

        Array.Clear(valores);
        ExibirArray(valores);
    }

    private void ExibirArray(Array vetor)
    {
        foreach (var valor in vetor)
        {
            Console.Write($"{valor} ");
        }
        Console.WriteLine();
    }
}