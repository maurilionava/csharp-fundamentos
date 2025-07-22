public class ClasseBase {}

public interface InterfaceContrato
{
    public void MetodoInterface();
}

public abstract class ClasseAbstrata
{
    public void MetodoAbstato()
    {
        System.Console.WriteLine("método abstrato");
    }

    public abstract void MetodoAbstrato();
}

public class ImplementaHeranca : ClasseBase
{
    // bloco de código
}

public class ImplementaInterface : InterfaceContrato
{
    public void MetodoInterface()
    {
        throw new NotImplementedException();
    }
}

public class ImplementaAbstracao : ClasseAbstrata
{
    public override void MetodoAbstrato()
    {
        throw new NotImplementedException();
    }
}

public class ImplementaComposicao
{

}

public class ImplementaAgregacao
{

}

public class ImplementaPolimorfismo
{
    ClasseBase classeBase = new ImplementaHeranca();
}