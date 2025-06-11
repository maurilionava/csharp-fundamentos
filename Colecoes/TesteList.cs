public class TesteList
{
    /*
        Versão genérica da *ArrayList*
        Lista indexada possuindo uma estrutura dinâmica
        Verifica o tipo em tempo de compilação
        Não executa boxing-unboxing por ser genérica
        É um tipo de referência
    */
    public void TestarList()
    {
        string[] vetorString = { "MIKE", "NOVEMBER", "OSCAR" };
        string[] vetorString2 = { "WHISKY", "YANKEE", "ZULU" };

        // definir parâmetro de T - List<T>
        List<int> listaInt = new List<int>();

        List<string> lista;
        lista = new();
        lista.Add("ALFA");
        lista.AddRange(vetorString);
        ImprimirLista(lista, "Add & AddRange");

        string bravo = "BRAVO";
        lista.Insert(1, bravo);
        lista.InsertRange(lista.Count, vetorString2);
        ImprimirLista(lista, "Insert & InsertRange");

        lista.Remove("ZULU");
        lista.RemoveAt(0);
        lista.RemoveRange(0, 2);
        ImprimirLista(lista, "Remove & RemoveAt & RemoveRange");

        lista.Reverse();
        ImprimirLista(lista, "Reverse");

        lista.Clear();
        ImprimirLista(lista, "Clear");
    }

    private void ImprimirLista(List<string> valores, string fraseAuxiliar = "IMPRESSÃO DE DADOS")
    {
        Console.WriteLine($"{fraseAuxiliar}:");
        
        foreach (var valor in valores)
        {
            Console.Write($"{valor} ");
        }
        Console.WriteLine();
    }
}