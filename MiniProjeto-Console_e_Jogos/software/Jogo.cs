namespace consolejogos
{
    public class Jogo : softwareInterno
    {
        //Atributos da classe
        private int qtdPlayers;
        private string genero;
        //Construtores Com SobreCarga
        public Jogo(){}
        public Jogo(int qtdP, string gen) : base(qtdP,Gen)
        {
            this.qtdPlayers = qtdP;
            this.genero = gen;
        }
        //Métodos de Acesso Funcional
        public int qtdP
        {
            get => this.qtdPlayers;
            set => this.qtdPlayers = value;
        }
        public string Gen
        {
            get => this.genero;
            set => this.genero = value;
        }
        //Métodos da Classe sofrendo Polimorfismo
        public override string Sinopse()
        {
            
        }
    }
}