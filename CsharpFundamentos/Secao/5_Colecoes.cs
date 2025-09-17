using System.Collections;

public class Colecoes
{
    public void Testar()
    {
        /* ARRAY */
        int[] v_arrayInt = [1, 2, 3];
        v_arrayInt.ToList();

        /* 
            ARRAYLIST 
            operações de boxing e unboxing    
        */
        ArrayList v_arrayList = new() { 1, "VALOR", 1.99, new Object() };

        /* LIST */
        List<int> v_listInt = new() { 1, 2, 3 };
        v_listInt.ToArray();
    }

    public void Array()
    {
        int[] v_array = new int[5];
    }

    public void ArrayList()
    {
        ArrayList v_arraylist = new ArrayList();
        v_arraylist.Add(new object());
        v_arraylist.Add("VALOR");
        v_arraylist.Add(1.1m);

        v_arraylist.Remove("VALOR");
    }

    public void List()
    {
        List<int> v_list = new List<int>();
        v_list.Add(2);
        v_list.Add(3);
        v_list.Add(1);

        v_list.Remove(1);
    }
}