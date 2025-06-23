using System.Diagnostics;

public class CafeDaManhaAsync
{
    public static Stopwatch stopwatch = new();

    public CafeDaManhaAsync()
    {
        System.Console.WriteLine("Iniciando execução do café da manhã assíncrono");
    }

    public static async Task CafeAsync()
    {
        stopwatch.Reset();
        stopwatch.Start();

        System.Console.WriteLine("Preparar o café");
        Task<Cafe> taskCafe = PrepararCafeAsync();

        System.Console.WriteLine("Preparar o pão");
        Task<Pao> taskPao = PrepararPaoAsync();

        Cafe cafe = await taskCafe;
        Pao pao = await taskPao;

        ServirCafe(cafe, pao);

        System.Console.WriteLine($"Tempo decorrido tarefa assíncrona: {stopwatch.Elapsed}");
        stopwatch.Stop();
    }

    static async Task<Cafe> PrepararCafeAsync()
    {
        System.Console.WriteLine("Fervendo água");
        await Task.Delay(3000);
        System.Console.WriteLine("Coando café");
        await Task.Delay(3000);
        System.Console.WriteLine("Adoçando café");
        return new Cafe();
    }

    static async Task<Pao> PrepararPaoAsync()
    {
        System.Console.WriteLine("Partir o pão");
        await Task.Delay(2000);
        System.Console.WriteLine("Passar manteiga no pão");
        await Task.Delay(2000);
        System.Console.WriteLine("Tostar o pao");
        return new Pao();
    }
    
    static void ServirCafe(Cafe cafe, Pao pao)
    {
        System.Console.WriteLine("Servindo café");
        Thread.Sleep(2000);
        System.Console.WriteLine("Café servido");
    }
}