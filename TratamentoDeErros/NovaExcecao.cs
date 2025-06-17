public class NovaExcecao : Exception
{
    public NovaExcecao() { }

    public NovaExcecao(string message) : base(message)
    { }
    
    public NovaExcecao(string message, Exception inner) : base(message, inner)
    { }
}