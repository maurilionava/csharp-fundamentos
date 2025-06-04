public class TipoDeDados
{
    /*
        Tipos de dados - fortemente tipadas
        Tipos de referência do local na memória de armazenamento HEAP
            object(tipo base de todos os outros tipos) string(imutáveis) dynamic(resolvidos em tempo de execução) class
        Tipos de valor STACK
            não numericos(bool 8bits char 16bits enum datetime) 
            Numericos inteiros(sbyte 8bits short 16bits int32bits long64bits nint 32 ou 64bits) 
            e de ponto flutuante(float 4bytes double 8bytes decimal 16bytes)
        Variável e constante

        STRING VS STRINGBUILDER
    */

    // sufixo 'd' 'f' ou 'm'
    double valorDouble = 12.4d; //ou 12.4D
    float valorFloat = 12.4f; //ou 12.4F
    decimal valorDecimal = 12.4m; //ou 12.4M

    // utilização das aspas simples para representação dos valores CHAR ou unicode
    char valorChar = 'A';
    char valorCharUnicode = '\u0041';

    object valorAux = 8.55m; // aceita qualquer valor por ser o 'pai' de todos os outros
}