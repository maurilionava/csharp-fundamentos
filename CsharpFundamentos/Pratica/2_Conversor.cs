/* 
* Conversor de Tipos e Tratamento de Erro (Try-Parse):
* Peça ao usuário para digitar uma string que deveria ser um número ("150").
* Tente converter a string para um inteiro usando o método int.TryParse().
* Se a conversão for bem-sucedida, exiba o número. Se falhar, exiba uma mensagem de erro amigável.
* Conceitos chave: int.TryParse() (melhor que Parse), Conversão de Tipos, Estrutura de Decisão (if/else).
*/
public class Conversor
{
    public void Converter()
    {
        System.Console.WriteLine("DIGITE UM NÚMERO:");
        var numeroString = Console.ReadLine();
        var resultadoConversao = int.TryParse(numeroString, out var numeroConvertido);

        if (resultadoConversao)
        {
            System.Console.WriteLine($"{numeroConvertido}");
        } else
        {
            System.Console.WriteLine("NÃO FOI POSSÍVEL CONVERTER O VALOR INFORMADO PARA NÚMERO INTEIRO.");
        }
    }
}