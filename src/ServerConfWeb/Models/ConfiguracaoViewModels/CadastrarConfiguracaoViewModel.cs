using System;
using System.ComponentModel.DataAnnotations;

namespace ServerConfWeb.Models.ConfiguracaoViewModels
{
    public class CadastrarConfiguracaoViewModel
    {
        [Required]
        [Display(Name = "Servidor")]
        public string ServidorId { get; set; }

        public DateTime DataHora { get; set; }

        [Required]
        [Display(Name = "Serviço")]
        public string ServicoNome { get; set; }

        [Required]
        [Display(Name = "Conteúdo")]
        public string Conteudo { get; set; }

        public Configuracao mapToConfiguracao()
        {
            return new Configuracao
            {
                Id = Guid.NewGuid(),
                ServidorId = new Guid(ServidorId),
                DataHora = DataHora,
                ServicoNome = ServicoNome,
                Conteudo = Conteudo
            };
        }
    }
}
