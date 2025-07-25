/*
    uma EXCEÇÂO é um comportamento inesperado que ocorre durante a execução de um programa
    a EXCEÇÃO em C# é uma classe que herda de System.Exception e armazena dentro dela informações referentes ao erro
    programação defensiva
*/
public class TratamentoErros
{
    public void Testar()
    {
        try
        {
            System.Console.WriteLine("executando bloco principal");
            throw new TesteException("erro personalizado");
        }
        catch (TesteException e)
        {
            System.Console.WriteLine("erro personalizado capturado");
            System.Console.WriteLine($"{e.InnerException} {e.Message} {e.StackTrace} {e.Source} {e.HelpLink}");
        }
        catch (Exception e) when(e.Message.Contains("a"))
        {
            System.Console.WriteLine("erro genérico capturado");
            System.Console.WriteLine($"{e.InnerException} {e.Message} {e.StackTrace} {e.Source} {e.HelpLink}");
        }

        finally
        {
            System.Console.WriteLine("será sempre executado");
        }
    }
}

public class TesteException : Exception
{
    public TesteException(string? message) : base(message)
    {
        System.Console.WriteLine("construtor de exceção personalizada");
    }
}