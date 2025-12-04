Tipos de dados: são categorias que definem o tipo de valor que uma variável pode armazenar
        Primitivos: tipos básicos fornecidos pela linguagem (int, float, bool, char, etc.)
        Complexos: tipos definidos pelo usuário ou fornecidos pela biblioteca (classes, structs, arrays, etc.)

    Tipo: é uma definição que especifica o formato e o comportamento dos dados
        Object: é o tipo base de todos os tipos em C#
        Class: é um tipo de referência definido pelo usuário que pode conter dados e métodos
        Struct: é um tipo de valor definido pelo usuário que pode conter dados e métodos
        Enum: é um tipo de valor definido pelo usuário que representa um conjunto de constantes nomeadas
        Interface: é um contrato que define um conjunto de métodos e propriedades que uma classe deve implementar
        Record: é um tipo de referência imutável que é usado para armazenar dados
        Delegate: é um tipo que representa um método com um conjunto específico de parâmetros e tipo de retorno

    Tipos de referência e tipos de valor: são duas categorias principais de tipos em C#
        Tipos de valor: armazenados na stack, incluem tipos primitivos (int, float, bool, char), structs e enums
        Tipos de referência: armazenados na heap, incluem classes, arrays, strings e delegates

    Memória stack e heap: são áreas de memória usadas para armazenar dados em tempo de execução
        Stack: memória de acesso rápido usada para armazenar tipos de valor e referências a tipos de referência
        Heap: memória usada para armazenar objetos e tipos de referência
        
    Constantes e variáveis: são usadas para armazenar dados em um programa
        Constantes: valores fixos que não podem ser alterados após a declaração (usam a palavra-chave const)
        Variáveis: espaços de memória que podem armazenar valores que podem ser alterados durante a execução do programa

    Tipo de dado monetário recomendado
        decimal: recomendado para cálculos financeiros devido à sua alta precisão e capacidade de representar valores monetários com exatidão

    Conversão de tipos: processo de transformar um valor de um tipo para outro
        Implícita: realizada pelo compilador quando não há risco de perda de dados
        Explícita: realizada pelo programador quando há risco de perda de dados através de casting
        Casting: forçado para conversão de tipos compatíveis. Ex.: int para double, double para int, char para int
        Conversão através da classe Convert: estreitamento e alargamento de tipos podendo gerar exceções quando a conversão não é possível e quando há perda de dados

    Precisão de decimais
        float: precisão simples (7 dígitos significativos)
        double: precisão dupla (15-16 dígitos significativos)
        decimal: alta precisão (28-29 dígitos significativos), ideal para cálculos financeiros

    Boxing e unboxing: servem para converter entre tipos de valor e tipos de referência
        Boxing: conversão de um tipo de valor para um tipo de referência (object)
        Unboxing: conversão de um tipo de referência (object) de volta para um tipo

    Operadores aritméticos, relacionais e lógicos
        Aritméticos: +, -, *, /, %, ++, --
        Relacionais: ==, !=, >, <, >=, <=
        Lógicos: &&, ||, !

    Operadores de atribuição e incremento/decremento: funcionam como atalhos para operações comuns
        Atribuição: =, +=, -=, *=, /=, %=
        Incremento/Decremento: ++, --

    Operadores condicionais (ternário): Sintaxe: condição ? valor_se_verdadeiro : valor_se_falso

    Precedência dos operadores
        Ordem de avaliação dos operadores em expressões complexas
        Parênteses podem ser usados para alterar a precedência padrão
    
    Nomenclatura PascalCase e camelCase
        PascalCase para nomes de classes, métodos e propriedades. Ex.: MinhaClasse, MeuMetodo, MinhaPropriedade
        camelCase para nomes de variáveis e parâmetros. Ex.: minhaVariavel, minhaPropriedade

    Nullable types (tipos anuláveis): servem para representar valores que podem ser nulos
        Sintaxe: int? para tipos de valor anuláveis
        Propriedades HasValue e Value
        Operador null-coalescing (??): fornece um valor padrão se a variável for nula
        Operador null-conditional (?.): permite acessar membros de um objeto que pode ser nulo sem lançar uma exceção

    Nullable reference types (tipos de referência anuláveis): serve para melhorar a segurança contra referências nulas
        Habilitação através do arquivo .csproj ou diretiva #nullable enable
        Anotação de tipos de referência como anuláveis com o sufixo '?'. Ex.: string?
        Anotação de tipos de referência como não anuláveis sem o sufixo '?'. Ex.: string
        Análise de nulidade em tempo de compilação para evitar referências nulas

    Null-coalescing operator (operador de coalescência nula): serve para fornecer um valor padrão quando uma expressão é nula
        Sintaxe: expressão1 ?? expressão2

    Formatação de saída de strings
        Concatenação: uso do operador +
        Interpolação: uso do $ antes da string e chaves {}
        Placeholders: uso de índices entre chaves {} na string
        Sequência de escapes: uso de \ para caracteres especiais
        Verbatim strings (@): uso de @ antes da string para ignorar sequências de escape

    Entrada de dados através dos métodos: Console.Read() .ReadLine() .ReadKey()

    Inferência de tipos com var e dynamic: servem para declarar variáveis sem especificar explicitamente o tipo
        var: tipo é inferido em tempo de compilação, não pode mudar de tipo
        dynamic: tipo é resolvido em tempo de execução, pode mudar de tipo
    
    String e StringBuilder: serve para manipulação de texto
        String: imutável, operações que modificam strings criam novas instâncias
        StringBuilder: mutável, mais eficiente para operações que modificam strings frequentemente
    
    Classe Math: métodos e constantes matemáticas

    Reflection: serve para inspecionar metadados e tipos em tempo de execução
        Obtenção de informações sobre assemblies, módulos, tipos, métodos, propriedades e atributos
        Criação dinâmica de instâncias de tipos e invocação de métodos
        Uso de namespaces System.Reflection e System.Type