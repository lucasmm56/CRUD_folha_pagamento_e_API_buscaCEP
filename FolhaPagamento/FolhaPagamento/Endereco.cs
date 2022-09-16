
using System;

namespace FolhaPagamento
{
    internal class Endereco
    {
        public String cep { get; set; }
        public String logradouro { get; set; }
        public String uf { get; set; }
        public String localidade { get; set; }
        public String bairro { get; set; }
        public int numero { get; set; }
    }
}