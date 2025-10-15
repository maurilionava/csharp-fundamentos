/*
    Método de Extensão e Generics:

    Crie uma classe estática para alojar o seu método de extensão.
    Crie um Método de Extensão chamado Shuffle<T> para o tipo List<T>.
    O método deve receber uma lista de qualquer tipo (T) e embaralhar seus elementos aleatoriamente.
    Teste o método em uma List<int> e uma List<string>.
    Conceitos chave: Métodos de Extensão, Generics (<T>), Coleções.
*/
public static class ListExtensions
{
    /// <summary>
    /// Reordenar uma lista de forma aleatória
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="list">Lista</param>
    /// <returns>Lista reordenada de forma aleatória</returns>
    public static List<T> Shuffle<T>(this List<T> list)
    {
        // reordenar lista de forma aleatória

        return list;
    }
}