public class OperadoresDeIncremento
{
    public void TestarOperadorDeIncrementoDecremento()
    {
        int numAuxiliar = 0;

        // operadores de pré e pós (primeiro resolve depois incrementa) incremento
        numAuxiliar = numAuxiliar + 1;
        numAuxiliar++;
        ++numAuxiliar;

        // operadores de pré e pós (primeiro resolve depois decrementa) decremento
        numAuxiliar = numAuxiliar - 1;
        numAuxiliar--;
        --numAuxiliar;

        Console.WriteLine(numAuxiliar);
    }
}