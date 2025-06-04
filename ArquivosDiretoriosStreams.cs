public class ArquivosDiretoriosStreams{
    public void EscreverDocumento(string path)
    {
        string pathCompleto = Path.ChangeExtension(path, "txt");

        if (!Directory.Exists(Path.GetDirectoryName(pathCompleto)))
            Directory.CreateDirectory(Path.GetDirectoryName(pathCompleto)!);

        using (StreamWriter sw = new StreamWriter(pathCompleto, true))
        {
            sw.Write($"Atualizado às {DateTime.Now} \n");
        }
    }

    public void LerDocumento(string path)
    {
        string pathCompleto = Path.ChangeExtension(path, "txt");

        using (StreamReader sr = new StreamReader(pathCompleto))
        {
            string? linha = null;

            while ((linha = sr.ReadLine()) != null)
            {
                Console.WriteLine(linha);
            }
        }
    }
}