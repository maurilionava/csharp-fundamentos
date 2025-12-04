A plataforma .NET: é um ambiente de desenvolvimento de software criado pela Microsoft para construir e executar aplicativos em várias plataformas
    .NET 5/6/7/8: versões unificadas da plataforma .NET que substituem o .NET Framework e .NET Core
    Suporte a múltiplas plataformas: Windows, Linux, macOS, Android, iOS, etc.
    Biblioteca de classes base (BCL): conjunto padrão de bibliotecas de classes básicas e APIs comuns a todos os aplicativos .NET

Compilador
    É responsável por traduzir o código-fonte escrito em C# para a linguagem intermediária (IL) que a CLR pode entender e executar
    Realiza verificações de sintaxe e semântica durante o processo de compilação
    Gera arquivos executáveis (.exe) ou bibliotecas (.dll) que contêm a IL
    
CLR (Common Language Runtime): é o ambiente de execução para aplicativos .NET
    Gerenciamento de memória: coleta automática de lixo (garbage collection) para liberar memória não utilizada
    Segurança: verificação de código e permissões para proteger contra código malicioso
    Suporte a múltiplas linguagens: permite que diferentes linguagens .NET (C#, VB.NET, F#) sejam compiladas para a mesma IL

JIT (Just-In-Time) Compiler: é o compilador que converte a linguagem intermediária (IL) em código nativo específico da plataforma em tempo de execução
    Otimização: realiza otimizações específicas da plataforma durante a compilação JIT para melhorar o desempenho
    Compilação antecipada (AOT): opção para compilar código IL em código nativo antes da execução, útil para dispositivos com recursos limitados

IL (Intermediate Language): é a linguagem intermediária para a qual o código-fonte .NET é compilado antes de ser convertido em código nativo pelo JIT Compiler
    Portabilidade: permite que o mesmo código IL seja executado em diferentes plataformas com a CLR apropriada
    Metadados: contém informações sobre tipos, membros e referências usadas pelo runtime para execução e reflexão

Organização do código
    Solução: container que agrupa múltiplos projetos relacionados
    Projeto: unidade lógica de desenvolvimento dentro de uma solução .NET
    Assembly: unidade compilada de código .NET (arquivo .exe ou .dll)
    Namespace: organiza classes e outros tipos em um escopo lógico para evitar conflitos de nomes
    Classe: definição de um tipo que encapsula dados e comportamentos

Interoperabilidade entre linguagens
    Permite que diferentes linguagens .NET (C#, VB.NET, F#) interajam entre si
    Compartilhamento de assemblies e bibliotecas entre projetos escritos em diferentes linguagens .NET

SDK e Runtime
    SDK (software development kit): conjunto de ferramentas e bibliotecas necessárias para desenvolver aplicativos .NET
    Runtime: ambiente de execução necessário para executar aplicativos .NET

Template de projeto: é um modelo pré-definido que fornece a estrutura básica e os arquivos necessários para iniciar um novo projeto .NET
    Exemplos: console, web, biblioteca de classes, API, etc.

dotnet CLI (Command-Line Interface):
    Ferramenta de linha de comando para criar, compilar, executar e gerenciar projetos .NET
    Comandos comuns: dotnet new, dotnet build, dotnet run, dotnet test, dotnet publish

Versões Debug e Release
    Debug: versão de desenvolvimento com informações de depuração, otimizações desativadas para facilitar a análise do código
    Release: versão final otimizada para desempenho, sem informações de depuração

Pastas /bin e /obj
    /bin: contém os arquivos compilados (executáveis e bibliotecas) do projeto
    /obj: contém arquivos intermediários gerados durante o processo de compilação