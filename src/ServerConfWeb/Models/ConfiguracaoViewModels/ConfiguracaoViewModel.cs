using ServerConfWeb.Models.ServidorViewModels;
using System;
using System.ComponentModel.DataAnnotations;

namespace ServerConfWeb.Models.ConfiguracaoViewModels
{
    public class ConfiguracaoViewModel
    {
        public string Id { get; set; }

        [Display(Name = "Servidor")]
        public ServidorViewModel Servidor { get; set; }

        public DateTime DataHora { get; set; }

        [Display(Name = "Serviço")]
        public string ServicoNome { get; set; }

        [Display(Name = "Conteúdo")]
        public string Conteudo { get; set; }

        public ConfiguracaoViewModel() { }

        public ConfiguracaoViewModel(Configuracao mapFrom)
        {
            if (mapFrom != null)
            {
                Id = mapFrom.Id.ToString();
                if (mapFrom.Servidor != null)
                {
                    Servidor = new ServidorViewModel(mapFrom.Servidor);
                }
                DataHora = mapFrom.DataHora;
                ServicoNome = mapFrom.ServicoNome;
                Conteudo = mapFrom.Conteudo;
            }
        }
    }
}
