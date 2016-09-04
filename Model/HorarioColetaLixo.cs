namespace api_utilidade_publica_pdd.Model
{
    public class HorarioColetaLixo
    {
        public HorarioColetaLixo(string diaSemana, string horario) {
            this.diaSemana = diaSemana;
            this.horario = horario;
        }

        private string horario;
        private string diaSemana;
        public string Horario
        {
            get { return horario;}
            set { horario = value;}
        }

        public string DiaSemana{
            get {return diaSemana;}
            set {diaSemana = value;}
        }
             
    }
}