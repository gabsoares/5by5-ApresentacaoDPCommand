namespace DesignPatternCommand
{
    //INVOKER
    public class Garcom
    {
        private IComando _comando;
        public void DefinirComando(IComando c)
        {
            _comando = c;
        }

        public void ExecutarComando()
        {
            _comando.Executar();
        }
    }
}
