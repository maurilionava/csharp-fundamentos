## 🎯 Lista de Exercícios de Fundamentos de C#

Organize cada exercício ou grupo de exercícios em um novo projeto (*Console Application*), usando os comandos `dotnet new console` que você anotou.

### Nível 1: Fundamentos da Linguagem e Tipos de Dados

Estes exercícios focam em sintaxe básica, I/O e manipulação de tipos.

1.  **Calculadora Básica Simples:**
    * Crie um programa que solicite dois números inteiros ao usuário.
    * Implemente as quatro operações básicas (soma, subtração, multiplicação e divisão) e exiba os resultados.
    * **Conceitos chave:** *Top-Level Statements* (se estiver usando C# moderno), I/O (`System.Console`), Tipos de Valor (`int`), Operadores.
2.  **Conversor de Tipos e Tratamento de Erro (Try-Parse):**
    * Peça ao usuário para digitar uma string que deveria ser um número (`"150"`).
    * Tente converter a string para um inteiro usando o método **`int.TryParse()`**.
    * Se a conversão for bem-sucedida, exiba o número. Se falhar, exiba uma mensagem de erro amigável.
    * **Conceitos chave:** `int.TryParse()` (melhor que `Parse`), Conversão de Tipos, Estrutura de Decisão (`if/else`).
3.  **Analisador de Texto Básico:**
    * Peça ao usuário para digitar uma frase.
    * Exiba o número total de caracteres na frase e a frase em letras maiúsculas.
    * **Conceitos chave:** Tipo `string`, Propriedade `.Length`, Métodos de `string` (`.ToUpper()`).
4.  **Estrutura de Repetição e Coleção Básica:**
    * Crie uma `List<string>` de nomes pré-definidos.
    * Imprima no console todos os números pares de 0 a 50 usando o *loop* **`for`**.
    * Imprima os elementos da lista de nomes usando o *loop* **`foreach`**.
    * **Conceitos chave:** *Loops* (`for`, `foreach`), Coleções (`List<T>`).

### Nível 2: Programação Orientada a Objetos (POO)

Estes exercícios focam na criação e interação entre classes, encapsulamento e membros.

5.  **Classe "Conta Bancária":**
    * Crie uma **`class ContaBancaria`** com os seguintes **membros (atributos)**: `NumeroConta` (string) e `Saldo` (decimal).
    * Crie os seguintes **membros (comportamentos/métodos)**: `Depositar(valor)` e `Sacar(valor)`.
    * Implemente a lógica de saque para garantir que o saldo nunca seja negativo (Encapsulamento).
    * Crie um objeto (**instância**) `minhaConta` no seu `Program.cs` e teste os métodos.
    * **Conceitos chave:** **`Class`**, **`Objeto`** (Instância), **Membros** (atributos e métodos), **Encapsulamento** (proteção de regras).
6.  **Herança e Polimorfismo (Veículos):**
    * Crie uma classe base **`Veiculo`** com um método **`Acelerar()`**.
    * Crie duas classes filhas, **`Carro`** e **`Moto`**, que **herdam** de `Veiculo`.
    * Sobrescreva o método `Acelerar()` em ambas as classes filhas (usando `virtual`/`override`) para exibir mensagens diferentes. (Ex: "O carro está acelerando rápido!")
    * Crie uma lista de `Veiculo` e adicione instâncias de `Carro` e `Moto`. Percorra a lista chamando `Acelerar()`.
    * **Conceitos chave:** **`Herança`**, **`Polimorfismo`** (substituição de método).
7.  **Struct vs. Class (Tipos de Valor vs. Referência):**
    * Crie uma **`struct Ponto`** com coordenadas X e Y.
    * Crie uma **`class Coordenada`** também com X e Y.
    * Em seu programa principal, atribua uma instância de `Ponto` a outra variável (`p2 = p1`) e modifique `p1`. Depois, faça o mesmo com a `Coordenada` (`c2 = c1`).
    * Exiba os valores finais para demonstrar a diferença entre **Tipo de Valor (cópia)** e **Tipo de Referência (apontador)**.
    * **Conceitos chave:** **`Struct`**, **`Class`**, *Value Type* vs. *Reference Type*.
8.  **Método de Extensão e Generics:**
    * Crie uma classe estática para alojar o seu método de extensão.
    * Crie um **`Método de Extensão`** chamado `Shuffle<T>` para o tipo **`List<T>`**.
    * O método deve receber uma lista de qualquer tipo (`T`) e embaralhar seus elementos aleatoriamente.
    * Teste o método em uma `List<int>` e uma `List<string>`.
    * **Conceitos chave:** **Métodos de Extensão**, **Generics** (`<T>`), **Coleções**.

### Nível 3: Funções Avançadas e Ecossistema

Estes exercícios cobrem delegados, expressões lambda e manipulação de arquivos/coleções.

9.  **Consultas com LINQ (Language Integrated Query):**
    * Crie uma lista de objetos **`Produto`** (com propriedades `Nome`, `Preco` e `Categoria`).
    * Use **LINQ** (sintaxe de método ou de consulta) para:
        * Filtrar e exibir apenas os produtos de uma determinada categoria.
        * Encontrar o produto com o preço mais alto.
        * Ordenar a lista por preço.
    * **Conceitos chave:** **`LINQ`**, Coleções (`List<T>`).
10. **Tratamento de Exceções Estruturado:**
    * Crie uma função que receba dois números e realize a divisão.
    * Use o bloco **`try-catch-finally`** para:
        * 1. Capturar uma exceção de **`DivideByZeroException`** se o segundo número for zero.
        * 2. Capturar uma exceção **`FormatException`** caso o usuário insira um texto em vez de um número.
        * 3. Usar o `finally` para garantir que uma mensagem de limpeza seja exibida, independentemente do sucesso.
    * **Conceitos chave:** **Tratamento de Erros** (`try-catch-finally`), **Exceções**.
11. **Sistema de Notificação com Eventos:**
    * Crie uma classe `Estoque` que tenha um **`event`** chamado **`EstoqueBaixo`** (baseado em um delegate).
    * Crie uma classe `Gerente` que **assine** esse evento.
    * No método `VenderProduto()` da classe `Estoque`, se a quantidade de um item cair abaixo de 5, **dispare o evento**.
    * A ação do `Gerente` (o assinante) deve ser chamar um método para "reabastecer".
    * **Conceitos chave:** **Delegates**, **Eventos** (Publisher/Subscriber).
12. **Delegates e Expressões Lambda (Filtro):**
    * Defina um **`delegate`** chamado `FiltroNumerico` que receba um inteiro e retorne um booleano.
    * Crie um método que receba uma `List<int>` e o *delegate* como parâmetros, e retorne apenas os números que satisfazem a condição do *delegate*.
    * No `Main`, chame esse método passando uma **Expressão Lambda** inline para filtrar, por exemplo, apenas números maiores que 10.
    * **Conceitos chave:** **Delegates**, **Lambda Expressions**, Passagem de funções.
13. **Manipulação de Arquivos e Diretórios:**
    * Crie um programa que:
        * 1. Use a classe **`Path`** para criar um caminho de arquivo válido chamado `dados.txt` no diretório atual.
        * 2. Use a classe **`File`** para escrever uma lista de nomes no arquivo.
        * 3. Use a classe **`Directory`** para criar uma nova pasta (`ArquivosProcessados`).
        * 4. Mova o arquivo `dados.txt` para a nova pasta criada.
    * **Conceitos chave:** **Classes de Arquivo e Diretório** (`Path`, `File`, `Directory`).
14. **Serialização e Desserialização JSON:**
    * Crie uma classe simples **`Configuracao`** (com propriedades como `Versao` e `Nome`).
    * 1. Crie uma instância e use a biblioteca **`System.Text.Json`** para **serializar** o objeto para uma string JSON.
    * 2. Salve essa string JSON em um arquivo.
    * 3. Leia o arquivo e use **`System.Text.Json`** para **desserialize** o JSON de volta para um novo objeto `Configuracao`.
    * **Conceitos chave:** **Serialização** e **Desserialização** (`System.Text.Json`).
15. **Programação Assíncrona (Async/Await):**
    * Crie um método chamado **`ProcessarDadosAsync()`** que simula uma operação demorada (ex: acesso à rede) usando `Task.Delay(3000)`.
    * Use a palavra-chave **`async`** e **`await`** e chame o método no seu `Main`.
    * Aproveite para imprimir uma mensagem imediatamente após a chamada do método, para demonstrar que a thread principal não ficou bloqueada.
    * **Conceitos chave:** **Programação Assíncrona** (`async`, `await`, `Task`).