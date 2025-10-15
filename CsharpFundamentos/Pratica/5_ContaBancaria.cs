/*
    Classe "Conta Bancária":

    Crie uma class ContaBancaria com os seguintes membros (atributos): NumeroConta (string) e Saldo (decimal).
    Crie os seguintes membros (comportamentos/métodos): Depositar(valor) e Sacar(valor).
    Implemente a lógica de saque para garantir que o saldo nunca seja negativo (Encapsulamento).
    Crie um objeto (instância) minhaConta no seu Program.cs e teste os métodos.
    Conceitos chave: Class, Objeto (Instância), Membros (atributos e métodos), Encapsulamento (proteção de regras).
*/
public class ContaBancaria
{
    public string NumeroConta { get; set; }
    public decimal Saldo { get; set; }

    public bool Depositar(decimal valor)
    {
        if (valor > 0)
        {
            this.Saldo += valor;
            return true;
        }
        
        return false;
    }

    public bool Sacar(decimal valor)
    {
        if (valor <= this.Saldo)
        {
            this.Saldo -= valor;
            return true;
        }
        
        return false;
    }
}