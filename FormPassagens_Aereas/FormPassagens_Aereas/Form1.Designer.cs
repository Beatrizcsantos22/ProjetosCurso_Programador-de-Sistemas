
namespace FormPassagens_Aereas
{
    partial class FrmCadastro
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
            this.gpxSelecao = new System.Windows.Forms.GroupBox();
            this.rbnIdaVolta = new System.Windows.Forms.RadioButton();
            this.rbnIda = new System.Windows.Forms.RadioButton();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.mtxbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mtbxCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btncSair = new System.Windows.Forms.Button();
            this.gpxSelecao.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpxSelecao
            // 
            this.gpxSelecao.Controls.Add(this.rbnIdaVolta);
            this.gpxSelecao.Controls.Add(this.rbnIda);
            this.gpxSelecao.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpxSelecao.Location = new System.Drawing.Point(48, 235);
            this.gpxSelecao.Name = "gpxSelecao";
            this.gpxSelecao.Size = new System.Drawing.Size(514, 132);
            this.gpxSelecao.TabIndex = 17;
            this.gpxSelecao.TabStop = false;
            this.gpxSelecao.Text = "Selecione";
            // 
            // rbnIdaVolta
            // 
            this.rbnIdaVolta.AutoSize = true;
            this.rbnIdaVolta.Location = new System.Drawing.Point(294, 61);
            this.rbnIdaVolta.Name = "rbnIdaVolta";
            this.rbnIdaVolta.Size = new System.Drawing.Size(189, 20);
            this.rbnIdaVolta.TabIndex = 1;
            this.rbnIdaVolta.TabStop = true;
            this.rbnIdaVolta.Text = "Passagem para Ida e Volta";
            this.rbnIdaVolta.UseVisualStyleBackColor = true;
            this.rbnIdaVolta.CheckedChanged += new System.EventHandler(this.rbnIdaVolta_CheckedChanged);
            // 
            // rbnIda
            // 
            this.rbnIda.AutoSize = true;
            this.rbnIda.Location = new System.Drawing.Point(55, 61);
            this.rbnIda.Name = "rbnIda";
            this.rbnIda.Size = new System.Drawing.Size(141, 20);
            this.rbnIda.TabIndex = 0;
            this.rbnIda.TabStop = true;
            this.rbnIda.Text = "Passagem para Ida";
            this.rbnIda.UseVisualStyleBackColor = true;
            this.rbnIda.CheckedChanged += new System.EventHandler(this.rbnIda_CheckedChanged);
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascimento.Location = new System.Drawing.Point(254, 103);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(137, 16);
            this.lblDataNascimento.TabIndex = 16;
            this.lblDataNascimento.Text = "Data de Nascimento:";
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(406, 103);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(120, 23);
            this.dtpDataNascimento.TabIndex = 15;
            // 
            // mtxbTelefone
            // 
            this.mtxbTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxbTelefone.Location = new System.Drawing.Point(99, 97);
            this.mtxbTelefone.Mask = "(99)00000000000";
            this.mtxbTelefone.Name = "mtxbTelefone";
            this.mtxbTelefone.Size = new System.Drawing.Size(108, 23);
            this.mtxbTelefone.TabIndex = 14;
            // 
            // mtbxCpf
            // 
            this.mtbxCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbxCpf.Location = new System.Drawing.Point(485, 36);
            this.mtbxCpf.Mask = "000.000.000.-00";
            this.mtbxCpf.Name = "mtbxCpf";
            this.mtbxCpf.Size = new System.Drawing.Size(115, 23);
            this.mtbxCpf.TabIndex = 13;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(25, 97);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(66, 16);
            this.lblTelefone.TabIndex = 12;
            this.lblTelefone.Text = "Telefone:";
            // 
            // txbNome
            // 
            this.txbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNome.Location = new System.Drawing.Point(92, 35);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(329, 23);
            this.txbNome.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(446, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cpf:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(26, 35);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 16);
            this.lblNome.TabIndex = 9;
            this.lblNome.Text = "Nome:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(595, 251);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(104, 65);
            this.btnSalvar.TabIndex = 18;
            this.btnSalvar.Text = "Salvar ";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(33, 153);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 16);
            this.lblEmail.TabIndex = 20;
            this.lblEmail.Text = "Email";
            // 
            // txbEmail
            // 
            this.txbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.Location = new System.Drawing.Point(81, 150);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(477, 23);
            this.txbEmail.TabIndex = 21;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(26, 196);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(45, 16);
            this.lblSenha.TabIndex = 22;
            this.lblSenha.Text = "Senha";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 196);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(477, 20);
            this.textBox1.TabIndex = 23;
            // 
            // btncSair
            // 
            this.btncSair.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncSair.Location = new System.Drawing.Point(595, 337);
            this.btncSair.Name = "btncSair";
            this.btncSair.Size = new System.Drawing.Size(104, 60);
            this.btncSair.TabIndex = 19;
            this.btncSair.Text = "Cancelar";
            this.btncSair.UseVisualStyleBackColor = true;
            this.btncSair.Click += new System.EventHandler(this.btncSair_Click);
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(731, 441);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btncSair);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gpxSelecao);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.dtpDataNascimento);
            this.Controls.Add(this.mtxbTelefone);
            this.Controls.Add(this.mtbxCpf);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNome);
            this.Name = "FrmCadastro";
            this.Text = "Cadastro Passagens Aéreas";
            this.Load += new System.EventHandler(this.FrmCadastro_Load);
            this.gpxSelecao.ResumeLayout(false);
            this.gpxSelecao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpxSelecao;
        private System.Windows.Forms.RadioButton rbnIdaVolta;
        private System.Windows.Forms.RadioButton rbnIda;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.MaskedTextBox mtxbTelefone;
        private System.Windows.Forms.MaskedTextBox mtbxCpf;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btncSair;
    }
}

