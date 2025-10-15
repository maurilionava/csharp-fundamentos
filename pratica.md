## 🎯 Lista de Exercícios de Fundamentos de C# (Completa)

Organize cada exercício ou grupo de exercícios em um novo projeto (*Console Application*), usando os comandos `dotnet new console` que você anotou.

### Nível 1: Fundamentos da Linguagem e Tipos de Dados

| # | Exercício | Foco |
| :---: | :--- | :--- |
| 1 | **Calculadora Básica Simples** | Sintaxe Básica, I/O, Operadores. |
| 2 | **Conversor de Tipos e Tratamento de Erro (Try-Parse)** | `int.TryParse()`, Conversão de Tipos, Estrutura de Decisão. |
| 3 | **Analisador de Texto Básico** | Tipo `string`, Métodos de `string`. |
| 4 | **Estrutura de Repetição** | *Loops* (`for`, `foreach`), Coleções (Introdução). |
| 5 | **Manipulação de Coleções e Generics** | Crie uma `List<T>` de um tipo complexo (ex: `Produto`) e realize operações como adicionar, remover e buscar. Use uma coleção **genérica** (`List<Produto>`) para garantir a segurança de tipos. | **Coleções**, **Generics** (`List<T>`). |

### Nível 2: Programação Orientada a Objetos (POO)

| # | Exercício | Foco |
| :---: | :--- | :--- |
| 6 | **Classe "Conta Bancária"** | **`Class`**, **`Objeto`**, **Membros**, Encapsulamento. |
| 7 | **Herança e Polimorfismo (Veículos)** | **`Herança`**, **`Polimorfismo`** (`virtual`/`override`). |
| 8 | **Struct vs. Class** | **`Struct`**, **`Class`**, *Value Type* vs. *Reference Type*. |
| 9 | **Implementação de Método de Extensão** | Crie um **`Método de Extensão`** chamado `Capitalizar()` para o tipo `string`. Ele deve transformar a primeira letra de cada palavra da string em maiúscula (Ex: "nome do produto" -> "Nome Do Produto"). | **Métodos de Extensão**. |

### Nível 3: Funções Avançadas e Ecossistema

| # | Exercício | Foco |
| :---: | :--- | :--- |
| 10 | **Tratamento de Exceções Estruturado** | Crie uma função que receba dois números e realize a divisão. Use o bloco **`try-catch-finally`** para: 1. Capturar uma exceção de **`DivideByZeroException`**. 2. Capturar uma exceção **`FormatException`** caso o usuário insira um texto em vez de um número. 3. Usar o `finally` para garantir que uma mensagem de limpeza seja exibida. | **Tratamento de Erros** (`try-catch-finally`), **Exceções**. |
| 11 | **Sistema de Notificação com Eventos** | Crie uma classe `Estoque` que tenha um evento chamado **`EstoqueBaixo`**. Crie uma classe `Gerente` que **assine** esse evento. No método `VenderProduto()` da classe `Estoque`, se a quantidade cair abaixo de 5, **dispare o evento**, fazendo com que o método da classe `Gerente` seja chamado para reabastecer. | **Delegates**, **Eventos** (Publisher/Subscriber). |
| 12 | **Uso de Delegates e Expressões Lambda** | Defina um **`delegate`** e use **`Lambda Expressions`** para implementar a operação de um filtro em uma lista de números. | **Delegates**, **Lambda Expressions**. |
| 13 | **Manipulação de Arquivos e Diretórios** | Crie um programa que: 1. Use a classe **`Path`** para criar um caminho de arquivo válido no diretório atual. 2. Use a classe **`File`** para escrever uma lista de nomes no arquivo. 3. Use a classe **`Directory`** para criar uma nova pasta e mover o arquivo para lá. | **Classes de Arquivo e Diretório** (`Path`, `File`, `Directory`). |
| 14 | **Serialização e Desserialização JSON** | Crie uma classe **`Configuracao`** (com propriedades como `Versao` e `Nome`). 1. Crie uma instância dessa classe e use a biblioteca **`System.Text.Json`** para **serializar** o objeto para uma string JSON. 2. Salve essa string em um arquivo. 3. Leia o arquivo e **desserialize** o JSON de volta para um objeto `Configuracao`. | **Serialização** e **Desserialização** (`System.Text.Json`). |
| 15 | **Simulação Assíncrona (Async/Await)** | Crie um método com **`async`/`await`** usando `Task.Delay()`. | **Programação Assíncrona** (`async`, `await`, `Task`). |