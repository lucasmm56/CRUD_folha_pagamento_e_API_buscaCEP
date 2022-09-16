using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaPagamento
{
    class Diretor : Funcionario
    {
        private float salario { get; set; }

        public override float calculaSalario()
        {
            return salario;
        }
    }
}
