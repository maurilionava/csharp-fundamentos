// pouco utilizado e não recomendado
public class RepeticaoGotoLabel
{
    public void TestarRepeticaoGotoLabel()
    {
        int numero = 0;

    repetir:

        Console.WriteLine(numero);
        numero++;

        if (numero < 10)
            goto repetir;
            
        Console.WriteLine("Fim do teste GOTO LABEL");
    }
}