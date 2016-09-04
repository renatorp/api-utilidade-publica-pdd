namespace api_utilidade_publica_pdd.Model
{
    public class Erro
    {
        public Erro(string codigo, string mensagem) {
            this.codigo = codigo;
            this.mensagem = mensagem;
        }

        private string codigo;
        private string mensagem;
        public string Codigo
        {
            get { return codigo;}
            set { codigo = value;}
        }

        public string Mensagem{
            get {return mensagem;}
            set {mensagem = value;}
        }
             
    }
}