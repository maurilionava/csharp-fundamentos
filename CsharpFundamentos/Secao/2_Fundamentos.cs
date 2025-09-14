// TODO: reforçar estudo sobre o tipo de dados *dynamic*
public class Fundamentos()
{
    public void Testar()
    {
        // declaração de variáveis auxiliares
        decimal v_decimal = Decimal.MinValue;
        byte v_byte = Byte.MinValue;
        int v_int = Int32.MinValue;
        double v_double = Double.MinValue;
        bool v_bool = false;
        char v_char = Char.MinValue;
        string v_string = String.Empty;
        DateTime v_datetime = DateTime.MinValue;
        Object v_object = new object();
        dynamic v_dynamic = "";

        /*
            TIPOS DE DADOS DE VALOR
            memória stack 
        */
        v_double = 1.20d; // cálculos cientificos
        v_decimal = 1.99m; // cálculos financeiros

        v_byte = 32;
        v_int = 2000;

        v_bool = true;
        v_char = 'A';
        v_char = '\u0041';
        v_datetime = DateTime.Now;
        // enum

        /* 
            TIPOS DE DADOS DE REFERENCIA 
            memória heap | valor padrão null | armazenam uma referência do espaço de memória
        */
        v_string = "NOME COMPOSTO";
        v_object = new Object();
        v_dynamic = "QUALQUER VALOR";

        /* VARIÁVEIS E CONSTANTES */
        v_double = 0;
        const double pi = Math.PI;
        v_double += pi;

        /* OPERADORES DE IGUALDADE */
        v_bool = v_int == v_double;
        v_bool = v_int != v_double;

        /* STRUCT DATETIME */
        DateTime dataHoraAtual = DateTime.Now;
        DateTime aniversario = new DateTime(1993, 04, 27, 13, 59, 01);
        int idadeAtual = DateTime.Now.Year - aniversario.Year;
        int anoAtual = aniversario.AddYears(idadeAtual).Year;
        string dataCurta = aniversario.ToShortDateString();
        string dataLonga = aniversario.ToLongDateString();

        /* 
            NULLABLE TYPES 
            permite que tipos por valor possam receber o valor *null*    
        */
        decimal? v_decimal_nullable = null;
        int? v_int_nullable = null;
        bool? v_bool_nullable = null;
        string? v_string_nullable = null;
        Nullable<char> v_char_nullable = null;

        /* HASVALUE e VALUE */
        if (v_int_nullable.HasValue)
            System.Console.WriteLine(v_int_nullable.Value);
        else
            System.Console.WriteLine("VARIÁVEL SEM VALOR");

        /* OPERADOR NULL COALESCE */
        v_int = v_int_nullable ?? 0;

        /* 
            CONVENÇÕES DE NOMENCLATURA 
            camelCase: variáveis
            PascalCase: classes, métodos
            CONSTANTES: letras maiúsculas
            _sublinhado: campos internos privados e somente leitura
        */

        /* FORMATAR SAÍDA DE DADOS */
        System.Console.WriteLine("VALOR: " + v_int + "."); // concatenação de strings
        System.Console.WriteLine($"VALOR: {v_int}."); // interpolação de strings
        System.Console.WriteLine($"VALORES: {0} {1}.", "VALOR 0", "VALOR 1"); // placeholder
        System.Console.WriteLine("\tDIRETORIO: \\home\\user\\file.txt.\n"); // escapes
        System.Console.WriteLine(@"DIRETORIO: \home\user\file.txt."); // 

        /* 
            CONVERSÃO DE TIPOS 
            conversão implícita, explícita e classe Convert
            byte-1byte short-2bytes int-4bytes long-8bytes float-4bytes double-8bytes decimal-16bytes
            https://learn.microsoft.com/pt-br/sql/t-sql/data-types/data-type-conversion-database-engine?view=sql-server-ver17    
        */
        v_double = v_int; // conversão implícita
        v_byte = Convert.ToByte(v_int); // conversão explícita com classe convert
        v_byte = (byte)v_int; // conversão explícita com cast (conversão forçada)
        // a classe convert lança uma OverflowException quando há perda de dados em conversão de estreitamento
        v_string = v_int.ToString(); // coversão mais utilizada para tipos numéricos

        /* ENTRADA DE DADOS - entrada de fluxo padrão */
        int inRead = Console.Read(); // leitura de um único caracter, retorna o valor ASCII do caractere
        string? inReadLine = Console.ReadLine(); // retorna a linha digitada pelo usuário em formato string
        ConsoleKeyInfo inReadKey = Console.ReadKey(); // utilizado normalmente para segurar a tela

        /* CLASSE ESTÁTICA MATH */
        v_double = Math.PI;
        v_double = Math.Cos(45); // sen cos tan
        v_double = Math.Abs(-5);
        v_double = Math.Min(1, 2); // max
        v_double = Math.Sqrt(25);
        v_double = Math.Ceiling(10.1); // arredonda pra cima
        v_double = Math.Floor(10.9); // arredonda pra baixo
        v_double = Math.Pow(5, 2);
        v_double = Math.Exp(1);

        /* INFERÊNCIA DE TIPOS */
        var v_var = "";

        /* OPERADORES DE ATRIBUIÇÃO */
        v_int = 0;
        v_int += 2;
        v_int *= 2;
        v_int -= 2;
        v_int /= 2;
        v_int %= 2;

        /* CONSTANTES */
        const double v_const = Math.PI;

        /* OPERADORES DE INCREMENTO E DECREMENTO */
        v_int++; // pós-incremento
        ++v_int; // pré-incremento
        v_int--;
        --v_int;

        /* OPERADORES RELACIONAIS */
        v_bool = v_byte == v_int;
        v_bool = v_byte != v_int;
        v_bool = v_byte > v_int;
        v_bool = v_byte < v_int;
        v_bool = v_byte >= v_int;
        v_bool = v_byte <= v_int;

        /* OPERADORES LÓGICOS CONDICIONAIS */
        v_bool = true && false;
        v_bool = true || false;
        v_bool = !true;

        /* 
            PRECEDENCIA E ASSOCIATIVIDADE 
            aritméticos, atribuição, incremento/decremento, relacionais, lógicos    
        */

        /* NULLABLE REFERENCE TYPES */
        v_string_nullable = v_string_nullable?.ToUpper();

        /* OPERADOR TERNÁRIO : operador com três argumentos */
        v_bool = false ? true : false;
        v_string = v_int >= 18 ? "AUTORIZADO" : "NÃO AUTORIZADO";
    }
}