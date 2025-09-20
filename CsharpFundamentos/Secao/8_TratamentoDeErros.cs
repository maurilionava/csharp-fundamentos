/*
* Tratamento de erros em C# é feito principalmente através do uso de blocos try, catch e finally.
* O bloco try contém o código que pode gerar uma exceção, enquanto o bloco catch captura e trata a exceção.
* O bloco finally é opcional e contém código que sempre será executado, independentemente de uma exceção ter sido lançada ou não.
* C# também permite a criação de exceções personalizadas, derivando da classe base Exception.
* A palavra-chave throw é usada para lançar exceções, e o operador when pode ser usado em blocos catch para filtrar exceções com base em condições específicas.
*/
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