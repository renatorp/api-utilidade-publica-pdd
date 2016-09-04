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


        // GET api/v1.0/imoveis/1/iptu
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
 
    }
}