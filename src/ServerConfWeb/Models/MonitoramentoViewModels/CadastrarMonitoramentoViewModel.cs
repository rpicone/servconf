using System;
using System.ComponentModel.DataAnnotations;

namespace ServerConfWeb.Models.MonitoramentoViewModels
{
    public class CadastrarMonitoramentoViewModel
    {
        public string ServidorId { get; set; }

        public long PacketsIn { get; set; }

        public long PacketsOut { get; set; }

        public string PercentualUsoCPU { get; set; }

        public string TotalMemoria { get; set; }

        public string TotalMemoriaEmUso { get; set; }

        public string TamanhoDisco { get; set; }

        public string TotalDiscoEmUso { get; set; }

        public Monitoramento mapToMonitoramento()
        {
            return new Monitoramento
            {
                Id = Guid.NewGuid(),
                ServidorId = new Guid(ServidorId),
                PacketsIn = PacketsIn,
                PacketsOut = PacketsOut,
                PercentualUsoCPU = PercentualUsoCPU,
                TotalMemoria = TotalMemoria,
                TotalMemoriaEmUso = TotalMemoriaEmUso,
                TamanhoDisco = TamanhoDisco,
                TotalDiscoEmUso = TotalDiscoEmUso
            };
        }
    }
}
