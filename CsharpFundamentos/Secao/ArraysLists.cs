using System.Collections;

public class ArraysLists
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
}