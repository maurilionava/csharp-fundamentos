public class SaidaDeDados{
    private string stringAuxiliar1 = "Lorem";
    private string stringAuxiliar2 = "Ipsum";

    public void TestarConcatenacao(){
        Console.WriteLine(stringAuxiliar1 + " " + stringAuxiliar2);
    }

    public void TestarInterpolacao(){
        Console.WriteLine($"{stringAuxiliar1} {stringAuxiliar2}");

        // utilizando placeholders
        Console.WriteLine($"{0} {1}", stringAuxiliar1, stringAuxiliar2);
    }

    public void TestarEscapesDeCaracteres()
    {
        string diretorio = "c:\\diretorio\\de\\arquivos";
        string escapeVerbatim = @"c:\\diretorio\\de\\arquivos";
        string escapeUnicodeString = "\u00A9";
        string aux1 = "Frase com escape de \"aspas duplas\"";
        string aux2 = "\n\t";
    }
}