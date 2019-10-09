namespace consolejogos
{
    public class Aplicativo : softwareInterno
    {
        //Atributos da classe
        private string versao;
        //Construtores Com SobreCarga
        public Aplicativo(){}
        public Aplicativo(string vers) : base(vers)
        {
            this.versao = vers;
        }
        //Métodos de Acesso Funcional
        public string versao
        {
            get => this.versao;
            set => this.versao = value;
        }
        //Métodos da classe sofrendo Polimorfismo
        public override string Sinopse()
        {
            
        }

    }
}