using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using api_utilidade_publica_pdd.Model;


namespace api_utilidade_publica_pdd.Controllers
{
    

    [Route("api/v1.0/[controller]")]
    public class ImoveisController : Controller
    {

        private IDictionary<string, Imovel> imoveis = new Dictionary<string, Imovel>();

        public ImoveisController() {
            imoveis.Add("1",new Imovel("1", "R$ 35,00"));
            imoveis.Add("2",new Imovel("2", "R$ 350,00"));
            imoveis.Add("3",new Imovel("3", "R$ 45,00"));
            imoveis.Add("4",new Imovel("4", "R$ 435,00"));    
        }


        // GET api/imoveis/1/iptu
        [HttpGet("{codImovel}/iptu")]
        public IActionResult Get(string codImovel)
        {
            Imovel i = null;
            imoveis.TryGetValue(codImovel, out i);
            if (i == null) {
                return NotFound(new RetornoErro("NotFound", "O Imóvel informado não existe."));
            }
            return Ok(i.ValorIPTU);
            
        }
        
/*

        // GET api/logradouros/{logradouro}/solicitacoes/coletaslixo
        [HttpGet("logradouros/{logradouro}/coletaslixo")]
        public string[] getColetasLixo(string logradouro)
        {
            return new string[] { "coleta1", "coleta2" };
        }

        
        // PUT api/logradouros/{logradouro}/solicitacoes/podaArvore
        [HttpPut("logradouros/{logradouro}/solicitacoes/podaArvore")]
        public void SolicitaPodaArvore(string logradouro)
        {
        }

        // PUT api/logradouros/{logradouro}/solicitacoes/meiofio
        [HttpPut("logradouros/{logradouro}/solicitacoes/meiofio")]
        public void SolicitaMeioFio(string logradouro)
        {
        }
        
        // PUT api/logradouros/{logradouro}/solicitacoes/recolhimentocarrosabandonados
        [HttpPut("logradouros/{logradouro}/solicitacoes/recolhimentocarrosabandonados")]
        public void SolicitaRecolhimentoCarrosAbandonados(string logradouro)
        {
        }

        // PUT api/logradouros/{logradouro}/solicitacoes/desobstrucaoviapublica
        [HttpPut("logradouros/{logradouro}/solicitacoes/desobstrucaoviapublica")]
        public void SolicitaDesobstrucaoViaPublica(string logradouro)
        {
        }

        // PUT api/logradouros/{logradouro}/solicitacoes/coletaanimalmorto
        [HttpPut("logradouros/{logradouro}/solicitacoes/coletaanimalmorto")]
        public void SolicitaColetaAnimalMorto(string logradouro)
        {
        }

        // PUT api/logradouros/{logradouro}/solicitacoes/limpezabocalobo
        [HttpPut("logradouros/{logradouro}/solicitacoes/limpezabocalobo")]
        public void SolicitaLimpezaBocaLobo(string logradouro)
        {
        }
        


        // GET api/logradouros/{logradouro}/solicitacoes/coletaslixo
        [HttpGet("alunos/{codaluno}/historico/")]
        public string[] getHistoricoAluno(string codaluno)
        {
            return new string[] { "coleta1", "coleta2" };
        }

        // POST pedidoadocao/cao
        [HttpPost]
        public void getPedidoAdocaoCao([FromBody]string value)
        {
        }

        // POST pedidoadocao/gato
        [HttpPost]
        public void getPedidoAdocaoGato([FromBody]string value)
        {
        }
        */
    }
}

/*
GET localhost:5000/api/imovel/{codImovel}/iptu/
GET localhost:5000/api/logradouros/{logradouro}/coletaslixo/
PUT localhost:5000/api/logradouros/{logradouro}/solicitacoes/podaArvore/
PUT localhost:5000/api/logradouros/{logradouro}/solicitacoes/meiofio/
PUT Localhost:5000/api/logradouros/{logradouro}/solicitacoes/recolhimentocarrosabandonados/
PUT Localhost:5000/api/logradouros/{logradouro}/solicitacoes/desobstrucaoviapublica/
PUT Localhost:5000/api/logradouros/{logradouro}/solicitacoes/desobstrucaocorrego/
PUT localhost:5000/api/logradouros/{logradouro}/solicitacoes/coletaanimalmorto/
PUT localhost:5000/api/logradouros/{logradouro}/solicitacoes/limpezabocalobo/
GET localhost:5000/api/alunos/{codaluno}/historico/
POST localhost:5000/api/pedidoadocao/cao/
POST localhost:5000/api/pedidoadocao/gato/
~                                       

*/