namespace consolejogos
{
    public class XbONE : videoGame
    {
        //Atributos 
        private int armazenamentoExtra;
        public List<Aplicativo> apps;
        //Construtores com sobrecarga
        public XbONE(){}
        public XbONE(int AE) : base(AE)
        {
            this.armazenamentoExtra = AE;
        }
        //Métodos de Acesso Funcional
        public int AExtra
        {
            get => this.armazenamentoExtra;
            set => this.armazenamentoExtra = value;
        }
        //Métodos da classe sofrendo polimorfismo
        public override int MemoriaDisponivel()
        {
            return (MInterna + AExtra) - mAtual;
        }
        public override void AdicionarSW(Aplicativo ap)
        {
            if()
            {

            }
        }
        public void ExibirSinopse()
        {

        }


    }
}