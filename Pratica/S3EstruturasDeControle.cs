public class EstruturasDeControle
{
    #region ESTRUTURAS CONDICIONAIS
    public void EstruturaIf()
    {
        Nullable<int> variavel = null;

        if (variavel == 0 || variavel >= 0 && variavel <= 0 || variavel != 1)
        {
            System.Console.WriteLine("[IF] entrou na condicional if");
        }
        else if (variavel.HasValue)
        {
            System.Console.WriteLine("[ELSE-IF] entrou na condicional elseif");
        }
        else
        {
            System.Console.WriteLine("[ELSE] entrou na condicional else");
        }
    }

    public void EstruturaSwitch()
    {
        int variavel = 0;

        switch (variavel)
        {
            case 0:
                // bloco de instruções
                System.Console.WriteLine($"[SWITCH] case 0");
                break;
            case 1:
                // bloco de instruções
                System.Console.WriteLine($"[SWITCH] case 1");
                break;
            default:
                // bloco de instruções
                System.Console.WriteLine($"[SWITCH] case default");
                break;
        }
    }
    #endregion

    #region ESTRUTURAS DE REPETIÇÃO
    public void EstruturaWhileDoWhile()
    {
        int controle = 0;

        while (controle < 10)
        {
            System.Console.WriteLine($"[WHILE] controle: {controle}");
            controle++;
        }

        do
        {
            System.Console.WriteLine($"[DO-WHILE] controle {controle}");
            controle--;
        } while (controle >= 0);
    }

    public void EstruturaFor()
    {
        // inicialização, condição e iteração
        for (int i = 0; i < 10; i++)
        {
            System.Console.WriteLine($"[FOR] i = {i} \n");

            if (i == 5)
            {
                continue;
            }

            if (i == 1)
            {
                break;
            }
        }
    }

    public void EstruturaForEach()
    {
        List<int> numeros = new List<int> { 0, 1, 2, 3 };

        foreach (var numero in numeros)
        {
            System.Console.WriteLine($"[FOREACH] valor: {numero}");
        }
    }
    #endregion
}