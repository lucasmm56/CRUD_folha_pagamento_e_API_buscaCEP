using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolhaPagamento
{
    public partial class CadastroProfessor : Form
    {
        public CadastroProfessor()
        {
            InitializeComponent();
        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new CodeFirstEntities();
                var prof = new Professor();
                prof.name = nome.Text;
                prof.cpf = cpf.Text;
                prof.email = email.Text;
                prof.telefone = telefone.Text;
                prof.cep = cep.Text;
                prof.logradouro = logradouro.Text;
                prof.bairro = bairro.Text;
                prof.estado = estado.Text;
                prof.numero = numero.Text;
                prof.cidade = cidade.Text;

                db.Professores.Add(prof);
                db.SaveChanges();

            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao cadastrar, verifique a conexão!!");
            }

            MessageBox.Show("Cadastro Realizado com sucesso!!","Professor adicionado");
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            BuscaCepApi buscaCepApi = new BuscaCepApi(cep.Text);
            Endereco endereco =  buscaCepApi.load();
            setAddressForm(endereco);
        }

        private void setAddressForm(Endereco endereco)
        {
            cidade.Text = endereco.localidade;
            bairro.Text = endereco.bairro;
            estado.Text = endereco.uf;
            logradouro.Text = endereco.logradouro;
        }
    }
}
