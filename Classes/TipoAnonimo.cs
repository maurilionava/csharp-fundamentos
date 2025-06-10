public class TipoAnonimo
{
    /*
        O tipo anonimo é um tipo (classe) sem nome, com propriedades públicas somente leitura
        O tipo de cada propriedade é inferido pelo compilador
        O nome do tipo é gerado pelo compilador
        Derivados de *Object*
        Suportam somente propriedades
        Normalmente utilizados nas consultas LINQ
    */
    public TipoAnonimo() { }

    public void TestarTipoAnonimo()
    {
        var tipoAnonimo = new
        {
            ValorString = "valor 1",
            ValorNumerico = 2,
            ValorAnonino = new{ Id = 1}
        };

        Console.WriteLine(tipoAnonimo.ValorString, tipoAnonimo.ValorNumerico);
        Console.WriteLine(tipoAnonimo.GetType().ToString());
    }
}