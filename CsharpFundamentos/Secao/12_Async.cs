/*
* Async e Await são palavras-chave em C# que facilitam a programação assíncrona.
* Eles permitem que você escreva código que pode realizar operações demoradas, como chamadas de rede ou acesso a banco de dados, sem bloquear a thread principal.
* A palavra-chave async é usada para marcar um método como assíncrono, enquanto await é usada para esperar a conclusão de uma tarefa assíncrona.
* Isso melhora a responsividade do aplicativo, especialmente em interfaces de usuário, onde o bloqueio da thread principal pode levar a uma experiência ruim para o usuário.
*/
public class CancelamentoTokenAsync
{

}

public class CafeDaManhaAsync
{
    public async Task CafeDaManha()
    {
        System.Console.WriteLine("Preparar cafe");
        var tarefaCafe = PrepararCafe();

        System.Console.WriteLine("Preparar pao");
        var tarefaPao = PrepararPao();

        var cafe = await tarefaCafe;
        var pao = await tarefaPao;

        ServirCafe(cafe, pao);
    }

    public void ServirCafe(Cafe cafe, Pao pao)
    {
        System.Console.WriteLine("Servindo cafe");
        Thread.Sleep(2000);
        System.Console.WriteLine("Cafe servido");
    }

    public async Task<Cafe> PrepararCafe()
    {
        System.Console.WriteLine("Fervendo cafe");
        await Task.Delay(2000);
        System.Console.WriteLine("Coando cafe");
        await Task.Delay(2500);
        System.Console.WriteLine("Adocando cafe");
        return new Cafe();
    }

    public async Task<Pao> PrepararPao()
    {
        System.Console.WriteLine("Partir pao");
        await Task.Delay(2000);
        System.Console.WriteLine("Passar manteiga no pao");
        await Task.Delay(2000);
        System.Console.WriteLine("Tostar pao");
        return new Pao();
    }
}

public class Sincrono
{
    public void CafeDaManha()
    {
        System.Console.WriteLine("Preparar cafe");
        var cafe = PrepararCafe();

        System.Console.WriteLine("Preparar pao");
        var pao = PrepararPao();

        ServirCafe(cafe, pao);
    }

    public void ServirCafe(Cafe cafe, Pao pao)
    {
        System.Console.WriteLine("Servindo cafe");
        Thread.Sleep(2000);
        System.Console.WriteLine("Cafe servido");
    }

    public Cafe PrepararCafe()
    {
        System.Console.WriteLine("Fervendo cafe");
        Thread.Sleep(2000);
        System.Console.WriteLine("Coando cafe");
        Thread.Sleep(2500);
        System.Console.WriteLine("Adocando cafe");
        return new Cafe();
    }

    public Pao PrepararPao()
    {
        System.Console.WriteLine("Partir pao");
        Thread.Sleep(2000);
        System.Console.WriteLine("Passar manteiga no pao");
        Thread.Sleep(2000);
        System.Console.WriteLine("Tostar pao");
        return new Pao();
    }
}

public class Cafe { }
public class Pao { }