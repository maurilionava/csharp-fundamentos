using System.Text.Json;
using System.Xml.Serialization;

public class Serializacao
{
    ClasseAux classeAux;

    public Serializacao()
    {
        classeAux = new();    
    }

    public string JsonSerializar(ClasseAux v_classe)
    {
        // JsonSerializer jsonSerializer = new JsonSerializer();
        string v_json = JsonSerializer.Serialize(v_classe);
        System.Console.WriteLine(v_classe);
        return v_json;
    }

    public ClasseDerivada JsonDesserializar(string v_json)
    {
        if (!string.IsNullOrEmpty(v_json))
        {
            ClasseDerivada v_classe = JsonSerializer.Deserialize<ClasseDerivada>(v_json);
            System.Console.WriteLine(v_classe.ToString());
            return v_classe;
        }

        return null;
    }

    public void XmlSerializar()
    {
        string caminhoArquivo = @"./arquivo.xml";
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(ClasseAux));
        using (StreamWriter sw = new(caminhoArquivo))
        {
            xmlSerializer.Serialize(sw, classeAux);
        }
    }

    public void XmlDesserializar()
    {
        string caminhoArquivo = @"./arquivo.xml";
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(ClasseAux));
        using (StreamWriter sw = new(caminhoArquivo))
        {
            xmlSerializer.Serialize(sw, classeAux);
        }
        xmlSerializer.Deserialize()
    }
}

[Serializable]
public class ClasseAux
{
    public ClasseAux() { }
}