namespace FolhaPagamento
{
    partial class CadastroProfessor
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.telefone = new System.Windows.Forms.TextBox();
            this.cpf = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.nome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buscar = new System.Windows.Forms.Button();
            this.numero = new System.Windows.Forms.TextBox();
            this.bairro = new System.Windows.Forms.TextBox();
            this.logradouro = new System.Windows.Forms.TextBox();
            this.estado = new System.Windows.Forms.TextBox();
            this.cidade = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cep = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cadastrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "E-mail";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.telefone);
            this.panel1.Controls.Add(this.cpf);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.nome);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 116);
            this.panel1.TabIndex = 16;
            // 
            // telefone
            // 
            this.telefone.Location = new System.Drawing.Point(269, 82);
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(159, 20);
            this.telefone.TabIndex = 20;
            // 
            // cpf
            // 
            this.cpf.Location = new System.Drawing.Point(65, 82);
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(144, 20);
            this.cpf.TabIndex = 19;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(65, 53);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(546, 20);
            this.email.TabIndex = 17;
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(66, 27);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(545, 20);
            this.nome.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Dados Pessoais";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Endereço";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.buscar);
            this.panel2.Controls.Add(this.numero);
            this.panel2.Controls.Add(this.bairro);
            this.panel2.Controls.Add(this.logradouro);
            this.panel2.Controls.Add(this.estado);
            this.panel2.Controls.Add(this.cidade);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.cep);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(12, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(443, 143);
            this.panel2.TabIndex = 18;
            // 
            // buscar
            // 
            this.buscar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buscar.Location = new System.Drawing.Point(231, 19);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(51, 23);
            this.buscar.TabIndex = 27;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = false;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // numero
            // 
            this.numero.Location = new System.Drawing.Point(334, 111);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(94, 20);
            this.numero.TabIndex = 22;
            // 
            // bairro
            // 
            this.bairro.Location = new System.Drawing.Point(65, 111);
            this.bairro.Name = "bairro";
            this.bairro.Size = new System.Drawing.Size(217, 20);
            this.bairro.TabIndex = 22;
            // 
            // logradouro
            // 
            this.logradouro.Location = new System.Drawing.Point(65, 85);
            this.logradouro.Name = "logradouro";
            this.logradouro.Size = new System.Drawing.Size(363, 20);
            this.logradouro.TabIndex = 22;
            // 
            // estado
            // 
            this.estado.Location = new System.Drawing.Point(334, 59);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(94, 20);
            this.estado.TabIndex = 23;
            // 
            // cidade
            // 
            this.cidade.Location = new System.Drawing.Point(65, 59);
            this.cidade.Name = "cidade";
            this.cidade.Size = new System.Drawing.Size(217, 20);
            this.cidade.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(286, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Número";
            // 
            // cep
            // 
            this.cep.Location = new System.Drawing.Point(65, 21);
            this.cep.Name = "cep";
            this.cep.Size = new System.Drawing.Size(160, 20);
            this.cep.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Bairro";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "CEP";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Cidade";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(290, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Estado";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Rua / Av";
            // 
            // cadastrar
            // 
            this.cadastrar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cadastrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cadastrar.Location = new System.Drawing.Point(480, 277);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(157, 23);
            this.cadastrar.TabIndex = 26;
            this.cadastrar.Text = "Cadastrar";
            this.cadastrar.UseVisualStyleBackColor = false;
            this.cadastrar.Click += new System.EventHandler(this.cadastrar_Click);
            // 
            // CadastroProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(655, 328);
            this.Controls.Add(this.cadastrar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Name = "CadastroProfessor";
            this.Text = "Cadastro de Professores";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox telefone;
        private System.Windows.Forms.TextBox cpf;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.TextBox numero;
        private System.Windows.Forms.TextBox bairro;
        private System.Windows.Forms.TextBox logradouro;
        private System.Windows.Forms.TextBox estado;
        private System.Windows.Forms.TextBox cidade;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox cep;
        private System.Windows.Forms.Button cadastrar;
    }
}

