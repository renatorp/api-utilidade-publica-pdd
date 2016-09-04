
using System.Collections.Generic;

namespace api_utilidade_publica_pdd.Model
{
    public class Pedido
    {
        public enum TipoPedido {
            ADOCAO_GATO, ADOCAO_CACHORRO
        }
        public Pedido(int id, TipoPedido tipo, string cpf, string endereco, string nomeCidadao) {
            this.id = id;
            this.tipo = tipo;
            this.cpf = cpf;
            this.endereco = endereco;
            this.nomeCidadao = nomeCidadao;
        }

        private int id;
        private TipoPedido tipo;
        private string nomeCidadao;
        private string cpf;
        private string endereco;

        public int Id
        {
            get { return id;}
            set { id = value;}
        }
        public TipoPedido Tipo
        {
            get { return tipo;}
            set { tipo = value;}
        }
        public string NomeCidadao{
            get {return nomeCidadao;}
            set {nomeCidadao = value;}
        }
        public string Cpf{
            get {return cpf;}
            set {cpf = value;}
        }
        public string Endereco{
            get {return endereco;}
            set {endereco = value;}
        }
    }
}