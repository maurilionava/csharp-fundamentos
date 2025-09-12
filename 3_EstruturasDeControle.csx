/* ESTRUTURAS CONDICIONAIS */
// IF-ELSE: Permite executar blocos de código dependendo de uma condição booleana.
int idade = 32;

if (idade < 18)
    System.Console.WriteLine("Menor de idade");
else if (idade >= 18 && idade <= 60)
    System.Console.WriteLine("Adulto");
else
    System.Console.WriteLine("Idoso");

// SWITCH-CASE: Permite escolher entre múltiplos caminhos com base no valor de uma variável.
int dia_semana = 4;

switch (dia_semana)
{
    case (1):
        System.Console.WriteLine("Domingo");
        break;
    case (2):
        System.Console.WriteLine("Segunda");
        break;
    case (3):
        System.Console.WriteLine("Terça");
        break;
    case (4):
        System.Console.WriteLine("Quarta");
        break;
    case (5):
        System.Console.WriteLine("Quinta");
        break;
    case (6):
        System.Console.WriteLine("Sexta");
        break;
    case (7):
        System.Console.WriteLine("Sábado");
        break;
    default:
        break;
}

/* ESTRUTURAS DE REPETIÇÃO */
// FOR: Usado quando se conhece o número de repetições.
for (int aux = 1; aux <= 100; aux % 2 == 0)
{
    System.Console.WriteLine($"{aux}");
}

// FOREACH: Itera sobre coleções (arrays, listas, etc.).
string[] nomes = ["Ana", "Bruno", "Carla", "David", "Eva"];

foreach (var nome in nomes)
{
    System.Console.WriteLine($"{nome}");
}

// WHILE: Repete enquanto a condição for verdadeira.
int entradaUsuario = Console.ReadLine();
while (nomes is not null)
{

}