public class OperadoresIsAs
{
    // retorna *true* se conversão de tipos for possível
    public void TestarOperadorIs()
    {
        Object o = new ClasseTeste();

        if (o is ClasseTeste)
        {
            var downcastOperadorAs = o as ClasseTeste;
            Console.WriteLine("Downcast realizado com sucesso");
        }
        else
        {
            Console.WriteLine("Não é possível realizar conversão de tipos");
        }
    }

    /* 
        o operador *as* é um operador de conversão de tipos(de referência, anuláveis compatíveis e boxing)
        retorna *null* quando não for possível realizar a conversão sem gerar exceção
    */
    public void TestarOperadorAs()
    {
        Object o = new ClasseTeste();

        // downcast explícito sem utilização do operador *as*
        try
        {
            ClasseTeste downcastExplicito = (ClasseTeste)o; // downcasting explícito que pode gerar exceção
        }
        catch (InvalidCastException e)
        {
            Console.WriteLine($"Erro na conversão de tipos. {e.Message}");
        }

        // downcast com utilização do operador *as* e *elvis operator* com ?
        ClasseTeste? downcastOperadorAs = o as ClasseTeste;
    }
}

public class ClasseTeste{}