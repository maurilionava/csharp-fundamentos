/*
    Mecanismos que permitem que uma classe ou objeto notifique outras classes ou objetos quando alguma *ação* ocorre
    Publisher, o gerador do evento, e Subscriber aquele que recebe a notificação quando um evento ocorre
    Manipuladores dos eventos: métodos das classes Subscribers

    No C# um evento é um delegate encapsulado

    O publisher determina quando o evento é acionado
    O subscriber determina a ação que é executada em resposta ao evento

    Normalmente utilizado para quando há alguma ação do usuário como clique do botão ou seleção de determinado menu

    Definir delegate, declarar evento, disparar evento, inscrever assinantes
*/
public class Eventos
{
    public void TestarEventoNotificacao()
    {
        Pedido p = new();
        p.OnCriarPedido += Email.Enviar;
        p.OnCriarPedido += SMS.Enviar;
        p.CriarPedido();
    }
}

delegate void PedidoEventHandler();

class Pedido
{
    public event PedidoEventHandler? OnCriarPedido;

    public void CriarPedido()
    {
        Console.WriteLine("Pedido criado");

        if (OnCriarPedido != null)
            OnCriarPedido();
    }
}

public static class SMS
{
    public static void Enviar()
    {
        Console.WriteLine("Enviando um SMS");
    }
}

public static class Email
{
    public static void Enviar()
    {
        Console.WriteLine("Enviando um email");
    }
}