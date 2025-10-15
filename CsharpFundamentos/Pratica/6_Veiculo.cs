/*
    Herança e Polimorfismo (Veículos):

    Crie uma classe base Veiculo com um método Acelerar().
    Crie duas classes filhas, Carro e Moto, que herdam de Veiculo.
    Sobrescreva o método Acelerar() em ambas as classes filhas (usando virtual/override) para exibir mensagens diferentes. (Ex: "O carro está acelerando rápido!")
    Crie uma lista de Veiculo e adicione instâncias de Carro e Moto. Percorra a lista chamando Acelerar().
    Conceitos chave: Herança, Polimorfismo (substituição de método).
*/
public class Veiculo
{
    public virtual void Acelerar()
    {
        System.Console.WriteLine("ACELERANDO VEICULO");
    }
}

public class Carro : Veiculo
{
    public override void Acelerar()
    {
        System.Console.WriteLine("ACELERANDO CARRO");
    }
}

public class Moto : Veiculo
{
    public override void Acelerar()
    {
        System.Console.WriteLine("ACELERANDO MOTO");
    }
}
