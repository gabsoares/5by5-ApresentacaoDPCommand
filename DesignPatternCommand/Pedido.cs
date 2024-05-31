namespace DesignPatternCommand
{
    //RECEIVER
    public class Pedido
    {
        public string Status { get; set; }

        public Pedido()
        {
            Status = "Pendente";
        }

        public void FazerPedido()
        {
            if (Status != "Cancelado")
            {
                Console.WriteLine("Pedido feito");
                Status = "Entregue";
            }
            else
            {
                Console.WriteLine("Pedido esta cancelado, nao da para fazer ele.");
            }
        }

        public void CancelarPedido()
        {
            if (Status == "Pendente")
            {
                Console.WriteLine("Pedido cancelado");
                Status = "Cancelado";
            }
            else
            {
                Console.WriteLine("O pedido ja esta entregue, nao da pra cancelar.");
            }
        }
    }
}


