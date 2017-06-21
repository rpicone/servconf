using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerConfWeb.Models
{
    public class Configuracao
    {
        public Guid Id { get; set; }

        public Guid ServidorId { get; set; }

        public Servidor Servidor { get; set; }

        public DateTime DataHora { get; set; }

        public string ServicoNome { get; set; }

        public string Conteudo { get; set; }
    }
}
