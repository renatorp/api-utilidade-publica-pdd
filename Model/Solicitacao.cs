
using System.Collections.Generic;

namespace api_utilidade_publica_pdd.Model
{
    public class Solicitacao
    {
        public enum TipoSolicitacao {
            PodaArvore,ConstrucaoMeioFio,RecolhimentoCarrosAbandonados,
            DesobstrucaoViasPublicas,DesobstrucaoCorregos,ColetaAnimalMorto,LimpezaBocaLobo
        };

        public Solicitacao(TipoSolicitacao tipo) {
            this.tipo = tipo;
            this.id = System.Guid.NewGuid().ToString();
        }

        private string id;
        private TipoSolicitacao tipo;
        
        public string Id{
            get{return id;}
            set{id = value;}
        }

        public TipoSolicitacao Tipo{
            get {return tipo;}
            set {tipo = value;}
        }

    }
}