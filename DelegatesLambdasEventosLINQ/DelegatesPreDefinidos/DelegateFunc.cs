/*
    encapsula método que recebe de ZERO até 16 arugmentos do tipo T parâmetros e retorna um valor do tipo TResult
    usado para representar método que execuça uma operação e retorna um resultado
    
    tratamento de coleções, de eventos e consultas em banco de dados e nos métodos de extensão da LINQ
*/
public class DelegateFunc
{
    public DelegateFunc()
    {
        // delegate TResult Func<in T1, in T2, ..., out TResult> (T arg1, T arg2, ...);
    }

    double numero = 2;

    public void TesteSemDelegate()
    {
        double resultado = RaizQuadrada(numero); 
        Console.WriteLine(resultado);
    }

    static double RaizQuadrada(double x)
    {
        return Math.Sqrt(x);
    }

    public void TesteDelegateFunc()
    {
        Func<double, double> raizQuadrada = x => Math.Sqrt(x);
        // ou simplificando
        // Func<double, double> raizQuadrada = Math.Sqrt(x);

        double resultado = raizQuadrada(numero);
        Console.WriteLine(resultado);
    }
}