using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        public List<Aluno> Alunos = new List<Aluno>()
        {
            new Aluno() 
            {
                Id = 1,
                Nome = "Silvio",
                Sobrenome =  "Obelar",
                Telefone = "999999999"
            },
            new Aluno() 
            {
                Id = 2,
                Nome = "Clara",
                Sobrenome =  "Obelar2",
                Telefone = "777777777"
            },
            new Aluno() 
            {
                Id = 3,
                Nome = "Amor",
                Sobrenome =  "Oliveira",
                Telefone = "888888888"
            },
        };

        public AlunoController() { }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Alunos);
        }

         [HttpGet("byid/{id}")]
        public IActionResult GetById(int id)
        {
            var aluno = Alunos.FirstOrDefault(a => a.Id == id);
            if (aluno == null) return BadRequest("Aluno não encontrado");

            return Ok(aluno);
        }
          [HttpGet("ByName")]
        public IActionResult GetByName(string Nome, string Sobrenome)
        {
            var aluno = Alunos.FirstOrDefault(a => 
                a.Nome.Contains(Nome) && a.Sobrenome.Contains(Sobrenome)
            );
            if (aluno == null) return BadRequest("Aluno não encontrado");

            return Ok(aluno);
        }

        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {
            return Ok(aluno);
        }

        // PUT: api/aluno/1
        [HttpPut("{id}")]
        public IActionResult Put(int id, Aluno aluno)
        {
            return Ok(aluno);
        }
        // Patch: api/aluno/1
        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Aluno aluno)
        {
            return Ok(aluno);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }


    }
}
