using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerConfWeb.Models
{
    public class Servidor
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public string SistemaOperacional { get; set; }

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
    }
}
