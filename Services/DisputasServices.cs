using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RpgApi.Data;
using RpgApi.Dto;

namespace RpgApi.Services
{
    public class DisputasServices
    {
        private readonly DataContext _context;

        public DisputasServices(DataContext context)
        {
            _context = context;
        }

        public async Task<List<DisputaDto>> ObterDisputas()
        {
            var resultado = _context.Database.SqlQueryRaw<DisputaDto>(@"SELECT DI.Id,
PE.Nome AS Atacante,
OP.Nome AS Oponente,
DI.Tx_Narracao AS Narracao,
US.Username AS NomeUsuarioAtacante,
USOP.Username AS NomeUsuarioOponente
FROM TB_DISPUTAS DI
INNER JOIN TB_PERSONAGENS PE on DI.AtacanteId = PE.Id
INNER JOIN TB_PERSONAGENS OP on DI.OponenteId = OP.Id
INNER JOIN TB_USUARIOS US on PE.UsuarioId = US.Id
INNER JOIN TB_USUARIOS USOP on OP.UsuarioId = USOP.Id");
            return resultado.ToList();
        }
    }
}