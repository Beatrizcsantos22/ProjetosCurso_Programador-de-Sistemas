
namespace Cadastro_Formulario
{
    partial class Form1
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txbCpf = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.DateTimePicker();
            this.lblHorario = new System.Windows.Forms.Label();
            this.gpxHorario = new System.Windows.Forms.GroupBox();
            this.rbdNoite = new System.Windows.Forms.RadioButton();
            this.rdbTarde = new System.Windows.Forms.RadioButton();
            this.rdbManha = new System.Windows.Forms.RadioButton();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txbQuantidade = new System.Windows.Forms.TextBox();
            this.lblNomeDisciplina = new System.Windows.Forms.Label();
            this.txbNomeDisciplina = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lstLista = new System.Windows.Forms.ListBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.lblEscola = new System.Windows.Forms.Label();
            this.txbEscola = new System.Windows.Forms.TextBox();
            this.gpxHorario.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(12, 23);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 17);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // txbNome
            // 
            this.txbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNome.Location = new System.Drawing.Point(78, 22);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(376, 23);
            this.txbNome.TabIndex = 1;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(465, 22);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(38, 17);
            this.lblCpf.TabIndex = 2;
            this.lblCpf.Text = "CPF:";
            // 
            // txbCpf
            // 
            this.txbCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCpf.Location = new System.Drawing.Point(509, 22);
            this.txbCpf.Name = "txbCpf";
            this.txbCpf.Size = new System.Drawing.Size(168, 23);
            this.txbCpf.TabIndex = 3;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(12, 70);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(73, 17);
            this.lblEndereco.TabIndex = 4;
            this.lblEndereco.Text = "Endereço:";
            // 
            // txbEndereco
            // 
            this.txbEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEndereco.Location = new System.Drawing.Point(92, 71);
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(495, 23);
            this.txbEndereco.TabIndex = 5;
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascimento.Location = new System.Drawing.Point(12, 113);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(140, 17);
            this.lblDataNascimento.TabIndex = 6;
            this.lblDataNascimento.Text = "Data de Nascimento:";
            // 
            // lblData
            // 
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.lblData.Location = new System.Drawing.Point(163, 113);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(109, 23);
            this.lblData.TabIndex = 7;
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.Location = new System.Drawing.Point(13, 195);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(121, 17);
            this.lblHorario.TabIndex = 8;
            this.lblHorario.Text = "Horário da Escola";
            // 
            // gpxHorario
            // 
            this.gpxHorario.Controls.Add(this.rbdNoite);
            this.gpxHorario.Controls.Add(this.rdbTarde);
            this.gpxHorario.Controls.Add(this.rdbManha);
            this.gpxHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpxHorario.Location = new System.Drawing.Point(163, 192);
            this.gpxHorario.Name = "gpxHorario";
            this.gpxHorario.Size = new System.Drawing.Size(356, 53);
            this.gpxHorario.TabIndex = 9;
            this.gpxHorario.TabStop = false;
            // 
            // rbdNoite
            // 
            this.rbdNoite.AutoSize = true;
            this.rbdNoite.Location = new System.Drawing.Point(261, 22);
            this.rbdNoite.Name = "rbdNoite";
            this.rbdNoite.Size = new System.Drawing.Size(59, 21);
            this.rbdNoite.TabIndex = 2;
            this.rbdNoite.TabStop = true;
            this.rbdNoite.Text = "Noite";
            this.rbdNoite.UseVisualStyleBackColor = true;
            // 
            // rdbTarde
            // 
            this.rdbTarde.AutoSize = true;
            this.rdbTarde.Location = new System.Drawing.Point(133, 22);
            this.rdbTarde.Name = "rdbTarde";
            this.rdbTarde.Size = new System.Drawing.Size(64, 21);
            this.rdbTarde.TabIndex = 1;
            this.rdbTarde.TabStop = true;
            this.rdbTarde.Text = "Tarde";
            this.rdbTarde.UseVisualStyleBackColor = true;
            // 
            // rdbManha
            // 
            this.rdbManha.AutoSize = true;
            this.rdbManha.Checked = true;
            this.rdbManha.Location = new System.Drawing.Point(17, 22);
            this.rdbManha.Name = "rdbManha";
            this.rdbManha.Size = new System.Drawing.Size(69, 21);
            this.rdbManha.TabIndex = 0;
            this.rdbManha.TabStop = true;
            this.rdbManha.Text = "Manhã";
            this.rdbManha.UseVisualStyleBackColor = true;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(429, 251);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(182, 17);
            this.lblQuantidade.TabIndex = 10;
            this.lblQuantidade.Text = "Quantas Discplinas Estuda:";
            this.lblQuantidade.Click += new System.EventHandler(this.lblQuantidade_Click);
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQuantidade.Location = new System.Drawing.Point(617, 251);
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(79, 23);
            this.txbQuantidade.TabIndex = 11;
            // 
            // lblNomeDisciplina
            // 
            this.lblNomeDisciplina.AutoSize = true;
            this.lblNomeDisciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeDisciplina.Location = new System.Drawing.Point(8, 257);
            this.lblNomeDisciplina.Name = "lblNomeDisciplina";
            this.lblNomeDisciplina.Size = new System.Drawing.Size(133, 17);
            this.lblNomeDisciplina.TabIndex = 12;
            this.lblNomeDisciplina.Text = "Nome da Disciplina:";
            // 
            // txbNomeDisciplina
            // 
            this.txbNomeDisciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomeDisciplina.Location = new System.Drawing.Point(147, 251);
            this.txbNomeDisciplina.Name = "txbNomeDisciplina";
            this.txbNomeDisciplina.Size = new System.Drawing.Size(259, 23);
            this.txbNomeDisciplina.TabIndex = 13;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(598, 303);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(98, 38);
            this.btnAdicionar.TabIndex = 14;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lstLista
            // 
            this.lstLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLista.FormattingEnabled = true;
            this.lstLista.ItemHeight = 16;
            this.lstLista.Location = new System.Drawing.Point(11, 303);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(328, 132);
            this.lstLista.TabIndex = 15;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(430, 301);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(157, 54);
            this.btnLimpar.TabIndex = 16;
            this.btnLimpar.Text = "Limpar Formulário";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(432, 344);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(152, 54);
            this.btnMostrar.TabIndex = 17;
            this.btnMostrar.Text = "Mostrar Resultado";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(414, 404);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(185, 42);
            this.btnApagar.TabIndex = 18;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // lblEscola
            // 
            this.lblEscola.AutoSize = true;
            this.lblEscola.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscola.Location = new System.Drawing.Point(8, 151);
            this.lblEscola.Name = "lblEscola";
            this.lblEscola.Size = new System.Drawing.Size(115, 17);
            this.lblEscola.TabIndex = 19;
            this.lblEscola.Text = "Nome da Escola:";
            // 
            // txbEscola
            // 
            this.txbEscola.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEscola.Location = new System.Drawing.Point(130, 151);
            this.txbEscola.Name = "txbEscola";
            this.txbEscola.Size = new System.Drawing.Size(480, 23);
            this.txbEscola.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 447);
            this.Controls.Add(this.txbEscola);
            this.Controls.Add(this.lblEscola);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lstLista);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txbNomeDisciplina);
            this.Controls.Add(this.lblNomeDisciplina);
            this.Controls.Add(this.txbQuantidade);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.gpxHorario);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.txbEndereco);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.txbCpf);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpxHorario.ResumeLayout(false);
            this.gpxHorario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TextBox txbCpf;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txbEndereco;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.DateTimePicker lblData;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.GroupBox gpxHorario;
        private System.Windows.Forms.RadioButton rbdNoite;
        private System.Windows.Forms.RadioButton rdbTarde;
        private System.Windows.Forms.RadioButton rdbManha;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txbQuantidade;
        private System.Windows.Forms.Label lblNomeDisciplina;
        private System.Windows.Forms.TextBox txbNomeDisciplina;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ListBox lstLista;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lblEscola;
        private System.Windows.Forms.TextBox txbEscola;
    }
}

