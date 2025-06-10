public class TratamentoDeErros
{
    public void TestarTryCatch()
    {
        int numero = 1;
        int zero = 0;

        try
        {
            int resultado = numero / zero; // não existe divisão por zero
        }
        catch (Exception e)
        {
            Console.WriteLine("Iniciando tratamento do erro".ToUpper());
            Console.WriteLine($"MENSAGEM: {e.Message}");
            Console.WriteLine($"STACKTRACE: {e?.StackTrace?.ToString()}");
        }
        finally
        {
            Console.WriteLine("Bloco *finally* sempre será executado".ToUpper());
        }
    }
}