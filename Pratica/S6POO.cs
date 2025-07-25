#region HERANÇA
    /*
        BENEFÍCIOS: reutilização de código, especialização, extensibilidade, encapsulamento
        DESVANTAGENS: acoplamento forte, herança profunda, herança como reutilização excessiva, rigidez do design
        TIPOS DE HERANÇA: 
            simples (base e derivada), 
            hierárquica: animal > mamífero, anfíbio > cachorro, gato, etc.
            multinível: c herda de b que herda de a 
            múltipla: herança e interface
    */
    public class ClasseBase
    {
        // encapsulamento através de modificadores de acesso e propriedades
        protected bool variavelBase = false;

        public bool PropriedadeBase
        {
            get
            {
                return this.variavelBase;
            }
            set
            {
                this.variavelBase = value;
            }
        }

        public ClasseBase()
        {
            System.Console.WriteLine("construtor da classe base sem parametros");
        }

        public ClasseBase(string valor)
        {
            System.Console.WriteLine($"construtor da classe base com parametros");
        }

        // utilização da palavra-chave virtual e override para sobrescrição de métodos
        public virtual void MetodoBase()
        {
            System.Console.WriteLine("executando Metodo1 da classe base");
        }
    }

    public class ClasseDerivada : ClasseBase
    {
        // invoca construtor da classe base
        public ClasseDerivada() : base()
        {
            System.Console.WriteLine("construtor da classe derivada sem parametros");
        }

        public ClasseDerivada(string valor) : base(valor)
        {
            System.Console.WriteLine("construtor da classe derivada com parametros");
        }

        // palavra-chave sealed para impedir que método seja sobrescrito em classes derivadas
        public sealed override void MetodoBase()
        {
            System.Console.WriteLine("executando Metodo1 sobrescrito da classe base");
        }
    }

    // toda classe em C# herda de Object(pai de todas as outras) que possui os seguintes métodos abaixo por padrão
    public class Geral
    {
        public void HerancaObject()
        {
            this.Equals("");
            this.GetHashCode();
            this.ToString();
            var teste = this.GetType() == new Object().GetType();
        }

        public void UpcastingDowncasting()
        {
            ClasseDerivada cDerivada = new();
            ClasseBase cBase = cDerivada; // upcasting implícito, subir a base

            try
            {
                ClasseDerivada d = (ClasseDerivada)cBase; // downcasting explícito, especialização de tipo
            }
            catch (Exception e)
            {
                System.Console.WriteLine("tratando exceção ao realizar upcasting");
            }
            finally
            {
                System.Console.WriteLine("executando bloco finally");
            }
        }

        /*
            AS é um operador de conversão de tipos
            IS é um operador para verificar compatibilidade entre tipos
        */
        public void OperadoresIsAs()
        {
            ClasseBase classeBase = new();

            if (classeBase is ClasseDerivada)
            {
                var cb = classeBase as ClasseDerivada;
            }
            else
            {
                System.Console.WriteLine("não foi possível realizar a operação de downcasting");
            }

            ClasseDerivada? classeDerivada = classeBase as ClasseDerivada;

            if (classeDerivada != null)
            {
                System.Console.WriteLine("conversão realizada com sucesso");
            }
            else
            {
                System.Console.WriteLine("conversão não realizada");
            }
        }
    }
#endregion

#region ABSTRAÇÃO
    /*
        o modificador ABSTRACT indica que o recurso possui implementação ausente ou incompleta
        serve para indicar uma definição comum de uma classe base que será compartilhada no código
        possui propriedade, métodos comuns e abstratos que devem ser implementados pela classe que a utilize
        não pode ser instanciado
    */
    public abstract class ClasseAbstrata
    {
        public int Propriedade1 { get; set; }
        public string? Propriedade2 { get; set; }

        public void MetodoAbstato()
        {
            System.Console.WriteLine("método concreto de classe abstrata");
        }
 
        public abstract void MetodoAbstrato();
    }

    public class ImplementaAbstracao : ClasseAbstrata
    {
        public override void MetodoAbstrato()
        {
            throw new NotImplementedException();
        }
    }
#endregion

#region INTERFACE
/*
    INTERFACE é um tipo de classe que pode conter assinaturas de métodos, eventos, propriedades e indexadores
    similar a ABSTRACT que não pode ser instanciada e funciona como um contrato
    pode ser utilizada por classes e structs
    a classe que a utilizar deve implementar todos os recursos abstratos
    pode conter implementação, mas não pode conter construtor e campo de instância
*/
public interface IContrato
{
    public int Propriedade { get; set; }

    public void MetodoInterfaceAbstrato();

    public void MetodoInterface()
    {
        System.Console.WriteLine("metodointerface");
    }
}

public class ImplementaInterface : IContrato
{
    public int Propriedade { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void MetodoInterfaceAbstrato()
    {
        throw new NotImplementedException();
    }
}

#endregion

/* 
    COMPOSIÇÃO e AGREGAÇÃO descrevem a relação de TEM-UM, TODO-PARTE
    a PARTE e o TODO são dependentes um do outro em composição
    composição e agregação são formas de associação
    COMPOSIÇÃO > HERANÇA
*/
public class ImplementaComposicao
{
    //exemplo de casa telhado e alicerce, dependente e funcionario, mao e dedos, pedido e itempedido
}
 
// a PARTE e o TODO são independentes em agregação ex: professor e departamento
// a parte não depende do TODO, representa um relacionamento mais fraco
public class ImplementaAgregacao
{

}

/*
    POLIMORFISMO: característica de recursos que respondem de diferentes formas a mesma mensagem
    as mesmas assinaturas de métodos resultam em diferentes resultados
    TIPOS: em tempo de compilação(overloading ou sobrecarga), em tempo de execução(overriding ou sobrescrita)
    IMPLEMENTADOS A PARTIR DE:
        herança: classes derivadas sobrescrevem os membros da base
        interface: classes implementam a interface com diferentes comportamentos, métodos possuem a mesma assinatura, porém geram diferentes resultados
        classe abstrata: classes derivadas incluem os detalhes de implementação nos métodos abstratos

    PERMITE: generalização de algoritmos e estruturas de dados, permite a reutilização de código, reduz o acoplamento entre diferentes funcionalidades
*/
public class ImplementaPolimorfismo
{
    public void Testar()
    {
        ClasseBase classeBase = new ClasseDerivada();
        classeBase.MetodoBase();
    }    
}