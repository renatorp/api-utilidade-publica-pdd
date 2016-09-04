
using System.Collections.Generic;

namespace api_utilidade_publica_pdd.Model
{
    public class Aluno
    {
        public Aluno(int codAluno, string nome) {
            this.codAluno = codAluno;
            this.nome = nome;
            this.listaHistoricoEscolar = new List<HistoricoEscolar>();
        }

        private int codAluno;
        private string nome;
        private List<HistoricoEscolar> listaHistoricoEscolar;

        public int CodAluno
        {
            get { return codAluno;}
            set { codAluno = value;}
        }

        public string Nome{
            get {return nome;}
            set {nome = value;}
        }

         public List<HistoricoEscolar> ListaHistoricoEscolar{
            get {return listaHistoricoEscolar;}
            set {listaHistoricoEscolar = value;}
        }    

    }
}