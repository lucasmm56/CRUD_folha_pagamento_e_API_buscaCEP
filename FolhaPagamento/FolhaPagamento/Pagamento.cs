using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaPagamento
{
    class Pagamento
    {
        private float totalFolha { get; set; }
        private List<Funcionario> funcionarios { get; set; }

        public Pagamento(List<Funcionario> funcionarios)
        {
            this.funcionarios = funcionarios;
        }

        public void addFuncionario(Funcionario funcionario)
        {
            funcionarios.Add(funcionario);
        }

        public float gerarFolhaPagamento()
        {
            float total = 0;

            foreach (Funcionario funcionario in funcionarios)
            {
                total += funcionario.calculaSalario();
            }
            return total;
        }
    }
}
