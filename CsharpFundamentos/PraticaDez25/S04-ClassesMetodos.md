**Definições**
**Classe:** Um modelo ou estrutura que define propriedades e comportamentos comuns para um conjunto de objetos. Abstrai a ideia de um objeto do mundo real.
**Struct:** Um tipo de dado definido pelo usuário que agrupa variáveis relacionadas em uma única unidade. Structs são semelhantes a classes, mas são tipos de valor e geralmente usados para representar dados simples.
**Struct vs Classe:** Structs são tipos de valor, armazenados na pilha, e geralmente usados para dados simples e pequenos. Classes são tipos de referência, armazenados no heap, e são mais adequadas para objetos complexos com comportamento e estado mais elaborados.
**Enum:** Um tipo de dado que define um conjunto de constantes nomeadas, facilitando a leitura e manutenção do código ao representar valores discretos.
**Propriedades:** Atributos ou características que descrevem o estado de um objeto.
**Estado:** A coleção de valores das propriedades de um objeto em um determinado momento.
**Comportamentos:** Ações ou funções que um objeto pode realizar, geralmente implementadas como métodos dentro da classe.
**Objeto:** Uma instância de uma classe que contém dados específicos e pode executar os métodos definidos na classe.
**Método:** Uma função ou procedimento definido dentro de uma classe que descreve um comportamento ou ação que os objetos da classe podem realizar.
**Método vs Função:** Em C#, um método é uma função que está associada a uma classe ou objeto. A principal diferença é que métodos são definidos dentro de classes, enquanto funções podem ser independentes em outras linguagens de programação.
**Construtor:** Um método especial usado para inicializar novos objetos de uma classe, geralmente definindo valores iniciais para as propriedades do objeto.
**Parâmetros vs Argumentos:** Parâmetros são variáveis definidas na assinatura de um método que recebem valores quando o método é chamado. Argumentos são os valores reais passados para esses parâmetros durante a chamada do método.
**Propriedades:** Membros de uma classe que encapsulam dados e fornecem mecanismos para ler e escrever esses dados, geralmente através de getters e setters.
**Encapsulamento:** O princípio de ocultar os detalhes internos de uma classe e expor apenas uma interface pública para interagir com o objeto, promovendo a modularidade e a proteção dos dados.
**Tipo anônimo:** Um tipo de dado que não tem um nome explícito e é definido diretamente no local onde é usado, geralmente para simplificar o código quando uma estrutura completa de classe não é necessária.
**Membros estáticos vs de instância:** Membros estáticos pertencem à classe em si e são compartilhados entre todas as instâncias, enquanto membros de instância pertencem a objetos individuais e podem ter valores diferentes para cada objeto.
**this:** Uma palavra-chave que refere-se à instância atual de uma classe, permitindo acessar membros e métodos da classe dentro de seus próprios métodos.
**Inferência de tipos:** O processo pelo qual o compilador determina automaticamente o tipo de uma variável com base no valor atribuído a ela, eliminando a necessidade de declarar explicitamente o tipo.
**Passagem de parâmetros por valor vs por referência:** Em C#, parâmetros podem ser passados por valor (cópia do valor é passada) ou por referência (uma referência ao valor original é passada), afetando como as alterações dentro do método impactam os dados originais.
**Métodos, campos e construtor estáticos:** Elementos que pertencem à classe em si, em vez de a instâncias individuais, permitindo acesso e uso sem a necessidade de criar objetos.
**Modificadores de acesso:** Palavras-chave que definem a visibilidade e o acesso aos membros de uma classe, como public, private, protected e internal.
**Tratamento de erros:** Mecanismos para lidar com exceções e erros durante a execução do programa, garantindo que o software possa responder adequadamente a situações inesperadas.
**Tipos anônimos:** Tipos de dados que não possuem um nome explícito e são definidos diretamente no local onde são usados, geralmente para simplificar o código quando uma estrutura completa de classe não é necessária. É a definição de um objeto com propriedades em uma variável, sem uma classe formal.
**Partial class:** Uma classe que pode ser dividida em múltiplos arquivos, permitindo que diferentes partes da classe sejam implementadas separadamente, facilitando a organização do código.