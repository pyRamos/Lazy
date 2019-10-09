namespace consolejogos
{
    public abstract class videoGame
    {
        //Atributos da classe
        private string localFabricacao;
        private int numeroSerie;
        protected int memoriaInterna;
        private int memoriaAtual;
        public List<Jogo> jogo;
        public List<Aplicativo> apps;

        //Construtures
        public videoGame(){}
        public videoGame(string LF, int NS, int MA)
        {
            this.localFabricacao = LF;
            this.numeroSerie = NS;            
            this.memoriaAtual = MA;
        }
        //Métodos de Acesso Funcional
        public string LFab
        {
            get => this.localFabricacao;
            set => this.localFabricacao = value;
        }
        public int NSerie
        {
            get => this.numeroSerie;
            set => this.numeroSerie = value;
        }
        protected int MInterna
        {
            get => this.memoriaInterna;
            set => this.memoriaInterna = value;
        }
        public int mAtual
        {
            get => this.memoriaAtual;
            set => this.memoriaAtual = value;
        }
        //Métodos da classe
        public virtual int MemoriaDisponivel()
        {
            return MInterna - mAtual;
        }
        public virtual void AdicionarSW(Aplicativo ap)
        {
            apps = new List<Aplicativo>();
            if(MemoriaDisponivel() == 0 || ap.Tamanho > MemoriaDisponivel())
            {
                System.Console.WriteLine("Memória insuficiente");
            }else 
            {
                apps.Add(ap);
                mAtual +=ap.Tamanho;
                System.Console.WriteLine("Pode Armazenar o Aplicativo");
            }
        }
    }
}