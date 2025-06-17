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
        // exception filter *when(filtro/critério/condição*)
        catch (DivideByZeroException d) when (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
        {
            Console.WriteLine($"{d.Message}");
        }
        catch (OverflowException o) when (o.Message.Contains("overflow")) // tratamento da exceção mais genérica por último
        {
            Console.WriteLine("Iniciando tratamento do erro".ToUpper());
            Console.WriteLine($"MENSAGEM: {o.Message}");
            Console.WriteLine($"STACKTRACE: {o?.StackTrace?.ToString()}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"{e.Message}");
        }
        finally
        {
            Console.WriteLine("Bloco *finally* sempre será executado".ToUpper());
        }
    }

    public void TestarNovaExcecao()
    {
        try
        {
            if (true) throw new NovaExcecao("Lançando NovaExceção");

            var a = 0;
            var b = 1;
            var resultado = b / a;
        }
        catch (NovaExcecao e)
        {
            System.Console.WriteLine("Tratando *NovaExcecao*");
        }
        catch (Exception e)
        {
            System.Console.WriteLine(e.Message);
        }
        finally
        {
            System.Console.WriteLine("Executando o bloco *finally*");
        }
    }
}