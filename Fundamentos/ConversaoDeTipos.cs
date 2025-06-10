public class ConversaoDeTipos
{
    // é realizada pelo compilador quando identificado ser possível
    public void TestarConversaoImplicita()
    {
        /*
            byte 1byte
            short 2bytes
            int 4bytes
            long 8bytes
            float 4bytes
            double 8bytes
            decimal 16bytes
        */
        int varInt = 100; // 4bytes
        double varDouble = varInt; // 8bytes
    }

    public void TestarConversaoExplicita()
    {
        double varDouble = 10.123; // 8bytes
        // neste caso há perda de dados
        int varInt = (int)varDouble; // 4bytes

        int varInt2 = 4;
        // se não houver a especificação explícita, o valor será truncado para se adequar ao tipo *int*
        float resultado = (float) varInt / varInt2; // 10/4=2.5
    }

    /* 
        Todo objeto herda da classe pai *Object* e possui o método *ToString()*
        O método converte o objeto para uma representação em cadeia de caracteres para exibição
    */
    public void TestarToString()
    {
        int varInt = 0;

        Console.WriteLine(varInt.ToString());
    }

    /*
        A conversão se dá através das ações de Ampliação ou estreitamento sem perda de dados
        Quando há perda de dados é gerado uma exceção
        Converte tipos diferentes entre si
    */
    public void TestarClasseConvert()
    {
        int varInt = 25000;

        try
        {
            byte varByte = Convert.ToByte(varInt);
        }
        catch (Exception e)
        {
            // será gerada exceção devido o estreitamento dos dados no processo de conversão
            Console.WriteLine(e.Message);
        }

        int varIntBool = 0;
        bool varBool = Convert.ToBoolean(varIntBool);
    }
}