public class Fundamentos
{
    #region TIPOS DE DADOS
    // VALUE TYPES: armazenados na stack 
    // cópias independentes entre si
    bool vBool = true;
    char vChar = '0';

    // numéricos inteiros e decimais
    byte vByte = 255; // 8 bits
    short vShort = 32767; // 16 bits
    int vInt = 2147483647; // 32 bits 2.147.483.647 trilhões
    long vLong = 9223372036854775807; // 64 bits
    float vFloat = 0.0f; // 32 bits 7 dígitos 
    double vDouble = 0.0d; // 64 bits 15-16 dígitos
    decimal vDecimal = 0.0m; // 128 bits 28-29 dígitos para cálculos financeiros

    int vMinValue = int.MinValue;
    int vMaxValue = int.MaxValue;

    // estruturas de dados
    object[] vArray = new object[] { 0, 1, 2 };

    // ESTRUTURAS: struct, enum

    // REFERENCE TYPES: armazenados na heap
    // cópias são referências para o mesmo endereço de memória, apontam para o mesmo objeto
    string vString = "Hello World";
    object vObject = "objeto definido pelo usuário";

    //ESTRUTURAS: class, interface, delegates
    #endregion

    #region ENTRADA, SAÍDA DE DADOS E CONVERSÃO
    public void EntradaSaidaDeDados()
    {
        // CAST(entre numéricos, de mesma família) e CONVERT(entre familias diferentes)
        byte vByte = 0;
        long vLong = 1;

        int vInt = vByte;
        vInt = (int)vLong;

        byte vASCII = Convert.ToByte(Console.Read()); // retorna valor ASCII

        System.Console.WriteLine("Digite um texto qualquer:");
        string? vString = Console.ReadLine();

        System.Console.WriteLine("Digite um valor inteiro:");
        vInt = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Digite um valor monetário:");
        decimal vDecimal = Convert.ToDecimal(Console.ReadLine());

        System.Console.WriteLine("Texto digitado: " + vString);
        System.Console.WriteLine("Valor informado e convertido para numérico inteiro: {0}", vInt);
        System.Console.WriteLine($"Valor informado e convertido para monetário com saída personalizada: {vDecimal}");
        System.Console.WriteLine(@"C:/Directory/File"); // verbatim
    }
    #endregion

    #region NULLABLE TYPES
    public void NullableTypes()
    {
        Nullable<int> vInt = null;
        int? vInt2 = null;

        // um NULLABLE TYPE é diferente de um tipo de valor
        // int vErro = vInt;
        int vInt3 = vInt ?? 0; // operador de coalescencia nula

        // propriedades
        if (vInt2.HasValue)
        {
            vInt3 = vInt2.Value;
        }
    }
    #endregion

}

//INTERFACE: reference type
public interface ContratoOperacoesMatematicasBasicas
{
    // INTERFACES não possuem atributos, somente comportamentos
    int Soma(int x, int y);
    int Subtracao(int x, int y);
    int Multiplicacao(int x, int y);
    int Divisao(int x, int y);
}