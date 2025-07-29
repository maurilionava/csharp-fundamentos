/*
    GENERICS refere-se a forma geral, significa não possuir um tipo específico
    BENEFÍCIOS: evitar duplicação de código, type safety, desempenho (evitar operações de boxing e unboxing)
    utilizadas em classes, interfaces, métodos, campos, delegates
*/
public class Generics<T> //where T : class, struct, int, new()
{
    public void Comparar<T>(T p1, T p2)
    {
        System.Console.WriteLine($"tipos p1: {p1.GetType()} p2: {p2.GetType()}");
        System.Console.WriteLine($"p1 e p2 são iguais? {p1.Equals(p2)}");
    }

    public void Teste<T1, T2>(T1 p1, T2 p2) { }
}

public class NoGenerics
{
    public bool Comparar(int p1, int p2)
    {
        return p1.Equals(p2);
    }

    public bool Comparar(float p1, float p2)
    {
        return p1.Equals(p2);
    }

    public bool Comparar(string p1, string p2)
    {
        return p1.Equals(p2);
    }
}

/*
    COLEÇÕES NÃO GENÉRICAS: armazenam todos os dados como objetos OBJECTS que gera operações de BOXING e UNBOXING
        ArrayList, HashTable, SortedList, Stack, Queue
    COLEÇÕES GENÉRICAS: fortemente tipadas, não executam operações de boxing e unboxing e facilitam a reutilização de código
        Dictionary<TKey,TValue>, SortedDictionary<TKey,TValue>, SortedList<TKey,TValue>, LinkedList<TKey,TValue>,
        HashSet<T>, SortedSet<T>, Stack<T>, Queue<T>, List<T>
*/
public class ColecoesGenericas
{
    public void Dictionary()
    {
        int chave = 0;
        string? valor = string.Empty;
        Dictionary<int, string> dictionary = new Dictionary<int, string>();
        Dictionary<int, string> dictionary2 = new Dictionary<int, string>()
        {
            {chave, valor},
            {chave, valor}
        };

        dictionary[chave] = valor;
        var item = dictionary[chave];
        var count = dictionary.Count;
        var keys = dictionary.Keys;
        var values = dictionary.Values;
        var comparer = dictionary.Comparer;

        dictionary.Add(chave, valor);
        dictionary.TryAdd(chave, valor);
        dictionary.Clear();
        dictionary.ContainsKey(chave);
        dictionary.ContainsValue(valor);
        dictionary.Remove(chave);

        if (dictionary.TryGetValue(chave, out string? valorSaida))
        {
            System.Console.WriteLine(valorSaida);
        }
    }

    /*
        utiliza árvore binária para manter elementos ordenados
    */
    public void SortedDictionary()
    {
        int chave = 0;
        string? valor = string.Empty;
        SortedDictionary<int, string> sortedDictionary = new SortedDictionary<int, string>()
        {
            {chave, valor},
            {chave, valor}
        };

        // possui propriedades e métodos similares aos do DICTIONARY
    }

    /*
        HASHSET e SORTEDSET são coleções de tamanho dinâmico utilizadas para itens distintos
    */
    public void HashSet()
    {
        int valor = 0;
        List<int> conjunto = new List<int>() { 1, 2, 3 };

        HashSet<int> hashset = new HashSet<int>();
        HashSet<int> hashsetInicializado = new HashSet<int>() { 3, 2, 1, 0 };

        //propriedades
        var count = hashset.Count;
        var compararer = hashset.Comparer;

        //métodos
        hashset.Add(valor);
        hashset.Contains(valor);
        hashset.Remove(valor); //remover um item
        hashset.ExceptWith(conjunto); //remover todos os objetos do hashset que existam na coleção do parâmetro
        hashset.IntersectWith(conjunto); //modificar a coleção atual para que contenha a interseção entre duas coleções
        hashset.IsSubsetOf(conjunto); //verificar se conjunto é um sobconjunto do hashset
        hashset.Overlaps(conjunto); //verificar se ambas as coleções compartilham elementos comuns
        hashset.RemoveWhere(v => v == 0); //remover todos os elementos que atendam ao predicado
        hashset.SetEquals(conjunto); //verificar se coleções contém os mesmos elementos
        hashset.SymmetricExceptWith(conjunto); //modificar hashset atual para que contenha apenas a diferença entre coleções
        hashset.UnionWith(conjunto); //modificar hashset atual para que contenha elementos de ambas as coleções

    }

    /*
        coleção genérica ORDENADA, de tamanho dinâmico, similar a HashSet
    */
    public void SortedSet()
    {
        List<int> conjunto = new List<int>() { 2, 3, 1 };

        //inicialização
        SortedSet<int> sortedSet = new SortedSet<int>();
        SortedSet<int> sortedSetInicializado1 = new SortedSet<int>() { 3, 0, 2, 1 };
        SortedSet<int> sortedSetInicializado2 = new SortedSet<int>(conjunto);

        //propriedades similares as de HashSet
        var max = sortedSet.Max;
        var min = sortedSet.Min;

        //métodos similares aos de HashSet
    }

    /*
        LIFO last in first out - estrutura de pilha
        serve para armazenamento temporários de valores
        *função desfazer(undo) é uma pilha*
    */
    public void Stack()
    {
        int valor = 0;

        //inicialização
        Stack<int> stack = new Stack<int>();
        Stack<int> stack2 = new Stack<int>(new List<int>() { 1, 2, 3 });

        //propriedades
        var count = stack.Count;

        //métodos
        stack.Push(valor); //adiciona elemento ao topo da pilha
        stack.Pop(); //remove elemento do topo da pilha
        stack.Peek(); //retorna o elemento do topo da pilha sem removê-lo
        stack.Contains(valor);
        stack.Clear();
        stack.ToArray();
    }

    /*
        coleção genérica de tamanho variável que funciona com base no princípio FIFO fisrt in first out - estrutura de fila
    */
    public void Queue()
    {
        int valor = 0;

        //inicialização
        Queue<int> queue = new Queue<int>();
        Queue<int> queue2 = new Queue<int>(new List<int>() { 1, 2, 3 });

        //propriedades

        //métodos
        queue.Enqueue(valor);
        queue.Dequeue();
        queue.Peek();
    }
}