/* 
    um evento é um delegate encapsulado
    são dois delegates pré-definidos para lidar com eventos: EventHandler e EventHandler<TEventArgs>
*/
using System.Security.Cryptography.X509Certificates;

public class EventHandler
{
    public EventHandler()
    {
        // public delegate void EventHandler(object? sender, EventArgs e);
        // public delegate void EventHandler<TEventArgs>(object? sender, TEventArgs e);
    }
    
    /*
        EventHandler: representa método que vai manipular um evento que não possui dados
    */
    public void TestarEventHandler()
    {

    }
    
    /*
        EventHandler<TEventArgs>: representa método que vai manipular um evento que possui dados
    */
    public void TestarEventHandler<T>()
    {

    }
}