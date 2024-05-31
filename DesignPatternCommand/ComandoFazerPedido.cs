namespace DesignPatternCommand
{
    //CONCRET COMMAND 1
    public class ComandoFazerPedido : IComando
    {
        private Pedido _fazerPedido;

        public ComandoFazerPedido(Pedido fazerPedido)
        {
            _fazerPedido = fazerPedido;
        }

        public void Executar()
        {
            _fazerPedido.FazerPedido();
        }
    }
}
