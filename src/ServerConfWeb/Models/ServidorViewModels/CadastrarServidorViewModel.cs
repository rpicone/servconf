using System;
using System.ComponentModel.DataAnnotations;

namespace ServerConfWeb.Models.ServidorViewModels
{
    public class CadastrarServidorViewModel
    {
        [Required]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Sistema Operacional")]
        public string SistemaOperacional { get; set; }

        [Required]
        [Display(Name = "Endereço IP")]
        public string EnderecoIP { get; set; }

        public long Periodicidade { get; set; }

        public String Oids { get; set; }

        public String SecurityName { get; set; }

        public String User { get; set; }

        public String SenhaAutenticacao { get; set; }

        public String SenhaCriptografia { get; set; }

        public String AlgoritmoAutenticacao { get; set; }

        public String AlgoritmoCriptografia { get; set; }

        public int VersionSnmp { get; set; }

        public int SecurityLevel { get; set; }

        public long Timeout { get; set; }

        public Servidor mapToServidor()
        {
            return new Servidor
            {
                Id = Guid.NewGuid(),
                Nome = Nome,
                SistemaOperacional = SistemaOperacional,
                EnderecoIP = EnderecoIP,
                Periodicidade = Periodicidade,
                Oids = Oids,
                SecurityName = SecurityName,
                User = User,
                SenhaAutenticacao = SenhaAutenticacao,
                SenhaCriptografia = SenhaCriptografia,
                AlgoritmoAutenticacao = AlgoritmoAutenticacao,
                AlgoritmoCriptografia = AlgoritmoCriptografia,
                VersionSnmp = VersionSnmp,
                SecurityLevel = SecurityLevel,
                Timeout = Timeout
            };
        }
    }
}
