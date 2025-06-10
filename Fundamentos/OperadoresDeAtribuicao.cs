public class OperadoresDeAtribuicao
{
    public void TestarOperadoresDeAtribuicaoNumerico()
    {
        decimal decimal1 = 1m;

        decimal1 += 1;
        decimal1 *= 2;
        decimal1 /= 2;
        decimal1 %= 3;
    }

    public void TestarOperadoresDeAtribuicaoString()
    {
        string string1 = "abc";

        string1 += "def";
    }
}
