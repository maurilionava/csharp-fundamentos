# MOTIVAÇÃO DO REPOSITÓRIO

## CONCEITOS BASE

- processamento assíncrono e paralelo: 
  - assíncrono: permite que uma operação seja iniciada e o controle seja retornado ao chamador antes que a operação seja concluída, permitindo que outras operações sejam executadas enquanto se espera pela conclusão da operação assíncrona.
  - paralelo: envolve a execução simultânea de múltiplas operações ou tarefas, geralmente em múltiplos núcleos de processador, para melhorar o desempenho e reduzir o tempo total de execução.
- programação concorrente
- máquina de estados:
  - uma máquina de estados é um modelo matemático usado para representar o comportamento de um sistema que pode estar em um número finito de estados distintos. A máquina de estados transita entre esses estados com base em eventos ou condições específicas, permitindo a modelagem de sistemas complexos de forma estruturada e compreensível.
- plataforma .net
- diferença entre .net framework, .net core e .net
- clr(common language runtime)
- bcl
- a linguagem de programação C#
- motivação da criação da linguagem
- características
- vantagens e desvantagens
- casos de usos reais
- linguagem de alto e baixo nivel
- compilador
- bytecode e intermediate language
- jit compiler
- garbage collector
- extensão .exe e .dll (dynamic link library)
- interoperabilidade
- assembly
- namespace, solution e project
- ide (integrated development environment)
- sdk (software development kit) e runtime
- cli (command line interface)
- template de projeto
- estrutura de um projeto
- arquivo .csproj
- arquivo .sln
- arquivo .cs
- dependencies e analyzers
- bin e obj
- debug e release
- driver dotnet
- top level statements
- variáveis de ambiente
- as classes usadas no código estão disponíveis na pasta Dependencies > Assemblies > Framework
    - por exemplo a classe System.Console está disponível na pasta Dependencies > Assemblies > Framework > System.Console.dll
- implicit usings
    - por exemplo o using System; está disponível por padrão no arquivo .csproj
- classe
  - membros
    - atributos e comportamentos (métodos)
- delegates
  - definição e uso:
    - Delegados são tipos que representam referências a métodos com uma lista específica de parâmetros e um tipo de retorno.
    - Eles são semelhantes aos ponteiros de função em C/C++, mas são seguros e orientados a objetos.
    - Delegados são usados para implementar eventos e callbacks.
    - Eles permitem que métodos sejam passados como parâmetros, facilitando a criação de código flexível e reutilizável.
    - Usos:
      - Callbacks: Delegados são frequentemente usados para definir callbacks, permitindo que métodos sejam chamados quando uma operação assíncrona é concluída ou quando um evento ocorre.
      - Eventos: Delegados são a base para o sistema de eventos em C#. Eles permitem que múltiplos métodos sejam associados a um evento e chamados quando o evento é disparado.
      - Passagem de métodos como parâmetros: Delegados permitem que métodos sejam passados como argumentos para outros métodos, facilitando a criação de código reutilizável e flexível.
- eventos
- lambda expressions

## COMANDOS BÁSICOS DO DRIVER DOTNET
```
dotnet new sln -n <solution-name> -o <output-folder>
dotnet new <template> -n <name> -o <output-folder> -f <framework>
dotnet sln <solution-file> add <project-file>

dotnet new <template> -n <name> -o <output-folder> -f <framework> --use-program-main
dotnet new console -n MyApp -o MyAppFolder -f net6.0 --use-program-main
dotnet build <project-folder>
dotnet run <project-folder>
dotnet clean <project-folder>
dotnet add <project-folder> package <package-name> --version <version>
dotnet restore <project-folder>
dotnet test <test-project-folder>
dotnet publish <project-folder> -c <configuration> -o <output-folder>
dotnet sln <solution-file> add <project-file>
dotnet sln <solution-file> remove <project-file>
dotnet sln <solution-file> list
dotnet list <project-file> package
dotnet list <project-file> reference
dotnet tool install -g <tool-name>
dotnet tool update -g <tool-name>
dotnet tool uninstall -g <tool-name>
dotnet --list-sdks
dotnet --list-runtimes
dotnet --version
```

## Q&A
- Qual a diferença entre .NET Framework, .NET Core e .NET? 
  - .NET Framework é a versão original do .NET, projetada principalmente para Windows. .NET Core é uma versão modular e multiplataforma do .NET, permitindo que aplicativos sejam executados em diferentes sistemas operacionais. .NET é a evolução do .NET Core, unificando as plataformas e oferecendo uma experiência de desenvolvimento mais consistente.
- O que é o CLR (Common Language Runtime)?
  - O CLR é o ambiente de execução do .NET que gerencia a execução de aplicativos, incluindo a compilação Just-In-Time (JIT), gerenciamento de memória, segurança e interoperabilidade entre linguagens.
- Qual a diferença entre classe e objeto?
  - Uma classe é um modelo ou blueprint que define a estrutura e o comportamento de um tipo de dado, enquanto um objeto é uma instância concreta dessa classe, contendo valores específicos para os atributos definidos na classe.
- Qual a diferença entre a classe Convert, o método Parse e o Cast?
  - A classe Convert fornece métodos para converter tipos de dados de forma segura, lidando com exceções. O método Parse é usado para converter strings em tipos específicos, mas pode lançar exceções se a conversão falhar. O Cast é uma conversão explícita entre tipos compatíveis, mas pode resultar em erros em tempo de execução se os tipos não forem compatíveis.
  - Diferença entre programação assíncrona e programação paralela?
    - Programação assíncrona permite que tarefas sejam iniciadas e continuem a execução sem bloquear o fluxo principal do programa, ideal para operações de I/O. Programação paralela envolve a execução simultânea de múltiplas tarefas ou threads para melhorar o desempenho em operações computacionalmente intensivas.
  - Exemplo:
    ```csharp
    int number1 = Convert.ToInt32("123"); // Converte string para int, lança exceção se falhar
    int number2 = int.Parse("123"); // Converte string para int, lança exceção se falhar
    object obj = 123;
    int number3 = (int)obj; // Cast explícito, pode lançar InvalidCastException se obj não for int
    ```