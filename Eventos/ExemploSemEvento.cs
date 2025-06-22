/*
    Forte acoplamento entre classes
*/
public class PedidoSemEvento
{
    public void CriarPedido()
    {
        Console.WriteLine("Pedido criado");
        NotificadorEmail.ManipuladorDeEvento();
        NotificadorSMS.ManipuladorDeEvento();
    }
}