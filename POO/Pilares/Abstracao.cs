/*
    OBJETIVO: fornecer uma definição comum de base compartilhada para diversas classes
*/
public abstract class Abstracao
{
    public abstract void Metodo();
}

public class FilhoAbstrato : Abstracao
{
    public override void Metodo(){}
}