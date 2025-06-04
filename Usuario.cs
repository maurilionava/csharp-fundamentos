using System.Runtime.InteropServices;

public class Usuario
{
    public string Nome { get; set; }

    public Usuario(string nome)
    {
        this.Nome = nome;
    }

    public override string ToString()
    {
        return $"Nome: {Nome}";
    }
}