# MOTIVAÇÃO DO REPOSITÓRIO

## CONCEITOS BASE

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
  - Exemplo:
    ```csharp
    int number1 = Convert.ToInt32("123"); // Converte string para int, lança exceção se falhar
    int number2 = int.Parse("123"); // Converte string para int, lança exceção se falhar
    object obj = 123;
    int number3 = (int)obj; // Cast explícito, pode lançar InvalidCastException se obj não for int
    ```