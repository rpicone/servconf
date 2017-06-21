using ServerConfWeb.Models.ServidorViewModels;
using System;

namespace ServerConfWeb.Models.MonitoramentoViewModels
{
    public class MonitoramentoViewModel
    {
        public string Id { get; set; }

        public string ServidorId { get; set; }

        public ServidorViewModel Servidor { get; set; }

        public DateTime DataHora { get; set; }

        public long PacketsIn { get; set; }

        public long PacketsOut { get; set; }

        public string PercentualUsoCPU { get; set; }

        public string TotalMemoria { get; set; }

        public string TotalMemoriaEmUso { get; set; }

        public string TamanhoDisco { get; set; }

        public string TotalDiscoEmUso { get; set; }

        public MonitoramentoViewModel(Monitoramento mapFrom)
        {
            if (mapFrom != null)
            {
                Id = mapFrom.Id.ToString();
                if (mapFrom.Servidor != null)
                {
                    Servidor = new ServidorViewModel(mapFrom.Servidor);
                }
                DataHora = mapFrom.DataHora;
                PacketsIn = mapFrom.PacketsIn;
                PacketsOut = mapFrom.PacketsOut;
                PercentualUsoCPU = mapFrom.PercentualUsoCPU;
                TotalMemoria = mapFrom.TotalMemoria;
                TotalMemoriaEmUso = mapFrom.TotalMemoriaEmUso;
                TamanhoDisco = mapFrom.TamanhoDisco;
                TotalDiscoEmUso = mapFrom.TotalDiscoEmUso;
            }
        }
    }
}
