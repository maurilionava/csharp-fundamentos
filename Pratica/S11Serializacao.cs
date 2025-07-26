/*
    serialização é o processo de conversão do estado de um objeto em um formato que possa ser armazenado e/ou transportado

    é o processo de conversão de um objeto em um fluxo de bytes(stream) de forma que possa ser armazenado na memória, em arquivo ou em banco de dados
*/

using System.Text.Json;
using System.Xml.Serialization;

public class Serializacao
{
    UsuarioSerializavel usuarioSerializavel = new(1, "navajr", "navajr@gmail.com", new DateTime(1993, 04, 27));

    public void JsonSerializar()
    {
        var path = @"DiretorioAuxiliar";
        var arquivo = "Usuario.json";
        var caminhoArquivo = Path.Combine(path, arquivo);

        using FileStream stream = new(caminhoArquivo, FileMode.OpenOrCreate, FileAccess.ReadWrite);
        JsonSerializer.Serialize(stream, usuarioSerializavel);

        System.Console.WriteLine("objeto serializado com sucesso");
    }

    public void JsonDeserializar()
    {
        var path = @"DiretorioAuxiliar";
        var arquivo = "Usuario.json";
        var caminhoArquivo = Path.Combine(path, arquivo);

        string conteudoArquivo = File.ReadAllText(caminhoArquivo);

        UsuarioSerializavel? usuario = JsonSerializer.Deserialize<UsuarioSerializavel>(conteudoArquivo);

        if (usuario is not null)
        {
            System.Console.WriteLine($"{usuario.Id} {usuario.Login} {usuario.Email} {usuario.DataNascimento}");
        }
    }

    public void XMLSoapSerializar()
    {
        var path = @"DiretorioAuxiliar";
        var arquivo = "Usuario.xml";
        var caminhoArquivo = Path.Combine(path, arquivo);

        XmlSerializer xmlSerializer = new XmlSerializer(typeof(UsuarioSerializavel));

        using StreamWriter stream = new(caminhoArquivo);
        xmlSerializer.Serialize(stream, usuarioSerializavel);

        System.Console.WriteLine("objeto serializado com sucesso");
    }

    public void XMLSoapDeserializar()
    {
        var path = @"DiretorioAuxiliar";
        var arquivo = "Usuario.xml";
        var caminhoArquivo = Path.Combine(path, arquivo);

        XmlSerializer xmlSerializer = new XmlSerializer(typeof(UsuarioSerializavel));

        using StreamReader reader = new(caminhoArquivo);
        UsuarioSerializavel? usuario = (UsuarioSerializavel?)xmlSerializer.Deserialize(reader);

        System.Console.WriteLine($"{usuario.Id} {usuario.Login} {usuario.Email} {usuario.DataNascimento}");
    }
}

public class UsuarioSerializavel
{
    public int Id { get; set; }
    public string? Login { get; set; }
    public string? Email { get; set; }
    public DateTime DataNascimento { get; set; }

    public UsuarioSerializavel() { }

    public UsuarioSerializavel(int id, string login, string email, DateTime dataNascimento)
    {
        this.Id = id;
        this.Login = login;
        this.Email = email;
        this.DataNascimento = dataNascimento;
    }
}