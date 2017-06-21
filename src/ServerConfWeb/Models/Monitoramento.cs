using System;

namespace ServerConfWeb.Models
{
    public class Monitoramento
    {
        public Guid Id { get; set; }

        public Guid ServidorId { get; set; }

        public Servidor Servidor { get; set; }

        public DateTime DataHora { get; set; }

        public long PacketsIn { get; set; }

        public long PacketsOut { get; set; }

        public string PercentualUsoCPU { get; set; }

        public string TotalMemoria { get; set; }

        public string TotalMemoriaEmUso { get; set; }

        public string TamanhoDisco { get; set; }

        public string TotalDiscoEmUso { get; set; }
    }
}
