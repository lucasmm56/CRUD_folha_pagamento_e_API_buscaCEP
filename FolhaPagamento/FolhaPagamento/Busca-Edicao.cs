using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolhaPagamento
{
    public partial class BuscaProfessor : Form
    {
        Professor prof = new Professor();
        CodeFirstEntities db = new CodeFirstEntities();

        public BuscaProfessor() => InitializeComponent();      

        private void BuscaProfessor_Load(object sender, EventArgs e)
        {
            Clear();
            dataGridView1.DataSource = db.Professores.ToList<Professor>();
        }

        private void button1_Click(object sender, EventArgs e)
        {         
                prof.name = nome.Text;
                prof.cpf = textBox2.Text;
                prof.email = email.Text;
                prof.telefone = textBox1.Text;
                prof.cep = cep.Text;
                prof.logradouro = textBox3.Text;
                prof.bairro = bairro.Text;
                prof.estado = estado.Text;
                prof.numero = numero.Text;
                prof.cidade = cidade.Text;
            using (CodeFirstEntities db = new CodeFirstEntities())
            {
                if (prof.id == 0)
                {
                    db.Professores.Add(prof);
                    db.SaveChanges();
                    Clear();
                    PopulateDataGridView();
                    MessageBox.Show("Novo cadastro realizado", "Professor cadastrado");
                }
                else
                {
                    db.Entry(prof).State = EntityState.Modified;
                    db.SaveChanges();
                    Clear();
                    PopulateDataGridView();
                    MessageBox.Show("Cadastro atualizado", "Editado");
                }
            }

        }
        void Clear()
        {
            nome.Text = email.Text = textBox2.Text = textBox1.Text = cidade.Text = textBox3.Text = cep.Text= bairro.Text = numero.Text = estado.Text = "";
            btsave.Text = "Novo";
            remover.Enabled = false;
            prof.id = 0;
        }

        private void limpar_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void PopulateDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            using (CodeFirstEntities db = new CodeFirstEntities()) {

                dataGridView1.DataSource = db.Professores.ToList<Professor>();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                prof.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
                using (CodeFirstEntities db = new CodeFirstEntities())
                {
                    prof = db.Professores.Where(x => x.id == prof.id).FirstOrDefault();
                    nome.Text = prof.name;
                    textBox2.Text = prof.cpf ;
                    email.Text = prof.email;
                    textBox1.Text =  prof.telefone;
                    cep.Text =  prof.cep;
                    textBox3.Text =  prof.logradouro;
                    bairro.Text = prof.bairro;
                    estado.Text = prof.estado;
                    numero.Text = prof.numero;
                    cidade.Text = prof.cidade;
                }
                btsave.Text = "Alterar";
                remover.Enabled = true;


            }
        }

        private void remover_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Voce quer mesmo deletar esse registro ?","Sistema de Professores Imepac", MessageBoxButtons.YesNo) == DialogResult.Yes)
                using (CodeFirstEntities db = new CodeFirstEntities())
                {
                    var entry = db.Entry(prof);
                    if (entry.State == EntityState.Detached)
                        db.Professores.Attach(prof);
                    db.Professores.Remove(prof);
                    db.SaveChanges();
                    PopulateDataGridView();
                    Clear();
                    MessageBox.Show("Deletado com sucesso","Professor Deletado");
                }
        }
       

        private void setAddressForm(Endereco endereco)
        {
            cidade.Text = endereco.localidade;
            bairro.Text = endereco.bairro;
            estado.Text = endereco.uf;
            textBox3.Text = endereco.logradouro;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BuscaCepApi buscaCepApi = new BuscaCepApi(cep.Text);
            Endereco endereco = buscaCepApi.load();
            setAddressForm(endereco);
        }
    }
}

