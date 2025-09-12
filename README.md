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

## COMANDOS BÁSICOS DO DRIVER DOTNET
```
dotnet new <template> -n <name> -o <output-folder>
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
```

