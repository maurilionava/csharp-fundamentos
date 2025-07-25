/*
    FILE: classe estática para operações básicas com diretórios e arquivos
    STREAM: fluxo de bytes/sequência de dados
    DIRECTORY e DIRECTROYINFO
*/
public class Arquivo
{
    public void CriarArquivo(string diretorio, string nome)
    {
        var pathArquivo = Path.Combine(diretorio, nome);

        if (File.Exists(pathArquivo))
        {
            System.Console.WriteLine($"arquivo {nome} já existe");
        }
        else
        {
            File.Create(pathArquivo);
            System.Console.WriteLine($"arquivo {nome} criado com sucesso");
        }
    }

    public void LogarDatahora(string diretorio, string nome)
    {
        var pathArquivo = Path.Combine(diretorio, nome);

        CriarArquivo(diretorio, nome);

        File.AppendAllText(pathArquivo, $"Modificado às {DateTime.Now.ToString()}\n");
    }

    public void LerArquivo(string diretorio, string nome)
    {
        var pathArquivo = Path.Combine(diretorio, nome);

        string[] linhas = File.ReadAllLines(pathArquivo);

        foreach (var linha in linhas)
        {
            System.Console.WriteLine(linha);
        }
    }

    public void CriarBackup(string diretorio, string nome)
    {
        var pathOrigem = Path.Combine(diretorio, nome);
        var pathDestino = Path.Combine(diretorio, (nome+Guid.NewGuid().ToString()));

        File.Copy(pathOrigem,pathDestino);
    }

    public void Informacoes(string diretorio, string nome)
    {
        var pathArquivo = Path.Combine(diretorio, nome);
        FileInfo fileInfo = new(pathArquivo);

        System.Console.WriteLine($"nome: {fileInfo.Name}");
        System.Console.WriteLine($"data de criação: {fileInfo.CreationTime}");
        System.Console.WriteLine($"caminho completo: {fileInfo.Directory}");
        System.Console.WriteLine($"extensão: {fileInfo.Extension}");
        System.Console.WriteLine($"data do último acesso: {fileInfo.LastAccessTime}");
        System.Console.WriteLine($"data da última alteração: {fileInfo.LastWriteTime}");
        System.Console.WriteLine($"tamanho: {fileInfo.Length}");
    }
}

public class Diretorio
{
    public void CriarDiretorio(string diretorio)
    {
        if (Directory.Exists(diretorio))
        {
            System.Console.WriteLine($"diretório {diretorio} já existe");
        }
        else
        {
            Directory.CreateDirectory(diretorio);
            System.Console.WriteLine($"diretório {diretorio} criado com sucesso");
        }
    }

    public void DiretorioAtualDaAplicacao()
    {
        System.Console.WriteLine($"diretório atual da aplicação: {Directory.GetCurrentDirectory}");
    }
}

public class ClassePath()
{
    public void Testar(string diretorio, string nome)
    {
        var pathArquivo = Path.Combine(diretorio, nome);

        var resultado = Path.DirectorySeparatorChar;
        resultado = Path.VolumeSeparatorChar;
        Path.HasExtension(pathArquivo);
        Path.GetExtension(pathArquivo);
        Path.GetInvalidFileNameChars();
        Path.GetDirectoryName(pathArquivo);
        Path.GetFileName(pathArquivo);
        Path.GetDirectoryName(pathArquivo);
        Path.GetDirectoryName(pathArquivo);
        Path.GetRandomFileName();
        Path.GetTempPath();
        Path.GetTempFileName();

        var separador = Path.DirectorySeparatorChar;
        string[] diretorios = pathArquivo.Split(separador);
    }
}

/*
    obter um *stream* para um arquivo dando suporte a operações de leitura e gravação síncronas e assíncronas
    STREAM é uma sequência de dados(bytes) que pode ser lida ou escrita em partes menores
    ler, gravar, abrir e fechar arquivos, inclusive pipes
    classe abstrata: STREAM classes concretas: FILE, MEMORY, NETWORK, BUFFERED, PIPE, CRYPTO STREAM
*/
public class ClasseStream
{
    // liberar recursos ao final do processamento
    public void TestarStreamReader(string caminhoArquivo)
    {
        try
        {
            using FileStream fs = new FileStream(caminhoArquivo, FileMode.Open, FileAccess.Read);
            using StreamReader srLeitor = new StreamReader(fs);

            string? linha;
            while ((linha = srLeitor.ReadLine()) is not null)
            {
                System.Console.WriteLine(linha);
            }

            using (StreamReader fLeitor = File.OpenText(caminhoArquivo))
            {
                linha = null;
                
                while ((linha = fLeitor.ReadLine()) is not null)
                {
                    System.Console.WriteLine(linha);
                }
            }

            FileInfo fi = new FileInfo(caminhoArquivo);
            using (FileStream fsFileInfo = fi.Open(FileMode.Open))
            {

            }
        }
        catch (IOException e)
        {
            System.Console.WriteLine($"erro: {e.Message}");
        }
    }

    // fornece métodos para ler strings de um FileStream convertendo bytes em strings
    public void TestarStreamReader(string diretorio, string nome)
    {
        var pathArquivo = Path.Combine(diretorio, nome);

        using (StreamReader fs = new StreamReader(pathArquivo))
        {
            var linha = fs.ReadLine();

            while (linha is not null)
            {
                System.Console.WriteLine(linha);
            }
        }
    }
}