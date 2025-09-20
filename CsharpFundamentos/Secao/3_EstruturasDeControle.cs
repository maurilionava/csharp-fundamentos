/*
* Estruturas de controle são usadas para controlar o fluxo de execução do código com base em condições ou repetições.
* Elas incluem estruturas condicionais (if, else, switch) e estruturas de repetição (for, while, do-while, foreach).
* Essas estruturas permitem que o programa tome decisões e execute blocos de código repetidamente, tornando-o mais dinâmico e funcional.
*/
using System.Collections.Generic;
public class EstruturasDeControle
{
    public void Testar()
    {
        /* ESTRUTURAS CONDICIONAIS */
        // IF-ELSE: Permite executar blocos de código dependendo de uma condição booleana.
        int idade = 32;

        if (idade < 18)
            System.Console.WriteLine("Menor de idade");
        else if (idade >= 18 && idade <= 60)
            System.Console.WriteLine("Adulto");
        else
            System.Console.WriteLine("Idoso");

        // SWITCH-CASE: Permite escolher entre múltiplos caminhos com base no valor de uma variável.
        int dia_semana = 3;

        switch (dia_semana)
        {
            case (1):
                System.Console.WriteLine("Domingo");
                break;
            case (2):
            case (3):
                System.Console.WriteLine("Nme domingo nem segunda");
                break;
            default:
                System.Console.WriteLine("Entrada inválida");
                break;
        }

        /* ESTRUTURAS DE REPETIÇÃO */
        // FOR: Usado quando se conhece o número de repetições.
        for (int aux = 1; aux <= 100; aux++)
        {
            if (aux > 50)
                break; // a execução do laço FOR é interrompida

            if (aux % 2 != 0)
                continue; // a iteração atual é interrompida

            System.Console.WriteLine($"{aux} É UM NÚMERO PAR");
        }

        // FOREACH: Itera sobre coleções (arrays, listas, etc.).
        string[] stringArray = ["Ana", "Bruno", "Carla", "David", "Eva"];

        foreach (var value in stringArray)
        {
            System.Console.WriteLine($"{value}");
        }

        // WHILE: Repete enquanto a condição for verdadeira.
        List<string> stringList = stringArray.ToList();
        while (stringList.Count() > 0)
        {
            System.Console.WriteLine(stringList[0]);
            stringList.RemoveAt(0);
        }

        // DO WHILE
        stringList = stringArray.ToList();
        do
        {
            System.Console.WriteLine(stringList[0]);
            stringList.RemoveAt(0);
        } while (stringList.Count > 0);

    // LABEL GOTO
    repetir:
        int controle = 10;
        if (controle > 0)
        {
            System.Console.WriteLine(controle);
            controle++;
            goto repetir;
        }
    }
}