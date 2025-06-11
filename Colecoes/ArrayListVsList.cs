using System.Collections;

public class ArrayListVsList
{
    public void TestarArrayListVsList()
    {
        ArrayList arrayListInt = new() { 1, 2, 3 };
        List<int> listInt = new() { 1, 2, 3 };

        int numeroArrayList = (int)arrayListInt[0];
        int numeroList = listInt[0];
    }

    // *PREDICADO* função/método de argumento único que retorna valor booleano
    public void TestarPredicado()
    {
        List<string> valores = new() { "ALFA", "BRAVO", "CHARLIE", "DELTA", "ECHO", "FOXTROT", "GOLF", "HOTEL" };

        string? resultado = valores.Find(Procura);
    }

    private static bool Procura(string item)
    {
        return item.Contains('E');
    }

    // Métodos Find e Predicados
    // IEnumerable vs List e Lazy Loading
    // Expressões Lambda
    // Indexadores
}