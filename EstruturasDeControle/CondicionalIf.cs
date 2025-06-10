public class CondicionalIf
{
    public void TestarCondicionalIf()
    {
        int numeroEntrada = Convert.ToInt32(Console.ReadLine());
        int numeroComparacao = 0;

        if (numeroEntrada > 0 && true) // operadores lógicos
        {
            Console.WriteLine($"O número digitado {numeroEntrada} é maior que o número {numeroComparacao}");
        }
        else if (numeroEntrada < 0 || false) // operadores lógicos
        {
            Console.WriteLine($"O número digitado {numeroEntrada} é menor que o número {numeroComparacao}");
        }
        else
        {
            Console.WriteLine($"O número digitado {numeroEntrada} é igual ao número {numeroComparacao}");
        }

        //if inline 
        if (numeroEntrada == numeroComparacao) Console.WriteLine("Os números são iguais"); 
    }
}