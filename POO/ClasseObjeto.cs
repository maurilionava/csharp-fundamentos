/*
    A classe *OBJECT* é pai de todas as outras
    possui métodos compartilhados entre todos os filhos
    São eles: Equals, GetHashCode, ToString, GetType
*/
public class ClasseObjeto
{
    // compara igualdade de dados dos objetos
    public void TestarEquals() => "".Equals("");
    //gera número hash para objeto
    public void TestarGetHashCode() => "".GetHashCode();
    //retorna representação do objeto como *string*
    public void TestarToString() => "".ToString();
    // retorna informação do tipo
    public void TestarGetType() => "".GetType();
}