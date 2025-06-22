/*
    Métodos de extensão
    permitem estender a funcionalidade de um tipo existente sem criar novo tipo derivado, 
        recompilar ou modificar o tipo original
    Tipo especial de método estático
    Usados muitas vezes para classes da biblioteca padrão ou de terceiros

    Implementação: classe estática pública, método estático público, parâmetro this
*/
namespace t;
public static class StringExtensions
{
    public static string? InterveString(this string str)
    {
        char[] textoChar = str.ToCharArray();
        Array.Reverse(textoChar);
        return new string(textoChar);
    }
}