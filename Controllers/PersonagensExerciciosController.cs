using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RpgApi.Models;
using RpgApi.Models.Enuns;

namespace RpgApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonagensExerciciosController : Controller
    {
        private static List<Personagem> personagens = new List<Personagem>()
        {
            //Colar os objetos da lista do chat aqui
            new Personagem() { Id = 1, Nome = "Frodo", PontosVida=100, Forca=17, Defesa=23, Inteligencia=33, Classe=ClasseEnum.Cavaleiro},
            new Personagem() { Id = 2, Nome = "Sam", PontosVida=100, Forca=15, Defesa=25, Inteligencia=30, Classe=ClasseEnum.Cavaleiro},
            new Personagem() { Id = 3, Nome = "Galadriel", PontosVida=100, Forca=18, Defesa=21, Inteligencia=35, Classe=ClasseEnum.Clerigo },
            new Personagem() { Id = 4, Nome = "Gandalf", PontosVida=100, Forca=18, Defesa=18, Inteligencia=37, Classe=ClasseEnum.Mago },
            new Personagem() { Id = 5, Nome = "Hobbit", PontosVida=100, Forca=20, Defesa=17, Inteligencia=31, Classe=ClasseEnum.Cavaleiro },
            new Personagem() { Id = 6, Nome = "Celeborn", PontosVida=100, Forca=21, Defesa=13, Inteligencia=34, Classe=ClasseEnum.Clerigo },
            new Personagem() { Id = 7, Nome = "Radagast", PontosVida=100, Forca=25, Defesa=11, Inteligencia=35, Classe=ClasseEnum.Mago }
        };

        [HttpGet("GetByNome/{nome}")]
        public IActionResult GetByNome(string nome)
        {
            List<Personagem> listaBusca = personagens.FindAll(p => p.Nome.Contains(nome));

            if (listaBusca == null)
            {
                return BadRequest("Nome não encontrado na lista, certifique-se de ter digitado todos os caracteres corretamente");
            }
            else
            {
                return Ok(listaBusca);
            }
        }

        [HttpGet("GetClerigoMago")]
        public IActionResult GetClerigosMagos()
        {
            personagens.RemoveAll(p => p.Classe == ClasseEnum.Cavaleiro);

            return Ok(personagens.OrderByDescending(p => p.PontosVida));
        }

        [HttpGet("GetEstatisticas")]
        public IActionResult GetEstatisticas()
        {
            int somaInteligencia = personagens.Sum(p => p.Inteligencia);

            return Ok($"Quantidade de personagens: {personagens.Count}, Soma da Inteligência: {somaInteligencia}");
        }

        [HttpPost("PostValidacao")]
        public IActionResult PostValidacao(Personagem personagem)
        {
            if (personagem.Defesa < 10)
                return BadRequest("A defesa do personagem precisa ser maior que 10 pontos");
            else if (personagem.Inteligencia > 30)
                return BadRequest("A inteligência do personagem não pode ser maior que 30 pontos");
            else
            {
                personagens.Add(personagem);
                return Ok(personagens);
            }
        }

        [HttpPost("PostValidacaoMago")]
        public IActionResult PostValidacaoMago(Personagem personagem)
        {
            if (personagem.Classe == ClasseEnum.Mago && personagem.Inteligencia < 35)
            {
                return BadRequest("Personagem do tipo Mago deve ter inteligência maior ou igual a 35.");
            }
            personagens.Add(personagem);
            return Ok(personagens);
        }

        [HttpGet("GetByClasse/{classeId}")]
        public IActionResult GetByClasse(int classeId)
        {
            if (classeId < 1 || classeId > 3)
            {
                return BadRequest("Classe não existe");
            }

            ClasseEnum classeSelecionada = (ClasseEnum)classeId;

            List<Personagem> listaBusca = personagens.FindAll(p => p.Classe == classeSelecionada);
            
            return Ok(listaBusca);
        }
    }
}