namespace api_utilidade_publica_pdd.Model
{
    public class Imovel
    {
        public Imovel(string codigo, string valorIPTU) {
            this.codigo = codigo;
            this.valorIPTU = valorIPTU;
        }

        private string codigo;
        private string valorIPTU;
        public string Codigo
        {
            get { return codigo;}
            set { codigo = value;}
        }

        public string ValorIPTU{
            get {return valorIPTU;}
            set {valorIPTU = value;}
        }
             
    }
}