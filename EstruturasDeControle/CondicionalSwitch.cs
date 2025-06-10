/*
    Verifica o valor da variável
    Mais legível e limpo que IF-ELSE
*/
public class CondicionalSwitch
{
    public void TestarCondicionalSwitch()
    {
        int expressao = 0;

        switch (expressao)
        {
            case 0:
                Console.WriteLine("CASE 0");
                break;
            case 1:
            case 2:
            case 3:
                Console.WriteLine("CASE 1, 2 ou 3");
                break;
            // *DEFAULT* opcional e equivalente ao bloco ELSE
            default:
                Console.WriteLine("CASE DEFAULT");
                break;
        }
    }
}