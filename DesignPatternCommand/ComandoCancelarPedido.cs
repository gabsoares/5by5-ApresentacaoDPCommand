namespace DesignPatternCommand
{
    //CONCRET COMMAND 2
    public class ComandoCancelarPedido : IComando
    {
        private Pedido _cancelarPedido;

        public ComandoCancelarPedido(Pedido cancelarPedido)
        {
            _cancelarPedido = cancelarPedido;
        }

        public void Executar()
        {
            _cancelarPedido.CancelarPedido();
        }
    }
}
