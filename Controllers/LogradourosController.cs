using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using api_utilidade_publica_pdd.Model;


namespace api_utilidade_publica_pdd.Controllers
{
    

    [Route("api/v1.0/[controller]")]
    public class LogradourosController : Controller
    {

        private static IDictionary<int, Logradouro> logradouros = new Dictionary<int, Logradouro>();

        static LogradourosController() {
            Logradouro l1 = new Logradouro(1, "Rua 1");
            l1.HorariosColetaLixo.Add(new HorarioColetaLixo("segunda", "11:10"));
            logradouros.Add(1,l1);

            Logradouro l2 = new Logradouro(2, "Avenida 2");
            l2.HorariosColetaLixo.Add(new HorarioColetaLixo("sábado", "13:10"));
            l2.HorariosColetaLixo.Add(new HorarioColetaLixo("domingo", "13:15"));
            logradouros.Add(2,l2);

            Logradouro l3 = new Logradouro(3, "Travessa 3");
            l3.HorariosColetaLixo.Add(new HorarioColetaLixo("quinta", "11:10"));
            logradouros.Add(3,l3);    
        }

        // GET api/logradouros/{id}/solicitacoes/coletaslixo
        [HttpGet("{id}/horariosColetaLixo")]
        public IActionResult getColetasLixo(int id)
        {
            Logradouro l = findById(id);
            if (l == null) {
                return NotFound(new RetornoErro("NotFound", "O logradouro não existe."));
            }
            return Ok(l.HorariosColetaLixo);
        }

        
        // PUT api/logradouros/{id}/solicitacoes/podaArvore
        [HttpPut("{id}/solicitacoes/podaArvore")]
        public IActionResult putSolicitacaoPodaArvore(int id)
        {
            Logradouro l = findById(id);
            if (l == null) {
                return NotFound(new RetornoErro("NotFound", "O logradouro não existe."));
            }

            return Ok(criarSolicitacaoParaLogradouro(l, Solicitacao.TipoSolicitacao.PodaArvore));
        }

        // PUT api/logradouros/{id}/solicitacoes/meiofio
        [HttpPut("{id}/solicitacoes/meiofio")]
        public IActionResult putSolicitacaoMeioFio(int id)
        {
            Logradouro l = findById(id);
            if (l == null) {
                return NotFound(new RetornoErro("NotFound", "O logradouro não existe."));
            }

            return Ok(criarSolicitacaoParaLogradouro(l, Solicitacao.TipoSolicitacao.ConstrucaoMeioFio));
        }

        // PUT api/logradouros/{id}/solicitacoes/recolhimentocarrosabandonados
        [HttpPut("{id}/solicitacoes/recolhimentocarrosabandonados")]
        public IActionResult putRecolhimentoCarrosAbandonados(int id)
        {
            Logradouro l = findById(id);
            if (l == null) {
                return NotFound(new RetornoErro("NotFound", "O logradouro não existe."));
            }

            return Ok(criarSolicitacaoParaLogradouro(l, Solicitacao.TipoSolicitacao.RecolhimentoCarrosAbandonados));
        }

        // PUT api/logradouros/{id}/solicitacoes/desobstrucaoviapublica
        [HttpPut("{id}/solicitacoes/desobstrucaoviapublica")]
        public IActionResult putDesobstrucaoViaPublica(int id)
        {
            Logradouro l = findById(id);
            if (l == null) {
                return NotFound(new RetornoErro("NotFound", "O logradouro não existe."));
            }

            return Ok(criarSolicitacaoParaLogradouro(l, Solicitacao.TipoSolicitacao.DesobstrucaoViasPublicas));
        }

        // PUT api/logradouros/{id}/solicitacoes/desobstrucaocorregos
        [HttpPut("{id}/solicitacoes/desobstrucaocorregos")]
        public IActionResult putDesobstrucaoCorregos(int id)
        {
            Logradouro l = findById(id);
            if (l == null) {
                return NotFound(new RetornoErro("NotFound", "O logradouro não existe."));
            }

            return Ok(criarSolicitacaoParaLogradouro(l, Solicitacao.TipoSolicitacao.DesobstrucaoCorregos));
        }


        // PUT api/logradouros/{id}/solicitacoes/coletaanimalmorto
        [HttpPut("{id}/solicitacoes/coletaanimalmorto")]
        public IActionResult putColetaAnimalMorto(int id)
        {
            Logradouro l = findById(id);
            if (l == null) {
                return NotFound(new RetornoErro("NotFound", "O logradouro não existe."));
            }

            return Ok(criarSolicitacaoParaLogradouro(l, Solicitacao.TipoSolicitacao.ColetaAnimalMorto));
        }


        // PUT api/logradouros/{id}/solicitacoes/limpezabocalobo
        [HttpPut("{id}/solicitacoes/limpezabocalobo")]
        public IActionResult putLimpezaBocaLobo(int id)
        {
            Logradouro l = findById(id);
            if (l == null) {
                return NotFound(new RetornoErro("NotFound", "O logradouro não existe."));
            }

            return Ok(criarSolicitacaoParaLogradouro(l, Solicitacao.TipoSolicitacao.LimpezaBocaLobo));
        }

        private Solicitacao criarSolicitacaoParaLogradouro(Logradouro l, Solicitacao.TipoSolicitacao tipo) {
            Solicitacao s = findSolicitacaoByTipo(l, tipo);
            if (s == null) {
                s = new Solicitacao(tipo);
                l.Solicitacoes.Add(s);
            }
            return s;
        }

        private Logradouro findById(int id) {   
            Logradouro l = null;
            logradouros.TryGetValue(id, out l);
            return l;
        }
        private Solicitacao findSolicitacaoByTipo(Logradouro l, Solicitacao.TipoSolicitacao tipo) {
            return l.Solicitacoes.Find(s => s.Tipo == tipo);
        }

    }
}