namespace api_utilidade_publica_pdd.Model
{
    public class RetornoErro
    {
        public RetornoErro(string codigo, string mensagem) {
            this.erro = new Erro(codigo, mensagem);
        }

        private Erro erro;
        
        public Erro Erro
        {
            get { return erro;}
            set { erro = value;}
        }

    }
}