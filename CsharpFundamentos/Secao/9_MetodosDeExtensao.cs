public static class StringExtensions
{
    public static string? InverterString(this string valor)
    {
        var a = valor.ToArray();
        return a.Reverse().ToString();
    }

    public static void Testar(string valor)
    {
        System.Console.WriteLine(valor.InverterString());
    }
}