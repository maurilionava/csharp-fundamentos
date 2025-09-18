/// <summary>
/// Erros podem ser gerados pela entrada do usuário, problemas de lógica ou permissões do sistema
/// Exceção: condição de erro ou comportamento inesperado que ocorre durante a execução de programa
/// 
/// </summary>
public class TratamentoDeErros
{
    public void Testar()
    {
        try
        {
            throw new ExcecaoPersonalizada("ERRO PERSONALIZADO");
        }
        catch (ExcecaoPersonalizada e) when (e.Message.Contains("PERSONALIZADO"))
        {
            System.Console.WriteLine("TRATANDO EXCEÇÃO PERSONALIZADA");
            System.Console.WriteLine(e.Message);
            System.Console.WriteLine(e.StackTrace);
            System.Console.WriteLine(e.InnerException);
            System.Console.WriteLine(e.Source);
            System.Console.WriteLine(e.HelpLink);
        }
        catch (Exception e)
        {
            System.Console.WriteLine("TRATANDO EXCEÇÃO GENÉRICA");
        }
        finally
        {
            System.Console.WriteLine("EXECUTANDO BLOCO FINALLY");
        }

        //THROW E THROW EX
    }
}

public class ExcecaoPersonalizada : Exception
{
    public ExcecaoPersonalizada() : base() { }
    public ExcecaoPersonalizada(string? mensagem) : base(mensagem) { }
}