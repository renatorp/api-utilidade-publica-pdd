
using System.Collections.Generic;

namespace api_utilidade_publica_pdd.Model
{
    public class Logradouro
    {
        public Logradouro(int id, string nome) {
            this.id = id;
            this.nome = nome;
            this.horariosColetaLixo = new List<HorarioColetaLixo>();
            this.solicitacoes = new List<Solicitacao>();
        }

        private int id;
        private string nome;

        private List<HorarioColetaLixo> horariosColetaLixo;

        private List<Solicitacao> solicitacoes;
        public int Id
        {
            get { return id;}
            set { id = value;}
        }

        public string Nome{
            get {return nome;}
            set {nome = value;}
        }

         public List<HorarioColetaLixo> HorariosColetaLixo{
            get {return horariosColetaLixo;}
            set {horariosColetaLixo = value;}
        }    

        public List<Solicitacao> Solicitacoes{
            get {return solicitacoes;}
            set {solicitacoes = value;}
        }
    }
}