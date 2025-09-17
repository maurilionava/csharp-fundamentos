public class Generics<T>
{
    T[] v_array = new T[5];

    public void Metodo1(T v_t) => System.Console.WriteLine();

    public override bool Equals(object? obj)
    {
        if (obj == null)
            return false;

        if (obj is Generics<T>)
            System.Console.WriteLine();

        var other = (Generics<T>)obj;

        return v_array.Equals(other.v_array);
    }

    public override int GetHashCode()
    {
        return v_array.GetHashCode();
    }
}

/// <summary>
/// DICTIONARY,SORTEDDICTIONARY,SORTEDLIST,LINKEDLIST,HASHSET,SORTEDSET,STACK,QUEUE,LIST
/// </summary>
public class ColecoesGenericas
{
    //arraylist - list
    //hashtable - dictionary
    //queue - queue<T>
    //sortedlist - sortedlist<T>
    //stack - stack<T>
    public void TestarDictionary()
    {
        // BRICS
        Dictionary<int, string> v_dictionary = new()
        {
            {2,"RUSSIA"},
            {3,"INDIA"},
            {5,"SOUTH AFRICA"},
            {4,"CHINA"},
            {1,"BRASIL"}
        };

        try
        {
            v_dictionary.Add(5, "SOUTH AFRICA");
        }
        catch (Exception e)
        {
            System.Console.WriteLine($"ERRO: {e.Message}");
        }

        bool v_bool = v_dictionary.TryAdd(6, "IRA");
        v_bool = v_dictionary.ContainsValue("CHINA");
        v_dictionary.Remove(1);

        if (v_dictionary.ContainsKey(1))
            v_dictionary[1] = "BRAZIL";

        SortedDictionary<int, string> v_sorteddictionary = new(v_dictionary);

        v_dictionary.Clear();
    }

    /// <summary>
    /// CONJUNTO DE TERMOS OU SET: coleção que contém apenas itens distintos
    /// </summary>
    public void TestarSet()
    {
        //HASHSET: COLEÇÃO NÃO ORDENADA
        HashSet<string> v_hashset_onu = new HashSet<string>() { "AFEGANISTÃO", "ÁFRICA DO SUL", "ALBÂNIA", "ALEMANHA", "ANDORRA", "ANGOLA", "ANTÍGUA E BARBUDA", "ARÁBIA SAUDITA", "ARGÉLIA", "ARGENTINA", "ARMÊNIA", "AUSTRÁLIA", "ÁUSTRIA", "AZERBAIJÃO", "BAHAMAS", "BANGLADESH", "BARBADOS", "BAREIN", "BÉLGICA", "BELIZE", "BENIM", "BIELORRÚSSIA", "BOLÍVIA", "BÓSNIA E HERZEGOVINA", "BOTSUANA", "BRASIL", "BRUNEI", "BULGÁRIA", "BURKINA FASO", "BURUNDI", "BUTÃO", "CABO VERDE", "CAMARÕES", "CAMBOJA", "CANADÁ", "CATAR", "CAZAQUISTÃO", "CHADE", "CHILE", "CHINA", "CHIPRE", "COLÔMBIA", "COMORES", "CONGO", "COSTA DO MARFIM", "COSTA RICA", "CROÁCIA", "CUBA", "DINAMARCA", "DJIBUTI", "DOMINICA", "EGITO", "EL SALVADOR", "EMIRADOS ÁRABES UNIDOS", "EQUADOR", "ERITREIA", "ESLOVÁQUIA", "ESLOVÊNIA", "ESPANHA", "ESTADOS UNIDOS", "ESTÔNIA", "ESWATINI", "ETIÓPIA", "FEDERAÇÃO DA RÚSSIA", "FIJI", "FILIPINAS", "FINLÂNDIA", "FRANÇA", "GABÃO", "GÂMBIA", "GANA", "GEÓRGIA", "GRANADA", "GRÉCIA", "GUATEMALA", "GUIANA", "GUINÉ", "GUINÉ-BISSAU", "GUINÉ EQUATORIAL",
        "HAITI", "HOLANDA (PAÍSES BAIXOS)", "HONDURAS", "HUNGRIA", "IÊMEN", "ILHAS MARSHALL", "ILHAS SALOMÃO", "ÍNDIA", "INDONÉSIA", "IRÃ", "IRAQUE", "IRLANDA", "ISLÂNDIA", "ISRAEL", "ITÁLIA", "JAMAICA", "JAPÃO", "JORDÂNIA", "KIRIBATI", "KUWAIT", "LAOS", "LESOTO", "LETÔNIA", "LÍBANO", "LIBÉRIA", "LÍBIA", "LIECHTENSTEIN", "LITUÂNIA", "LUXEMBURGO",
        "MACEDÔNIA DO NORTE", "MADAGASCAR", "MALÁSIA", "MALAUI", "MALDIVAS", "MALI", "MALTA", "MARROCOS", "MAURÍCIA", "MAURITÂNIA", "MÉXICO", "MICRONÉSIA", "MOÇAMBIQUE", "MOLDÁVIA", "MÔNACO", "MONGÓLIA", "MONTENEGRO", "MIANMAR",
        "NAMÍBIA", "NAURU", "NEPAL", "NICARÁGUA", "NÍGER", "NIGÉRIA", "NORUEGA", "NOVA ZELÂNDIA", "OMÃ", "PAQUISTÃO", "PALAU", "PANAMÁ", "PAPUA-NOVA GUINÉ", "PARAGUAI", "PERU", "POLÔNIA", "PORTUGAL", "QUÊNIA", "QUIRGUISTÃO", "REINO UNIDO", "REPÚBLICA CENTRO-AFRICANA", "REPÚBLICA DOMINICANA", "REPÚBLICA TCHECA", "REPÚBLICA DEMOCRÁTICA DO CONGO", "ROMÊNIA", "RUANDA", "SAMOA", "SAN MARINO", "SANTA LÚCIA", "SÃO CRISTÓVÃO E NEVES", "SÃO TOMÉ E PRÍNCIPE", "SÃO VICENTE E GRANADINAS", "SEICHELES", "SENEGAL", "SERRA LEOA", "SÉRVIA", "SINGAPURA", "SÍRIA", "SOMÁLIA", "SRI LANKA", "SUAZILÂNDIA (ESWATINI)", "SUÉCIA", "SUÍÇA", "SURINAME", "TADJIQUISTÃO", "TAILÂNDIA", "TANZÂNIA", "TIMOR-LESTE", "TOGO", "TONGA", "TRINDADE E TOBAGO", "TUNÍSIA", "TURCOMENISTÃO", "TURQUIA", "TUVALU", "UCRÂNIA", "UGANDA", "URUGUAI", "UZBEQUISTÃO", "VANUATU", "VENEZUELA", "VIETNÃ", "ZÂMBIA", "ZIMBÁBUE" };
        HashSet<string> v_hashset_otan = new HashSet<string>() { "ALBÂNIA", "ALEMANHA", "BÉLGICA", "BULGÁRIA", "CANADÁ", "CROÁCIA", "DINAMARCA", "ESLOVÁQUIA", "ESLOVÊNIA", "ESPANHA", "ESTADOS UNIDOS", "ESTÔNIA", "FRANÇA", "GRÉCIA", "HUNGRIA", "ISLÂNDIA", "ITÁLIA", "LETÔNIA", "LITUÂNIA", "LUXEMBURGO", "MONTENEGRO", "NORUEGA", "PAÍSES BAIXOS", "POLÔNIA", "PORTUGAL", "REPÚBLICA TCHECA", "ROMÊNIA", "TURQUIA", "REINO UNIDO", "MACEDÔNIA DO NORTE", "FINLÂNDIA", "SUÉCIA" };
        HashSet<string> v_hashset_brics = new HashSet<string>() { "CHINA", "RUSSIA", "INDIA", "SOUTH AFRICA", "BRASIL", "IRA" };

        bool v_bool = v_hashset_brics.Remove("IRA");
        v_hashset_brics.Contains("RUSSIA");
        int v_int = v_hashset_brics.Count();

        v_hashset_otan.IntersectWith(v_hashset_brics); // interseção
        v_hashset_otan.UnionWith(v_hashset_brics); // soma
        v_hashset_otan.ExceptWith(v_hashset_brics); // diferença
        v_hashset_otan.SymmetricExceptWith(v_hashset_brics); // outer join

        v_hashset_onu.IsSupersetOf(v_hashset_brics);
        v_hashset_brics.IsSubsetOf(v_hashset_onu);
        v_hashset_otan.Overlaps(v_hashset_onu);

        //SET: COLEÇÃO ORDENADA
        SortedSet<string> v_sortedset_brics = new SortedSet<string>(v_hashset_brics);
        SortedSet<string> v_sortedset_otan = new SortedSet<string>(v_hashset_otan);
    }

    /// <summary>
    /// Pilha, segue o princípio LIFO
    /// </summary>
    public void TestarStack()
    {
        // HashSet<string> v_hashset_brics = new HashSet<string>() { "CHINA", "RUSSIA", "INDIA", "SOUTH AFRICA", "BRASIL", "IRA" };
        // SortedSet<string> v_sortedset_brics = new SortedSet<string>(v_hashset_brics);

        Stack<int> v_stack = new Stack<int>();
        v_stack.Push(1);
        v_stack.Push(2);
        v_stack.Push(3);
        int v_int = v_stack.Pop();
        v_int = v_stack.Peek();
        bool v_bool = v_stack.Contains(0);
        int[] v_array = v_stack.ToArray();
        v_stack.Clear();
    }

    /// <summary>
    /// Fila, segue o princípio FIFO
    /// </summary>
    public void TestarQueue()
    {
        Queue<int> v_queue = new Queue<int>();
        v_queue.Enqueue(1);
        v_queue.Enqueue(2);
        v_queue.Enqueue(3);
        v_queue.Dequeue();
    }

    public void Testar()
    {
        List<int> v_list = new() { 1, 2 };

        SortedList<int, string> v_sortedlist = new()
        {
            {2,"RUSSIA"},
            {3,"INDIA"},
            {5,"SOUTH AFRICA"},
            {4,"CHINA"},
            {1,"BRASIL"}
         };
    }
}