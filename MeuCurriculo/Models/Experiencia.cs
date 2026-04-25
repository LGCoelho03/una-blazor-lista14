using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuCurriculo.Models
{
    public class Experiencia
    {
        public string Empresa { get; set; }
        public string Cargo { get; set; } = "Atual";
        public string Inicio { get; set; }
        public string Fim { get; set; }
        public string Descricao { get; set; }

    }
}