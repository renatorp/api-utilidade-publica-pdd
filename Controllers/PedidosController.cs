using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using api_utilidade_publica_pdd.Model;

namespace api_utilidade_publica_pdd.Controllers
{
    

    [Route("api/v1.0/[controller]")]
    public class PedidosController : Controller
    {
        private static IDictionary<int, Pedido> pedidos = new Dictionary<int, Pedido>();
        
        // POST api/v1.0/pedidos/adocaogato
        [HttpPost("adocaogato")]
        public IActionResult PostPedidoAdocaoGato([FromBody]Pedido pedido)
        {
            pedido.Id = pedidos.Count + 1;
            pedido.Tipo = Pedido.TipoPedido.ADOCAO_GATO;
            pedidos.Add(pedido.Id, pedido);
            return Created("api/v1.0/pedidos/" + pedido.Id, pedido);
        }

        
        // POST api/v1.0/pedidos/adocaocao
        [HttpPost("adocaocao")]
        public IActionResult PostPedidoAdocaoCao([FromBody]Pedido pedido)
        {
            pedido.Id = pedidos.Count + 1;
            pedido.Tipo = Pedido.TipoPedido.ADOCAO_CACHORRO;
            pedidos.Add(pedido.Id, pedido);
            return Created("api/v1.0/pedidos/" + pedido.Id, pedido);
        }

        // POST api/v1.0/pedidos/{id}
        [HttpGet("{id}")]
        public IActionResult getPedido(int id)
        {
            Pedido p = null;
            pedidos.TryGetValue(id, out p);
            if (p == null) {
                return NotFound(new RetornoErro("NotFound", "Pedido não encontrado."));
            }
            return Ok(p);
        }
    }
}
