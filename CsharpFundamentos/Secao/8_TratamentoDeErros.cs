public class TratamentoDeErros
{
    public void Testar()
    {
        try
        {
            throw new ExcecaoPersonalizada("ERRO PERSONALIZADO");
        }
        catch (ExcecaoPersonalizada e)
        {
            System.Console.WriteLine("TRATANDO EXCEÇÃO PERSONALIZADA");
        }
        catch (Exception e)
        {
            System.Console.WriteLine("TRATANDO EXCEÇÃO GENÉRICA");
        }
        finally
        {
            System.Console.WriteLine("EXECUTANDO BLOCO FINALLY");
        }
    }
}

public class ExcecaoPersonalizada : Exception
{
    public ExcecaoPersonalizada() : base() { }
    public ExcecaoPersonalizada(string? mensagem) : base(mensagem) { }
}