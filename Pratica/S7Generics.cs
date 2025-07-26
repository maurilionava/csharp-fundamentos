/*
    GENERICS refere-se a forma geral, significa não possuir um tipo específico
    BENEFÍCIOS: evitar duplicação de código, type safety, desempenho (evitar operações de boxing e unboxing)
    classes, interfaces, métodos, campos, delegates
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