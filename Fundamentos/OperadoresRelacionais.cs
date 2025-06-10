public class OperadoresRelacionais
{
    public void TestarOperadoresRelacionais()
    {
        int num1 = 1;
        int num2 = 2;

        bool igual = num1 == num2;
        bool maior = num1 > num2;
        bool menor = num1 < num2;
        bool maiorOuIgual = num1 >= num2;
        bool menorOuIgual = num1 <= num2;
        bool diferente = num1 != num2;

        string palavra1 = "palavra";
        string palavra2 = "dois";

        bool palavrasIguais = palavra1 == palavra2;
        palavrasIguais = palavra1.Equals(palavra2);
        
        Console.WriteLine(igual);
        Console.WriteLine(maior);
        Console.WriteLine(menor);
        Console.WriteLine(maiorOuIgual);
        Console.WriteLine(menorOuIgual);
        Console.WriteLine(diferente);
    }
}