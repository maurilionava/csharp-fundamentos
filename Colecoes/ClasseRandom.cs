public class ClasseRandom
{
    public void TestarRandom()
    {
        // A classe *RANDOM* utiliza o relógio do sistema e uma semente para a geração de números
        Random random = new(); // utilizando o relógio do sistema como semente

        Console.WriteLine(random.Next());
        Console.WriteLine(random.Next(10)); // valor máximo não incluso 
        Console.WriteLine(random.Next(0,11)); // valor máximo não incluso
        Console.WriteLine(random.NextDouble());

        //next() next(int) next(int,int) nextdouble() nextbyte(Byte[]) nextint64()
        //semente na inicialização da classe random Random(semente)
    }
}