using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RpgApi.Dto
{
    public class DisputaDto
    {
        public int Id { get; set; }
        public string Atacante { get; set; } = "";
        public string Oponente { get; set; } = "";
        public string Narracao { get; set; } ="";
        public string NomeUsuarioAtacante { get; set; } ="";
        public string NomeUsuarioOponente { get; set; } ="";
    
    }
}