public class RepeticaoFor
{
    // for(inicialização; condição; iteração) { intruções }
    public void TestarRepeticaoFor()
    {
        for (var aux = 0; aux <= 100; aux++)
        {
            if (aux == 0)
                continue; // prossegue pra próxima iteração

            if (aux > 10)
                break; // encerra a execução do loop

            Console.WriteLine($"1 x {aux} = {1 * aux}");
        }

        Console.WriteLine("Encerrando laço FOR");
    }
}