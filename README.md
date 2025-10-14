# 🚀 Repositório de Estudos: Fundamentos de C# e Programação

Este repositório serve como um **caderno de anotações e laboratório de código** para aprofundar os fundamentos da linguagem de programação C# e do ecossistema .NET.

O objetivo é centralizar os estudos, implementando os conceitos básicos da linguagem e, ao mesmo tempo, fornecer um acesso rápido a definições e comandos essenciais para consulta.

## 📚 Conceitos Base e Glossário Rápido

Este tópico serve como um guia de referência rápida.

| Termo | Definição |
| :--- | :--- |
| **Plataforma .NET** | Um ecossistema de desenvolvimento de software de código aberto, gratuito e multiplataforma, mantido pela Microsoft. Ele oferece ferramentas, bibliotecas (como a BCL) e linguagens (como C#) para construir diversos tipos de aplicações. |
| **.NET Framework** | A versão original do .NET, projetada primariamente para ambientes Windows e tecnologias Microsoft mais antigas. |
| **.NET Core** | Uma reescrita e evolução modular, *open-source* e multiplataforma do .NET Framework. |
| **.**NET | A evolução unificada do .NET Core, que substituiu o .NET Framework e o .NET Core, sendo a plataforma moderna e recomendada para todos os novos desenvolvimentos. |
| **CLR (Common Language Runtime)** | O ambiente de execução (runtime) do .NET. É responsável por gerenciar a execução dos programas, incluindo a compilação JIT, gerenciamento de memória (Garbage Collector), tratamento de exceções e interoperabilidade entre linguagens. |
| **BCL (Base Class Library)** | Um conjunto de bibliotecas e classes reutilizáveis que fornecem funcionalidades básicas (E/S de arquivos, manipulação de *strings*, coleções, etc.) disponíveis para todas as linguagens .NET. |
| **A Linguagem C#** | Uma linguagem de programação moderna, orientada a objetos e fortemente tipada, desenvolvida pela Microsoft como parte da plataforma .NET. É conhecida pela sua simplicidade, segurança de tipos e robustez. |
| **Motivação da Criação do C#** | A linguagem foi criada para ser uma alternativa moderna, orientada a objetos e baseada na plataforma .NET, oferecendo maior segurança de tipos e produtividade em comparação com C++ e para competir com Java. |
| **Características do C#** | Orientada a objetos, fortemente tipada, gerenciada (com Garbage Collector), moderna, baseada em classes, suporta programação assíncrona nativamente e é parte integral do ecossistema .NET. |
| **Vantagens/Desvantagens do C#** | **Vantagens**: Integração profunda com o ecossistema .NET, grande comunidade, segurança de tipos, alto desempenho do CLR. **Desvantagens**: Desempenho ligeiramente inferior a linguagens puramente nativas (C/C++) em cenários específicos, dependência histórica da Microsoft (embora reduzida com o .NET moderno). |
| **Casos de Uso Reais do C#** | Desenvolvimento web (*APIs* e *front-ends* com ASP.NET Core), desenvolvimento de jogos (Unity), aplicações desktop (WPF, WinForms), microsserviços, aplicações móveis (Xamarin/MAUI) e soluções *cloud* (Azure). |
| **Linguagem de Alto/Baixo Nível** | **Alto Nível**: Linguagens mais próximas da linguagem humana e fáceis de entender (ex: C#, Python). **Baixo Nível**: Linguagens mais próximas da arquitetura do computador, exigindo mais controle de memória (ex: Assembly). |
| **Compilador** | Um programa que traduz o código-fonte escrito pelo desenvolvedor (em uma linguagem de alto nível como C#) para uma forma intermediária ou diretamente para código de máquina. |
| **Bytecode / Intermediate Language (IL)** | O código intermediário gerado pelo compilador de C# (chamado de C# Compiler ou Roslyn). O CLR traduz este IL para código de máquina nativo no momento da execução usando o JIT Compiler. |
| **JIT Compiler (Just-In-Time Compiler)** | Parte do CLR que traduz o Intermediate Language (IL) para código de máquina nativo no momento em que o código é executado pela primeira vez, otimizando-o para o hardware específico. |
| **Garbage Collector (GC)** | Um gerenciador de memória automática do CLR. Ele rastreia e libera a memória alocada por objetos que não estão mais em uso (não são mais referenciados pelo programa), evitando vazamentos de memória. |
| **Extensão `.exe` e `.dll`** | **`.exe` (Executável)**: Contém o ponto de entrada principal de um programa. **`.dll` (Dynamic Link Library)**: Contém código e dados que podem ser usados por múltiplos programas, geralmente bibliotecas ou componentes reutilizáveis. Ambos são Assemblies do .NET. |
| **Interoperabilidade** | A capacidade de diferentes linguagens de programação (dentro do ecossistema .NET) se comunicarem e usarem código umas das outras. O CLR e o IL facilitam isso. |
| **Assembly** | Uma unidade de código implantável e versionável no .NET, que pode ser um arquivo `.exe` ou `.dll`. Contém o código IL, metadados e manifestos. |
| **Namespace, Solution e Project** | **`Namespace`**: Um agrupamento lógico de classes, ajudando a evitar conflitos de nomes. **`Solution`** (`.sln`): Um contêiner que organiza um ou mais projetos relacionados. **`Project`** (`.csproj`): Contém o código-fonte, recursos e todas as configurações necessárias para construir um assembly (DLL ou EXE). |
| **IDE (Integrated Development Environment)** | Um software que fornece um conjunto abrangente de ferramentas para desenvolvedores, como editor de código, *debugger*, compilador e ferramentas de automação (*ex: Visual Studio, VS Code*). |
| **SDK (Software Development Kit)** | Um conjunto de ferramentas que permite criar aplicativos (inclui o runtime, bibliotecas e o CLI). |
| **Runtime** | O ambiente que permite a execução de um aplicativo .NET (inclui o CLR e o BCL). |
| **CLI (Command Line Interface)** | Uma ferramenta de linha de comando (`dotnet`) usada para desenvolver, construir, executar, testar e publicar aplicativos .NET. |
| **Template de Projeto** | Um esqueleto predefinido de arquivos e configurações para iniciar um novo tipo de aplicação (*ex: `console`, `webapi`, `classlib`*). |
| **Estrutura de um Projeto** | Geralmente inclui o arquivo `.csproj`, pastas para código-fonte (`.cs`), referências (dependências) e pastas de saída (`bin`, `obj`). |
| **Arquivo `.csproj`** | O arquivo de configuração XML que define as configurações do projeto, as referências a pacotes (`NuGet`), as referências de *framework* e as opções de compilação. |
| **Arquivo `.sln`** | O arquivo de solução que lista e organiza os projetos dentro de uma solução, definindo suas relações e configurações de compilação. |
| **Arquivo `.cs`** | O arquivo que contém o código-fonte C#. |
| **Dependencies e Analyzers** | **`Dependencies`**: As bibliotecas (pacotes NuGet ou projetos locais) que o projeto precisa para funcionar. **`Analyzers`**: Ferramentas que inspecionam o código em tempo de desenvolvimento para sugerir melhorias e garantir padrões de estilo e segurança. |
| **Bin e Obj** | **`bin`**: Pasta onde os arquivos de saída da compilação (assemblies) são colocados. **`obj`**: Pasta de arquivos intermediários usados pelo compilador. |
| **Debug e Release** | **`Debug`**: Configuração de compilação otimizada para depuração, com símbolos de depuração e sem otimizações de código. **`Release`**: Configuração de compilação otimizada para a produção, com otimizações de código e arquivos menores. |
| **Top-Level Statements** | Um recurso moderno do C# que permite escrever código diretamente no arquivo principal (`Program.cs`) sem a necessidade de uma classe `Program` e um método `Main` explícitos, tornando o código de console mais conciso. |
| **Variáveis de Ambiente** | Configurações do sistema operacional que podem ser acessadas pelos programas. Usadas para configurar aspectos do runtime ou da aplicação (ex: *connection strings*, modo de ambiente de desenvolvimento). |
| **Acesso a Classes BCL** | As classes usadas no código estão disponíveis nos Assemblies do Framework. Exemplo: A classe `System.Console` está contida no assembly **`System.Console.dll`**. |
| **Implicit Usings** | Um recurso moderno do C# onde *namespaces* comuns (como `System`, `System.Collections.Generic`) são automaticamente incluídos no projeto (via `.csproj`), reduzindo a necessidade de adicionar a diretiva `using` em cada arquivo. |
| **Classe** | Um modelo (*blueprint*) que define a estrutura (atributos/campos) e o comportamento (métodos) de objetos. |
| **Membros da Classe** | Componentes de uma classe: **Atributos** (dados/campos/propriedades) e **Comportamentos** (métodos). |
| **Value Type vs. Reference Type** | **Value Type** armazena o valor diretamente (ex: `int`, `struct`). **Reference Type** armazena a referência (endereço) do objeto na memória (ex: `class`, `string`). |
| **Herança** | Mecanismo de POO que permite que uma classe (filha) herde atributos e métodos de outra classe (pai), promovendo a reutilização de código. |
| **Interface** | Um contrato que define um conjunto de membros (métodos, propriedades, eventos) que uma classe deve implementar. Garante que classes diferentes se comportem de uma certa maneira. |
| **Polimorfismo** | O princípio de POO que permite que objetos de classes diferentes sejam tratados pelo mesmo tipo, geralmente através de uma herança ou interface. |
| **Encapsulamento** | O princípio de POO que restringe o acesso direto a alguns dos componentes de um objeto, controlando a maneira como os dados são modificados. |
| **Processamento Assíncrono** | Permite que uma operação seja iniciada e o controle seja retornado ao chamador antes que a operação seja concluída, permitindo que outras operações sejam executadas enquanto se espera (ideal para operações I/O). |
| **Processamento Paralelo** | Envolve a execução simultânea de múltiplas operações ou tarefas, geralmente em múltiplos núcleos de processador, para melhorar o desempenho (ideal para operações *CPU-bound*). |
| **Programação Concorrente** | Lida com múltiplas tarefas que fazem progresso *aparentemente* ao mesmo tempo. Pode ser implementada com programação assíncrona (uma *thread* lidando com múltiplas operações) ou paralela (múltiplas *threads* simultâneas). |
| **Máquina de Estados (State Machine)** | Um modelo matemático que representa o comportamento de um sistema que pode estar em um número finito de estados distintos. Transita entre esses estados com base em eventos, modelando sistemas complexos de forma estruturada. |
| **Delegates** | Tipos que representam referências a métodos com uma lista específica de parâmetros e um tipo de retorno. São usados para implementar eventos, *callbacks* e passar métodos como argumentos. |
| **Eventos** | Um mecanismo de comunicação em C# baseado em delegados. Permite que uma classe (publicadora) notifique outras classes (assinantes) quando algo de interesse acontece. |
| **Lambda Expressions** | Uma sintaxe concisa para criar funções anônimas (métodos sem nome). São frequentemente usadas para passar blocos de código como argumentos para métodos (especialmente com delegates, eventos e LINQ). |
| **NuGet** | O gerenciador de pacotes oficial do .NET. Permite que desenvolvedores compartilhem e consumam código útil (bibliotecas e ferramentas). |
| **LINQ (Language Integrated Query)** | Um conjunto de tecnologias para criar consultas de forma nativa e uniforme em C# contra várias fontes de dados (coleções, bancos de dados, XML). |

## 💡 Q&A: Dúvidas Frequentes

| Pergunta | Resposta | Exemplo |
| :--- | :--- | :--- |
| **Diferença entre .NET Framework, .NET Core e .NET?** | **.NET Framework** é a versão original, focada em Windows. **.NET Core** é a versão modular e multiplataforma. **.**NET (moderno) é a unificação de ambos, sendo a plataforma recomendada para novos desenvolvimentos em qualquer OS. | - |
| **O que é o CLR (Common Language Runtime)?** | O CLR é o ambiente de execução do .NET que gerencia os aplicativos, realizando tarefas como compilação JIT, gerenciamento de memória (GC), segurança e execução de código. | - |
| **Diferença entre classe e objeto?** | Uma **classe** é o **modelo** (*blueprint*) que define a estrutura. Um **objeto** é a **instância concreta** (realização) dessa classe, com valores específicos para seus atributos. | Classe: `Cachorro`. Objeto: `meuCachorro` (com nome "Rex", idade 5). |
| **Diferença entre `Convert`, `Parse` e *Cast*?** | **`Convert`**: Oferece métodos estáticos para conversão segura entre tipos (ex: `Convert.ToInt32()`), lidando bem com `null`. **`Parse`**: Converte uma *string* para um tipo específico (ex: `int.Parse("123")`), mas lança exceção se a *string* for inválida. **`Cast`**: Conversão explícita entre tipos compatíveis (`(int)obj`), pode lançar `InvalidCastException`. | `int n1 = Convert.ToInt32("123");` |
| **Diferença entre Assíncrono e Paralelo?** | **Assíncrono**: Focado em não bloquear a *thread* principal enquanto espera por I/O (input/output). Uma *thread* pode gerenciar múltiplas tarefas em espera. **Paralelo**: Focado em executar múltiplas tarefas *simultaneamente* em diferentes núcleos da CPU para acelerar operações de cálculo intensivo. | **Assíncrono**: Carregar um arquivo da rede. **Paralelo**: Calcular uma matriz complexa. |

## 💻 Comandos Essenciais do Driver `dotnet`

Esta seção lista os comandos mais importantes para gerenciar soluções e projetos usando a Command Line Interface (CLI) do .NET.

| Comando | Descrição |
| :--- | :--- |
| `dotnet new sln -n <solution-name> -o <output-folder>` | Cria um novo arquivo de solução (`.sln`). |
| `dotnet new <template> -n <name> -o <output-folder> -f <framework>` | Cria um novo projeto com base em um *template* (ex: `console`, `webapi`, `classlib`). |
| `dotnet sln <solution-file> add <project-file>` | Adiciona um projeto existente ao arquivo de solução. |
| `dotnet new <template> -n <name> -o <output-folder> -f <framework> --use-program-main` | Cria um projeto usando o formato antigo de programa (com `static void Main()`). |
| `dotnet build <project-folder>` | Compila o projeto (cria os assemblies `.dll` ou `.exe`). |
| `dotnet run <project-folder>` | Compila e executa o projeto em uma única etapa. |
| `dotnet clean <project-folder>` | Remove os arquivos de saída das compilações (`bin` e `obj`). |
| `dotnet add <project-folder> package <package-name> --version <version>` | Adiciona uma referência a um pacote NuGet ao projeto. |
| `dotnet restore <project-folder>` | Baixa e restaura os pacotes NuGet necessários para um projeto. |
| `dotnet test <test-project-folder>` | Executa os testes unitários em um projeto de teste. |
| `dotnet publish <project-folder> -c <configuration> -o <output-folder>` | Prepara o aplicativo para implantação (cria uma pasta com tudo que é necessário para execução). |
| `dotnet sln <solution-file> remove <project-file>` | Remove um projeto da solução. |
| `dotnet sln <solution-file> list` | Lista todos os projetos contidos na solução. |
| `dotnet list <project-file> package` | Lista todos os pacotes NuGet referenciados por um projeto. |
| `dotnet --list-sdks` | Lista todas as versões do .NET SDK instaladas na máquina. |
| `dotnet --list-runtimes` | Lista todas as versões do .NET Runtime instaladas na máquina. |
| `dotnet --version` | Exibe a versão atual do .NET SDK em uso. |