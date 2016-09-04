using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using api_utilidade_publica_pdd.Model;


namespace api_utilidade_publica_pdd.Controllers
{
    

    [Route("api/v1.0/[controller]")]
    public class AlunosController : Controller
    {

        private static IDictionary<int, Aluno> alunos = new Dictionary<int, Aluno>();

        static AlunosController() {
            Aluno a1 = new Aluno(1, "José Pereira");
            a1.ListaHistoricoEscolar.Add(new HistoricoEscolar("Primeira série", "A", "Português", 100, 80));
            a1.ListaHistoricoEscolar.Add(new HistoricoEscolar("Primeira série", "A", "Matemática", 100, 90));
            a1.ListaHistoricoEscolar.Add(new HistoricoEscolar("Segunda série", "C", "Português", 100, 89));
            alunos.Add(1,a1);

            Aluno a2 = new Aluno(2, "Maria Santos");
            a2.ListaHistoricoEscolar.Add(new HistoricoEscolar("Primeira série", "B", "Português", 100, 99));
            a2.ListaHistoricoEscolar.Add(new HistoricoEscolar("Primeira série", "A", "Matemática", 100, 79));
            a2.ListaHistoricoEscolar.Add(new HistoricoEscolar("Segunda série", "C", "História", 100, 93));
            alunos.Add(2,a2);
        }

        
        // GET api/alunos/{codaluno}/historico
        [HttpGet("{codaluno}/historico/")]
        public IActionResult getHistoricoAluno(int codAluno)
        {
             Aluno l = findById(codAluno);
            if (l == null) {
                return NotFound(new RetornoErro("NotFound", "Código de aluno não econtrado."));
            }

            return Ok(l.ListaHistoricoEscolar);
        }

        private Aluno findById(int codigo) {   
            Aluno a = null;
            alunos.TryGetValue(codigo, out a);
            return a;
        }
    }
}
