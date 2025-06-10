public class Struct
{
    /*
        Similar a classe, porém mais leve e ser do tipo de valor e não referência
        seus dados estão armazenados na memória stack
        pequeno e de curta duração, sem boxing constante
    */

    struct tipoStruct
    {
        private string mensagem;
        public string Mensagem
        {
            get
            {
                return "Hello World";
            }
            set
            {
                mensagem = value;
            }
        }

        public void ExibirMensagem()
        {
            Console.WriteLine(Mensagem);
        }
    }
}