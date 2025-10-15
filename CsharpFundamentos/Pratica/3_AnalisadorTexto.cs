/*
* Analisador de Texto Básico:
* Peça ao usuário para digitar uma frase.
* Exiba o número total de caracteres na frase e a frase em letras maiúsculas.
* Conceitos chave: Tipo string, Propriedade .Length, Métodos de string (.ToUpper()).
*/
public class AnalisadorTexto
{
    public void AnalisarTexto()
    {
        System.Console.WriteLine("DIGITE UMA FRASE PARA INICIAR A ANÁLISE:");
        var frase = Console.ReadLine();

        System.Console.WriteLine($"QUANTIDADE DE CARACTERES NA FRASE: {frase?.Length}");
        System.Console.WriteLine($"FRASE EM LETRAS MAIUSCULAS: {frase?.ToUpper()}");
    }
}