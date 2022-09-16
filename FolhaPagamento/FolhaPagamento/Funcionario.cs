
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaPagamento
{
    abstract class Funcionario
    {
        private int id { get; set; }
        private String nome { get; set; }
        private String cpf { get; set; }
        private String email { get; set; }
        private String telefone { get; set; } 
        private String ctps { get; set; }
        private Endereco endereco { get; set; }

        public abstract float calculaSalario(); 
    }
}
