using System;
using System.ComponentModel.DataAnnotations;

namespace ServerConfWeb.Models.ServidorViewModels
{
    public class ServidorViewModel
    {
        public string Id { get; set; }

        public string Nome{ get; set; }

        [Display(Name = "Sistema Operacional")]
        public string SistemaOperacional { get; set; }

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

        public ServidorViewModel(Servidor mapFrom)
        {
            if (mapFrom != null)
            {
                Id = mapFrom.Id.ToString();
                Nome = mapFrom.Nome;
                SistemaOperacional = mapFrom.SistemaOperacional;
                EnderecoIP = mapFrom.EnderecoIP;
                Periodicidade = mapFrom.Periodicidade;
                Oids = mapFrom.Oids;
                SecurityName = mapFrom.SecurityName;
                User = mapFrom.User;
                SenhaAutenticacao = mapFrom.SenhaAutenticacao;
                SenhaCriptografia = mapFrom.SenhaCriptografia;
                AlgoritmoAutenticacao = mapFrom.AlgoritmoAutenticacao;
                AlgoritmoCriptografia = mapFrom.AlgoritmoCriptografia;
                VersionSnmp = mapFrom.VersionSnmp;
                SecurityLevel = mapFrom.SecurityLevel;
                Timeout = mapFrom.Timeout;
            }
        }
    }
}
