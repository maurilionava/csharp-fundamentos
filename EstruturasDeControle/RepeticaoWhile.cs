/*
    A estrutura *WHILE* repete determinado bloco de código enquanto expressão de teste for verdadeira
*/
public class RepeticaoWhile
{
    public void TestarWhile()
    {
        int numero = 0;

        // é executada 0 ou mais vezes
        while (numero < 10)
        {
            Console.WriteLine(numero);
            numero++;

            if (numero == 5)
            {
                Console.WriteLine("Encerrando loop WHILE com BREAK");
                break;
            }
        }

        Console.WriteLine("Fim do teste WHILE");
    }

    // DO-WHILE é executado ao menos UMA vez
    public void TestarDoWhile()
    {
        int numero = 10;

        do
        {
            Console.WriteLine(numero);
            numero++;

            if (numero == 2)
                break;

        } while (numero > 0);

        Console.WriteLine("Encerrando loop DO-WHILE com BREAK");
    }
}

//TABUADA - IF E WHILE
//COORDENADAS - WHILE ANINHADOS