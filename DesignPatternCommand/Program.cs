using DesignPatternCommand;

//RECEIVER
Pedido pedido = new Pedido();

//INVOKER
Garcom garcom = new Garcom();

//CONCRET COMMANDS
IComando fazerPedido = new ComandoFazerPedido(pedido);
IComando cancelarPedido = new ComandoCancelarPedido(pedido);

garcom.DefinirComando(fazerPedido);
garcom.ExecutarComando();

garcom.DefinirComando(cancelarPedido);
garcom.ExecutarComando();