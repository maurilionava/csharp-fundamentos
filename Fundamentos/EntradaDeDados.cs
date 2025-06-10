public class EntradaDeDados
{
    public void TestarEntradaDeTexto()
    {
        string sringEntrada = Console.ReadLine();

        Console.WriteLine(sringEntrada);
    }

    /// <summary>
    /// Teste do méotodo Console.ReadKey()
    /// retorno: ConsoleKeyInfo da tecla pressionada
    /// </summary>
    public void TestarEntradaDeTecla()
    {
        ConsoleKeyInfo teclaDeEntrada = Console.ReadKey();

        Console.WriteLine(teclaDeEntrada);
    }

    /// <summary>
    /// Teste do método Console.Read() 
    /// retorno: valor ASCII do caractere
    /// </summary>
    public void TestarEntradaDeTeclaID()
    {
        // ASCII da tecla *A* é 65
        int teclaDeEntrada = Console.Read();

        Console.WriteLine(teclaDeEntrada);
    }
}