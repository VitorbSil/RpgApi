using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using RpgApi.Models;
using RpgApi.Models.Enuns;

namespace RpgApi.Controllers
{
    [Route("[Controller]")]
    public class PersonagensExercicioController : Controller
    {
        private static List<Personagem> personagens = new List<Personagem>()
        {
            new Personagem() { Id = 1, Nome = "Frodo", PontosVida=200, Forca=17, Defesa=23, Inteligencia=33, Classe = ClasseEnum.Cavaleiro },
            new Personagem() { Id = 2, Nome = "Sam", PontosVida=180, Forca=15, Defesa=25, Inteligencia=30, Classe=ClasseEnum.Cavaleiro},
            new Personagem() { Id = 3, Nome = "Galadriel", PontosVida=130, Forca=18, Defesa=21, Inteligencia=35, Classe=ClasseEnum.Clerigo },
            new Personagem() { Id = 4, Nome = "Gandalf", PontosVida=90, Forca=18, Defesa=18, Inteligencia=37, Classe=ClasseEnum.Mago },
            new Personagem() { Id = 5, Nome = "Hobbit", PontosVida=150, Forca=20, Defesa=17, Inteligencia=31, Classe=ClasseEnum.Cavaleiro },
            new Personagem() { Id = 6, Nome = "Celeborn", PontosVida=100, Forca=21, Defesa=13, Inteligencia=34, Classe=ClasseEnum.Clerigo },
            new Personagem() { Id = 7, Nome = "Radagast", PontosVida=100, Forca=25, Defesa=11, Inteligencia=35, Classe=ClasseEnum.Mago }
        };


        [HttpGet("GetByNome/{nome}")]
        public IActionResult GetByNome(string nome)
        {
            List<Personagem> listaBusca = personagens.FindAll(p => p.Nome.Contains(nome));
            if (listaBusca.IsNullOrEmpty())
                return BadRequest("Personagem não encontrado");

            return Ok(listaBusca);
        }

        [HttpGet("GetClerigoMago")]
        public IActionResult GetClerigoMago()
        {
            List<Personagem> listaClerigoMago = (personagens.FindAll(p => p.Classe != ClasseEnum.Cavaleiro)).OrderByDescending(p => p.PontosVida).ToList();
            return Ok(listaClerigoMago);
        }

        [HttpGet("GetEstatistica")]
        public IActionResult GetEstatistica()
        {
            return Ok("Quantidade de personagens: " + personagens.Count + "\n Somatória da Inteligência dos personagens: " + personagens.Sum(p => p.Inteligencia));
        }



        [HttpPost("PostValidacao")]

        public IActionResult PostValidacao(Personagem novoPersonagem)
        {
            if (novoPersonagem.Defesa < 10 || novoPersonagem.Inteligencia > 30)
                return BadRequest("Valores de Defesa ou Inteligência inválidos.");

            personagens.Add(novoPersonagem);
            return Ok(personagens);
        }


        [HttpPost("PostValidacaoMago")]

        public IActionResult PostValidacaoMago(Personagem novoPersonagem)
        {
            if (novoPersonagem.Classe == ClasseEnum.Mago)
            {
                if (novoPersonagem.Inteligencia < 35)
                    return BadRequest("Um mago não pode ter Inteligência menor que 35");
            }
            
            personagens.Add(novoPersonagem);
            return Ok(personagens);
        }

        [HttpGet("GetByClasse/{Classe}")]
        public IActionResult Get(ClasseEnum Classe)
        {
            List<Personagem> listaBusca = personagens.FindAll(p => p.Classe == Classe);

            return Ok(listaBusca);
        }









    }
}