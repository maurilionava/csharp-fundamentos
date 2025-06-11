using System.Collections;

public class TesteArrayList
{
    public void TestarArrayList()
    {
        /*
            ANTIGO E NÃO RECOMENDADO
            
            Coleção não genérica de tamanho dinâmico que armazena diferentes tipos de dados
            Alternativa a coleção Array e possui outras funções

            Capacity: define capacidade da ArrayList e Count: número de elementos existentes na coleção
        */
        ArrayList arrayList; // declaração da variável
        arrayList = new(); // alocação de memória
        arrayList.Add("YANKEE");
        arrayList.Add("JULIET");

        ArrayList arrayList2 = new() { "DELTA", "CHARLIE" };

        ArrayList arrayList3 = new ArrayList() { "ALFA", "MIKE" };

        int[] array = { 1, 2, 3 };
        ArrayList arrayList4 = new ArrayList(array);

        // inserção e remoção de novos elementos
        arrayList.Add("QUEBEC");
        arrayList.AddRange(array);
        arrayList.Insert(0, "ROMEO");
        arrayList.InsertRange(0, array);

        arrayList.Remove("CHARLIE");
        arrayList.RemoveRange(0, 2);

        // verificar existência de elemento na coleção
        string elemento = "MIKE";
        bool existeElemento = arrayList.Contains(elemento);

        if (existeElemento)
            Console.WriteLine($"Elemento *{elemento}* encontrado na coleção");

        // ordenação quick sort
        arrayList.Sort();

        arrayList.Clear();
    }
}