public class Arquivos
{
    // verbatim
    string diretorioArquivo = @"./arquivo.txt";
    string novoDiretorioArquivo = @"./arquivo-copia.txt";

    public void Testar()
    {
        // criar, copiar, excluir, mover e abrir arquivos sem criação de instância
        File.Create(diretorioArquivo);
        File.Copy(diretorioArquivo, novoDiretorioArquivo);
        File.Delete(diretorioArquivo);
        File.Exists(diretorioArquivo);
        File.Move(diretorioArquivo, novoDiretorioArquivo);
        File.Open(diretorioArquivo, FileMode.Open);
        File.AppendAllText(diretorioArquivo, "CONTEUDO");
        File.ReadAllText(diretorioArquivo);
        File.ReadAllLines(diretorioArquivo);
        File.GetLastAccessTime(diretorioArquivo);
        File.WriteAllText(diretorioArquivo, "CONTEUDO");

        // informações detalhadas de um arquivo
        FileInfo fileInfo = new FileInfo(diretorioArquivo);
        var info = fileInfo.Length.ToString();
        info = fileInfo.Extension;
        fileInfo.Refresh();
    }
}

public class Diretorios
{
    // verbatim
    string diretorio = @"./";
    string novoDiretorio = @"./";

    public void Testar()
    {
        Directory.CreateDirectory(diretorio);
        Directory.Delete(diretorio);
        Directory.Exists(diretorio);
        string[] arquivos = Directory.GetFiles(diretorio);
        Directory.Move(diretorio, novoDiretorio);
        Directory.GetDirectories(diretorio);

        DirectoryInfo directoryInfo = new(diretorio);
    }
}

public class Streams
{
    public void Testar()
    {
        
    }
}