/*
* Manipulação de arquivos e diretórios em C# usando System.IO.
* Inclui operações como criar, copiar, mover, excluir e ler arquivos e diretórios.
* Demonstra o uso de classes como File, Directory, FileInfo, DirectoryInfo e Path.
*/
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
        DirectoryInfo di = Directory.CreateDirectory(diretorio);
        string[] arquivos = Directory.GetFiles(diretorio);
        string[] diretorios = Directory.GetDirectories(diretorio);
        bool exists = Directory.Exists(diretorio);
        string currentDirectory = Directory.GetCurrentDirectory();
        Directory.Delete(diretorio);
        Directory.Move(diretorio, novoDiretorio);

        DirectoryInfo directoryInfo = new(diretorio);

        Path.Combine("usr", "share");
        Path.Exists(diretorio);
        Path.GetExtension(diretorio);
        Path.GetFileName(diretorio);
        string v_randomName = Path.GetRandomFileName();
        string v_randomPath = Path.GetTempPath();
        char v_char = Path.PathSeparator;
        v_char = Path.DirectorySeparatorChar;
        v_char = Path.VolumeSeparatorChar;;
    }
}

public class Streams
{
    public void Testar()
    {
        string diretorio = @"./";

        using (FileStream fs = new FileStream(diretorio, FileMode.OpenOrCreate))
        {
            using (StreamReader sr = new(fs))
            {
                string? linha;

                while ((linha = sr.ReadLine()) is not null)
                {
                    System.Console.WriteLine(linha);
                }
            }
        }

        using (FileStream fs = File.Open(diretorio, FileMode.OpenOrCreate))
        {
            using (StreamReader sr = new(fs))
            {
                string? linha;

                while ((linha = sr.ReadLine()) is not null)
                {
                    System.Console.WriteLine(linha);
                }
            }
        }

        using (StreamReader sr = File.OpenText(diretorio))
        {
            string? linha;

            while ((linha = sr.ReadLine()) is not null)
            {
                System.Console.WriteLine(linha);
            }
        }
    }
}