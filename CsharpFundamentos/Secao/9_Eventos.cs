/*
    * Eventos são uma forma de comunicação entre objetos em programação orientada a objetos.
    * Eles permitem que um objeto (o emissor) notifique outros objetos (os assinantes) quando algo acontece.
    * Isso é especialmente útil para implementar o padrão de design Observer, onde um objeto mantém uma lista de dependentes
    * e os notifica automaticamente sobre qualquer mudança de estado.
    * 
    * Em C#, eventos são baseados em delegados, que são tipos que representam referências a métodos com uma assinatura específica.
    * Um evento é declarado usando a palavra-chave `event` seguida pelo tipo do delegado.
    * 
*/
public class Event
{
    public void Testar()
    {
        Publisher publisher = new();

        publisher.evento += new Email().Notificar;
        publisher.evento += new SMS().Notificar;

        publisher.Action();
    }
}

// public delegate bool DelegateEventHandler();

public class Publisher
{
    // Email email;
    // SMS sms;

    // public Publisher()
    // {
    //     this.email = new Email();
    //     this.sms = new SMS();
    // }

    // manipuladores do evento
    // public event DelegateEventHandler evento;
    // public event EventHandler? evento;
    public event EventHandler<PublisherEventArgs> evento;

    public void Action()
    {
        System.Console.WriteLine("EXECUTANDO ACAO DO PUBLISHER");

        // this.email.Notificar();
        // this.sms.Notificar();

        if (evento is not null)
        {
            // evento.Invoke(this, EventArgs.Empty);
            evento.Invoke(this, new()
            {
                Id = 1,
                Nome = "NOME",
                Destino = "VALOR"
            });
        }
    }
}

public interface Subscriber
{
    public void Notificar();
    public void Notificar(object? sender, EventArgs e);
    public void Notificar(object? sender, PublisherEventArgs e);
}

public class Email : Subscriber
{
    public void Notificar() => System.Console.WriteLine("NOTIFICAR SEM PARÂMETROS");

    public void Notificar(object? sender, EventArgs e)
    {
        System.Console.WriteLine("NOTIFICANDO VIA EMAIL");
    }
        
    public void Notificar(object? sender, PublisherEventArgs e)
    {
        System.Console.WriteLine("NOTIFICANDO VIA SMS");
    }
}

public class SMS : Subscriber
{
    public void Notificar() => System.Console.WriteLine("NOTIFICAR SEM PARÂMETROS");

    public void Notificar(object? sender, EventArgs e)
    {
        System.Console.WriteLine("NOTIFICANDO VIA SMS");
    }
    
    public void Notificar(object? sender, PublisherEventArgs e)
    {
        System.Console.WriteLine("NOTIFICANDO VIA SMS");
    }
}

public class PublisherEventArgs : EventArgs
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Destino { get; set; }
}