/// <summary>
/// São utilizados em expressões lógicas
/// resultando *true* ou *false*
/// </summary>
public class OperadoresLogicos
{
    public void TestarOperadoresLogicos()
    {
        bool verdadeiro = true;
        bool falso = false;

        bool e = verdadeiro && falso;
        bool ou = verdadeiro || falso;
        bool negacao = !verdadeiro;
    }
}