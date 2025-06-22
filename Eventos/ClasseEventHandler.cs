/* 
    um evento é um delegate encapsulado
    são dois delegates pré-definidos para lidar com eventos: EventHandler e EventHandler<TEventArgs>
*/

public class ClasseEventHandler
{
    public ClasseEventHandler()
    {
        // public delegate void EventHandler(object? sender, EventArgs e);
        // public delegate void EventHandler<TEventArgs>(object? sender, TEventArgs e);
    }

    /*
        EventHandler: representa método que vai manipular um evento que não possui dados

        object? sender: referência ao objeto que gerou o evento(fonte do evento)
        e EventArgs: objeto que não contém nenhum dado de um evento
    */
    public void TestarEventHandler()
    {
        Publisher publisher = new Publisher();
        // 4- inscrever os assinantes interessados nos eventos
        // adicionar os manipuladores de eventos ao evento que devem corresponder ao delegate inicial
        publisher.OnEvent += SubscriberEmail.ManipuladorDeEvento;
        publisher.OnEvent += SubscriberSMS.ManipuladorDeEvento;
        publisher.GerarEvento();
    }

    /*
        EventHandler<TEventArgs>: representa método que vai manipular um evento que possui dados

        TEventArgs: o tipo dos dados do evento gerado pelo evento
        object? sender: referência ao objeto que gerou o evento(fonte do evento)
        e TEventArgs: objeto que contém os dados de um evento
    */
    public void TestarEventHandler<T>()
    {

    }
}

// 1- definir delegate com assinatura do método que será chamada quando evento for disparado
// criar o delegate para o evento
delegate void PublisherEventHandler();

class Publisher
{
    // 2- declarar evento que será disparado pela classe Publisher usando delegate do passo 1
    // criar o evento
    // public event PublisherEventHandler? OnEvent;
    public event EventHandler? OnEvent;

    // o Publisher determina quando evento deve ser acionado
    public void GerarEvento()
    {
        Console.WriteLine("Iniciando notificação");

        // 3- disparar evento quando ação desejada ocorrer na classe
        if (OnEvent != null)
        {
            // invocar Subscribers se não for nulo
            // realizar chamada do evento
            OnEvent(this, EventArgs.Empty);
        }
    }
}

public class SubscriberEmail
{
    // Subscribers determinam qual ação será realizada em resposta a um evento
    public static void ManipuladorDeEvento(object? sender, EventArgs e)
    {
        Console.WriteLine("Notificando via EMAIL");
    }
}

public class SubscriberSMS
{
    public static void ManipuladorDeEvento(object? sender, EventArgs e)
    {
        Console.WriteLine("Notificando via SMS");
    }
}