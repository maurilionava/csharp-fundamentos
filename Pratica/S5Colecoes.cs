/*
    Estruturas de dados

    Arrays: trabalhar com número fixo de objetos de mesmo tipo
    Coleções: flexibilidade quanto ao tipo e quantidade de objetos

    Coleções não genéricas(legadas): ArrayList, Stack, SortedList, Queue, Hashtable
    Coleções genéricas: List, SortedList, Queue, LinkedList, HashSet, SortedSet, Dictionary, SortedDictionary
*/
using System.Collections;

public class Colecoes
{
    // array: conjunto de elementos de mesmo tipo e tamanho fixo
    // vetor ou matriz, 1 dimensão ou 2 ou mais respectivamente
    // acesso via índice a partir do número zero
    public void ColecaoArray()
    {
        int[] array1; // declaração do array
        array1 = new int[3] { 1, 2, 3 }; // alocação de memória

        int[] array2 = new int[] { 1, 2, 3 };
        int[] array3 = { 1, 2, 3 };

        for (int i = 0; i < array3.Length; i++)
        {
            System.Console.WriteLine($"valor na posição {i} : {array3[i]}");
        }

        foreach (var elemento in array3)
        {
            System.Console.WriteLine($"{elemento}");
        }
    }

    // fornece métodos para criar, manipular, pesquisar e classificar arrays
    public void ClasseArray()
    {
        int[] numeros = { 1, 2, 3, 4, 5 };
        Array.Reverse(numeros);
        Array.Sort(numeros);
        int indiceElemento = Array.BinarySearch(numeros, 1);

        if (indiceElemento < 0)
        {
            System.Console.WriteLine("Elemento não encontrado");
        }
        else
        {
            System.Console.WriteLine(numeros[indiceElemento]);
        }
    }

    // como parametros pode-se passar inteiros separados por vírgula sem criar um novo array
    public void Params(params int[] numeros)
    {
        int contador = 0;

        foreach (var numero in numeros)
        {
            contador += numero;
        }

        System.Console.WriteLine($"valor da soma: {contador}");
    }

    public void ArrayBidimensional()
    {
        int[,] array2d; // declaração do array
        int[,,,] array4d; // até 32 dimensões

        array2d = new int[3, 3]
        {
            { 0,1,2 },
            { 3,4,5 },
            { 6,7,8 }
        }; // 3x3 linhas e colunas e alocação do espaço na memória

        for (int i = 0; i < array2d.GetLength(0); i++)
        {
            for (int j = 0; j < array2d.GetLength(1); j++)
            {
                System.Console.WriteLine($"[{i}][{j}]:{array2d[i, j]}");
            }
        }

        foreach (var elemento in array2d)
        {
            System.Console.WriteLine($"{elemento} ");
        }
    }

    /*
        ArrayList transforma todos os seus elementos em Object, afetando o desempenho do código
        Armazena dados de diferentes tipos
        A orientação para o tratamento de coleções heterogêneas é utilizar List<Object>
        Para tratamento de coleçoes homogêneas utilizar List<T> trocar T pelo tipo
    */
    public void ListaArray()
    {
        int[] numeros = new int[3] { 1, 2, 0 };

        ArrayList arrayList1 = new ArrayList() { 1, "xpto", new int[] { 1, 2, 3 }, true };
        ArrayList arrayList2 = new() { 3, 5, 9, 6 };
        ArrayList arrayList3 = new();

        arrayList3.Add(3);
        arrayList3.AddRange(numeros);
        arrayList3.Insert(0, 4);
        arrayList3.InsertRange(0, numeros);
        arrayList3.Sort();
        arrayList3.Remove(3);
        arrayList3.RemoveAt(0);
        arrayList3.RemoveRange(0, 2);
        arrayList3.Clear();
        bool resultado = arrayList3.Contains(null);

        if (resultado)
        {
            System.Console.WriteLine("elemento encontrado");
        }
    }

    /* 
        estrutura de dados dinâmica, fortemente tipada e similar ao ArrayList
        não executa operações de boxing e unboxing por ser genérica
    */
    public void ListaGenerica()
    {
        int[] numeros = new int[3] { 1, 2, 0 };

        List<int> listaGenerica = new List<int>() { 1, 2, 3 };
        var t = listaGenerica[0];

        listaGenerica.Add(3);
        listaGenerica.AddRange(numeros);
        listaGenerica.Insert(0, 4);
        listaGenerica.InsertRange(0, numeros);
        listaGenerica.Sort();
        listaGenerica.Remove(3);
        listaGenerica.RemoveAt(0);
        listaGenerica.RemoveRange(0, 2);
        listaGenerica.Clear();
    }

    public void ConsultaListaComPredicado()
    {
        List<string> cores = new List<string>() { "AZUL", "AMARELO", "VERMELHO", "VERDE", "CINZA", "PRETO", "BRANCO", "AMARELO", "CINZA" };

        string? resultadoCor = cores.Find(c => c == "AZUL");
        resultadoCor = cores.FindLast(c => c == "CINZA");

        int resultadoIndice = cores.FindIndex(c => c == "CINZA");

        List<string> resultadoLista = cores.FindAll(c => c == "AMARELO");
    }
}