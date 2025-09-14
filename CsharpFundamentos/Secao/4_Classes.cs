public class Classes
{
    /* 
        CONSTRUTOR
        tipo especial de méotodo utilizado para inicializar um objeto
    */
    public Classes() => System.Console.WriteLine("CONSTRUTOR SEM PARÂMETROS");
    public Classes(int valor01) : this() => System.Console.WriteLine("CONSTRUTOR COM PARÂMETRO");

    public void Testar()
    {
        /* CLASSES E OBJETOS */
        Object objeto; // instanciação do objeto na memória stack
        objeto = new(); // inicialização do objeto na memória heap

        /* MÉTODO DE INSTÂNCIA COM PARÂMETRO NOMEADO E OPCIONAL */
        Metodo(valor02: 2, valor01: "VALOR");
    }

    /* MÉTODO COM EXPRESSÃO LAMBDA E PARÂMETRO NOMEADO */
    private bool Metodo(string valor01, int valor02, bool valor03 = true) => valor03;

    /* MÉTODO COM SOBRECARGA */
    private bool Metodo(string valor01, bool valor03 = true) => valor03;
}