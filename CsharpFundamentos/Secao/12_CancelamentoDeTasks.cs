using System.Diagnostics;

public class CancelamentoDeTasks
{
    public async Task CancelamentoTimeout(int valor)
    {
        using (var cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(10)))
        {
            Stopwatch stopwatch = new();
            stopwatch.Start();

            try
            {
                await TarefaLongaDuracao(valor, cancellationTokenSource.Token);
            }
            catch (Exception e)
            {
                System.Console.WriteLine($"TAREFA CANCELADA APÓS: {stopwatch.Elapsed}");
                System.Console.WriteLine($"MENSAGEM: {e.Message}");
            }
        }

        using (var cancellationTokenSource = new CancellationTokenSource())
        {
            cancellationTokenSource.CancelAfter(TimeSpan.FromSeconds(10));
            try { }
            catch (Exception e) { }
        }
    }

    public async Task CancelamentoImediato(int valor)
    {
        CancellationTokenSource cancellationTokenSource = new();
        cancellationTokenSource.Cancel();

        Stopwatch stopwatch = new();
        stopwatch.Start();

        try
        {
            await TarefaLongaDuracao(valor, cancellationTokenSource.Token);
        }
        catch (Exception e)
        {
            System.Console.WriteLine($"TAREFA CANCELADA APÓS: {stopwatch.Elapsed}");
            System.Console.WriteLine($"MENSAGEM: {e.Message}");
        }
    }

    public Task TarefaLongaDuracao(int valor, CancellationToken cancellationToken = default)
    {
        System.Console.WriteLine("[INICIANDO OPERACAOLONGADURACAO]");

        Task? task = null;

        // inicia a tarefa e retorna
        task = Task.Run(() =>
        {
            int resultado = 0;
            for (int i = 0; i < valor; i++)
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    throw new TaskCanceledException("[TASK CANCELED EXCEPTION]");
                }

                Thread.Sleep(1000);
                resultado += i;
                System.Console.WriteLine(resultado);
            }
        });

        return task;
    }
}