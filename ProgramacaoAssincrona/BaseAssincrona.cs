/*
    Programação assíncrona
        execução de múltiplas tarefas simultaneamente sem bloquear a *thread* principal
        utiliza a biblioteca de tarefas TPL(Task Parallel Library)
        tarefas referentes a *thread* principal
    Programação paralela
        modelo de progração com execução de diversas tarefas ao mesmo tempo aproveitando os recursos do processador
        utiliza a biblioteca *Parallel* do .NET
        utilizada para tarefas que exigem grande poder de processamento
    Duas técnicas para melhorar o processamento da aplicação e que podem ser utilizadas em conjunto
*/
public class BaseAssincrona
{
    /*
        Programação síncrona
            execução das tarefas de forma ordenada, sequencial, iniciando uma apenas quando da conclusão da tarefa anterior
    */
    public void TestarMetodoSincrono()
    {
        int thread = 1;

        Console.WriteLine("Iniciando processamento síncrono");

        var tempoInicial = DateTime.Now;

        for (int i = 0; i < 6; i++)
        {
            Aguardar(thread++, 1000);
        }

        #region melhoria
            // Console.WriteLine($"Iniciando processamento da thread {thread}");
            // Thread.Sleep(1000);
            // Console.WriteLine($"Iniciando processamento da thread {++thread}");
            // Thread.Sleep(1000);
            // Console.WriteLine($"Iniciando processamento da thread {++thread}");
            // Thread.Sleep(1000);
            // Console.WriteLine($"Iniciando processamento da thread {++thread}");
            // Thread.Sleep(1000);
            // Console.WriteLine($"Iniciando processamento da thread {++thread}");
            // Thread.Sleep(1000);
            // Console.WriteLine($"Iniciando processamento da thread {++thread}");
            // Thread.Sleep(1000);
        #endregion

        var tempoDecorrido = DateTime.Now - tempoInicial;

        Console.WriteLine($"Encerrado processamento síncrono. Tempo total: {tempoDecorrido.TotalSeconds}");
    }

    /*
        Programação assíncrona
            async: usado para indicar método que pode ser executado de forma assíncrona
            await: usado para esperar a conclusão de tarefa assíncrona
            exemplos: acesso a arquivos, banco de dados, comunicação com servidores remotos
            não há o bloqueio da thread principal
    */
    public void TestarMetodoAssincrono()
    {
        
    }

    private void Aguardar(int numAuxiliar, int intervaloMilissegundo)
    {
        Console.WriteLine($"Iniciando processamento da thread {numAuxiliar}");
        Thread.Sleep(intervaloMilissegundo);
    }
}