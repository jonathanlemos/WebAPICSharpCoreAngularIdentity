using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contexto.Models
{
    public class Usuario
    {
        public Usuario( int id,
                        string email,
                        string senha,
                        string primeiroNome,
                        string nomeCompleto,
                        string endereco,
                        string complemento,
                        int numero,
                        string cidade,
                        string estado,
                        string cepId,
                        string sexoIdM)
        {
            this.id = id;
            this.email = email;
            this.senha = senha;
            this.primeiroNome = primeiroNome;
            this.nomeCompleto = nomeCompleto;
            this.endereco = endereco;
            this.complemento = complemento;
            this.numero = numero;
            this.cidade = cidade;
            this.estado = estado;
            this.cepId = cepId;
            this.sexoIdM = sexoIdM;
        }

        public int id { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public string primeiroNome { get; set; }
        public string nomeCompleto { get; set; }
        public string endereco { get; set; }
        public string complemento { get; set; }
        public int numero { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string cepId { get; set; }
        public string sexoIdM { get; set; }
    }
}
