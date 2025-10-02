/*
* Coleções são estruturas de dados que armazenam múltiplos valores em uma única variável.
* Elas facilitam a organização, manipulação e acesso a conjuntos de dados relacionados.
* As coleções mais comuns em C# incluem Arrays, Lists, Dictionaries e HashSets.
*/
using System.Collections;

public class Colecoes
{
    public void Array()
    {
        int[] v_arrayInt = [1, 2, 3];
        v_arrayInt.ToList();

        int[] v_array = new int[5];
        int[,] v_array_multidimensao = {
            {0,0}, {0,1},
            {1,0},{1,1},
        };
    }

    /* 
        ARRAYLIST 
        operações de boxing e unboxing    
    */
    public void ArrayList()
    {
        ArrayList v_arrayList = new() { 1, "VALOR", 1.99, new Object() };

        ArrayList v_arraylist = new ArrayList();
        v_arraylist.Add(new object());
        v_arraylist.Add("VALOR");
        v_arraylist.Add(1.1m);
        v_arraylist.Sort();
        v_arraylist.Clear();

        v_arraylist.Remove("VALOR");
    }

    public void List()
    {
        List<int> v_listInt = new() { 1, 2, 3 };
        v_listInt.ToArray();

        List<int> v_list = new List<int>();
        v_list.Add(2);
        v_list.Add(3);
        v_list.Add(1);
        v_list.RemoveAt(1);
        v_list.Remove(2);
        v_list.Sort();
        v_list.Clear();

        v_list.Find(v => v == 1);
        v_list.FindIndex(v => v % 2 == 0);
        v_list.FindLast(v => v > 2);
        v_list.FindLastIndex(v => v % 2 != 0);
        v_list.FindAll(v => v >= 0);
        // startswith endswith contains
    }

    public void Params(params int[] valores)
    {
        foreach (int valor in valores)
        {
            System.Console.WriteLine(valor);
        }
    }

    public void Random()
    {
        var newRandom = new Random();
        
    }
}