using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RpgApi.Data;
using RpgApi.Models;

namespace RpgApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArmasController : ControllerBase
    {
        private readonly DataContext _context;

        public ArmasController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingle(int id)
        {
            try
            {
                Armas a = await _context.TB_ARMAS.FirstOrDefaultAsync(pBusca => pBusca.Id == id);

                return Ok(a);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            try
            {
                List<Armas> lista = await _context.TB_ARMAS.ToListAsync();

                return Ok(lista);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }       

        [HttpPost]
        public async Task<IActionResult> Add(Armas novaArma)
        {
            try 
            {
                if (novaArma.Dano > 50)
                    throw new Exception("Pontos de dano não podem ser maiores que 50");

                Personagem p = await _context.TB_PERSONAGENS
                    .FirstOrDefaultAsync(p => p.Id == novaArma.PersonagemId) 
                    ?? throw new Exception("Não existe personagem com o Id informado");

                await _context.TB_ARMAS.AddAsync(novaArma);
                await _context.SaveChangesAsync();

                return Ok(novaArma.Id);
            }
            
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update(Armas novoArma)
        {
            try
            {
                if (novoArma.Dano > 70)
                {
                    throw new Exception ("O dano da arma não pode ser maior que 100");
                }
                _context.TB_ARMAS.Update(novoArma);
                int linhasAfetadas = await _context.SaveChangesAsync();

                return Ok(linhasAfetadas);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                Armas aRemover = await _context.TB_ARMAS.FirstOrDefaultAsync(p => p.Id == id);

                _context.TB_ARMAS.Remove(aRemover);
                int linhasAfetadas = await _context.SaveChangesAsync();

                return Ok(linhasAfetadas);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}