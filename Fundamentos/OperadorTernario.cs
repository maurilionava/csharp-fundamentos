public class OperadorTernario
{
    /*
        operador unário - somente um operando
        operador binário - dois operandos
        operador ternário - três operandos ou argumentos *<condicao> ? <expressao_true> : <expressao_false>*
    */
    public void TestarOperadorTernario()
    {
        bool condicao = true;

        Console.WriteLine(condicao ? "SE VERDADEIRO" : "SE FALSO");
    }
}