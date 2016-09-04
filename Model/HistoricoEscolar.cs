namespace api_utilidade_publica_pdd.Model
{
    public class HistoricoEscolar
    {
        public HistoricoEscolar(string classe, string turma, string materia, int notaOferta, int notaAluno) {
            this.classe = classe;
            this.turma = turma;
            this.materia = materia;
            this. notaOferta = notaOferta;
            this.notaAluno = notaAluno;
        }

        private string classe;
        private string turma;
        private string materia;
        private int notaOferta;
        private int notaAluno;
        public string Classe
        {
            get { return classe;}
            set { classe = value;}
        }

        public string Turma
        {
            get { return turma;}
            set { turma = value;}
        }

        public string Materia
        {
            get { return materia;}
            set { materia = value;}
        }

        public int NotaOferta
        {
            get { return notaOferta;}
            set { notaOferta = value;}
        }
             
        public int NotaAluno
        {
            get { return notaAluno;}
            set { notaAluno = value;}
        }
    }
}