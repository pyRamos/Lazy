namespace consolejogos
{   
    public class softwareInterno
    {
        //Atributos da classe
        private string nome;
        private string descricao;
        protected int tamanho;
        //Construtores
        public softwareInterno(){}
        public softwareInterno(string n, string d, int t)
        {
            this.nome = n;
            this.descricao = d;
            this.tamanho = t;
        }
        //Métodos de Acesso Funcional
        public string Nome
        {
            get => this.nome;
            set => this.nome = value;
        }
        public string Descricao
        {
            get => this.descricao;
            set => this.descricao = value;
        }
        public int Tamanho
        {
            get => this.tamanho;
            set => this.tamanho = value;
        }
        //Métodos da Classe
        public virtual string Sinopse()
        {

        }
    }
}