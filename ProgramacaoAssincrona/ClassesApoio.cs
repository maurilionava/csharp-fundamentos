/*
    A programação assíncrona é implementada através da utilização da classe *TASK*
    Task: representação assíncrona de uma operação em execução e é usada para a execução de tarefas assíncronas
        é também o tipo de retorno padrão de método assíncrono sem retorno
    *await* é utilizado para aguardar uma operação que retorna um Task ou Task<T>
    *async* é usado para sinalizar que um método é assíncrono

    Tipos de retorno em métodos assíncronos
        Task (métodos sem retorno) ou Task<T> (métodos com retorno)
        ValueTask ou ValueTask<T>
        void : recomendado utilizar somente em manipuladores de eventos
*/
public class ClassesApoio
{
    // sufixo *async* convenção
    public async Task MetodoSemRetornoAsync()
    {
        await Task.Delay(1000);
        System.Console.WriteLine("Operação assíncrona concluída");
    }

    public async Task<int> MetodoComRetornoAsync()
    {
        await Task.Delay(1000);
        System.Console.WriteLine("Operação assíncrona concluída");
        return 1;
    }
}

/*
    a palavra-chave await indica ao compilador que a execução do método se dará em segundo plano
    
    await MetodoSemRetornoAsync();
    var resultado = await MetodoComRetornoAsync();
*/  