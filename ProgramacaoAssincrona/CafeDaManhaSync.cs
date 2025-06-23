using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

public class CafeDaManhaSync
{
    public CafeDaManhaSync()
    {
        System.Console.WriteLine("Iniciando execução do café da manhã síncrono");
    }

    public static void CafeSync()
    {
        CafeDaManhaAsync.stopwatch.Start();
        System.Console.WriteLine("Preparar o café");
        var cafe = PrepararCafe();

        System.Console.WriteLine("Preparar o pão");
        var pao = PrepararPao();

        ServirCafe(cafe, pao);

        System.Console.WriteLine($"Tempo decorrido tarefa síncrona: {CafeDaManhaAsync.stopwatch.Elapsed}");
        CafeDaManhaAsync.stopwatch.Reset();
    }

    static void ServirCafe(Cafe cafe, Pao pao)
    {
        System.Console.WriteLine("Servindo café");
        Thread.Sleep(2000);
        System.Console.WriteLine("Café servido");
    }

    static Cafe PrepararCafe()
    {
        System.Console.WriteLine("Fervendo água");
        Thread.Sleep(3000);
        System.Console.WriteLine("Coando café");
        Thread.Sleep(3000);
        System.Console.WriteLine("Adoçando café");
        return new Cafe();
    }

    static Pao PrepararPao()
    {
        System.Console.WriteLine("Partir o pão");
        Thread.Sleep(2000);
        System.Console.WriteLine("Passar manteiga no pão");
        Thread.Sleep(2000);
        System.Console.WriteLine("Tostar o pao");
        return new Pao();
    }
}

public class Cafe { }

public class Pao{}