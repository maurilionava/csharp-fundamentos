using System.Runtime.InteropServices.Marshalling;

public class ClasseMatematica
{
    public void TestarOperadoresAritmeticos()
    {
        int soma = 1 + 1;
        int subtracao = 1 - 1;
        int multiplicacao = 1 * 1;
        int divisao = 1 / 1;
        int modulo = 3 % 2; // retorno o resto da divisão
    }

    public void TestarClasseMath()
    {
        int num1 = 10;
        int num2 = 20;

        var menorValor = Math.Min(num1, num2);
        var maiorValor = Math.Max(num1, num2);
        var valorAbsoluto = Math.Abs(num1);
        var arredondamentoMatematico = Math.Round(1.1d);
        var arredondamentoAbaixo = Math.Floor(1.1d);
        var potencia = Math.Pow(num1, num2); // num1 elevado a num2
        var raizQuadrada = Math.Sqrt(num1);
        // seno cosseno tangente
    }
}