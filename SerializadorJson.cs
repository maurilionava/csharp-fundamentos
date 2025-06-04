using System.Text.Json;

public class SerializadorJson
{
    public void SerializarJson(string path, object conteudo)
    {
        string pathCompleto = Path.ChangeExtension(path, "json");
        string conteudoJson = JsonSerializer.Serialize(conteudo);

        File.WriteAllText(pathCompleto, conteudoJson);
    }

    public void DeserializarJson(string path, Type tipo)
    {
        string pathCompleto = Path.ChangeExtension(path, "json");
        string? conteudo = File.ReadAllText(pathCompleto);
        var conteudoDeserializado = JsonSerializer.Deserialize(conteudo, tipo)!;
        Console.WriteLine(conteudoDeserializado?.ToString());
    }
}