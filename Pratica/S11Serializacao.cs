using System.Text.Json;

public class Serializacao
{
    public void JsonSerializar()
    {
        Objeto o = new();

        var oSerializado = JsonSerializer.Serialize(o);
        var oDeserializado = JsonSerializer.Deserialize(oSerializado);
    }

    public void JsonDeserializar()
    {

    }

    public void XMLSerializar()
    {

    }

    public void XMLDeserializar()
    {

    }
}

public class Objeto
{
    public string aString = "atributo string";
    public int aInt = 101;
    public List<char> aListaChar = new() { 'a', 'b', 'c' };
    public bool MetodoBool()
    {
        return false;
    }
}