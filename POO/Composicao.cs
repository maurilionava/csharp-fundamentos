public class Composicao
{
    /*
        São 2 os tipos de relacionamento em C# 
            é um : herança
            tem um : composição e agregação (ocorre quando a classe base é formado por duas ou mais subclasses)
                A parte não existe sem a classe pai
                Classes departamento e escola (escola tem departamentos - sem escola não há departamentos)

        Com herança todas as propriedades e comportamentos são acessíveis pela classe base
        enquanto que na composição somente é acessível o que faz sentido a classe base

        funcionario e dependente, a mão e os dedos, pedido e itens do pedido

        relacionamento forte 
    */
    public class Casa
    {
        private readonly Telhado _telhado;
        private readonly Alicerce _alicerce;

        // casa é o pai, ou a base
        public Casa()
        {
            // telhado e alicerce são as partes e não fazem sentido sem a casa
            _telhado = new();
            _alicerce = new();
        }
    }

    public class Telhado
    {

    }

    public class Alicerce
    {
        
    }
}