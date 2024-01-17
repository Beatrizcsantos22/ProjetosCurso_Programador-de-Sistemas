
namespace MatriculaAluno
{
    partial class FrmMatricula
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
            this.txdNome = new System.Windows.Forms.TextBox();
            this.nblAnoNascimento = new System.Windows.Forms.Label();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.btnIndentificar = new System.Windows.Forms.Button();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblIndentifica = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblHoje = new System.Windows.Forms.Label();
            this.lblIdadeAtual = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(12, 38);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(114, 18);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome do aluno:";
            this.lblNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // txdNome
            // 
            this.txdNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txdNome.Location = new System.Drawing.Point(132, 35);
            this.txdNome.Name = "txdNome";
            this.txdNome.Size = new System.Drawing.Size(368, 24);
            this.txdNome.TabIndex = 1;
            // 
            // nblAnoNascimento
            // 
            this.nblAnoNascimento.AutoSize = true;
            this.nblAnoNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nblAnoNascimento.Location = new System.Drawing.Point(3, 103);
            this.nblAnoNascimento.Name = "nblAnoNascimento";
            this.nblAnoNascimento.Size = new System.Drawing.Size(142, 18);
            this.nblAnoNascimento.TabIndex = 2;
            this.nblAnoNascimento.Text = "Ano de Nascimento:";
            this.nblAnoNascimento.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.Location = new System.Drawing.Point(151, 103);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(97, 24);
            this.dtpNascimento.TabIndex = 3;
            // 
            // btnIndentificar
            // 
            this.btnIndentificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIndentificar.Location = new System.Drawing.Point(15, 212);
            this.btnIndentificar.Name = "btnIndentificar";
            this.btnIndentificar.Size = new System.Drawing.Size(198, 41);
            this.btnIndentificar.TabIndex = 4;
            this.btnIndentificar.Text = "Indentificar Categoria";
            this.btnIndentificar.UseVisualStyleBackColor = true;
            this.btnIndentificar.Click += new System.EventHandler(this.btnIndentificar_Click);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(250, 223);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(76, 18);
            this.lblCategoria.TabIndex = 5;
            this.lblCategoria.Text = "Categoria:";
            this.lblCategoria.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // lblIndentifica
            // 
            this.lblIndentifica.BackColor = System.Drawing.Color.Yellow;
            this.lblIndentifica.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIndentifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndentifica.Location = new System.Drawing.Point(332, 222);
            this.lblIndentifica.Name = "lblIndentifica";
            this.lblIndentifica.Size = new System.Drawing.Size(192, 23);
            this.lblIndentifica.TabIndex = 6;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(179, 352);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(201, 50);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblHoje
            // 
            this.lblHoje.AutoSize = true;
            this.lblHoje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoje.Location = new System.Drawing.Point(283, 108);
            this.lblHoje.Name = "lblHoje";
            this.lblHoje.Size = new System.Drawing.Size(0, 18);
            this.lblHoje.TabIndex = 8;
            // 
            // lblIdadeAtual
            // 
            this.lblIdadeAtual.AutoSize = true;
            this.lblIdadeAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdadeAtual.Location = new System.Drawing.Point(148, 153);
            this.lblIdadeAtual.Name = "lblIdadeAtual";
            this.lblIdadeAtual.Size = new System.Drawing.Size(0, 18);
            this.lblIdadeAtual.TabIndex = 9;
            // 
            // FrmMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 455);
            this.Controls.Add(this.lblIdadeAtual);
            this.Controls.Add(this.lblHoje);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblIndentifica);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.btnIndentificar);
            this.Controls.Add(this.dtpNascimento);
            this.Controls.Add(this.nblAnoNascimento);
            this.Controls.Add(this.txdNome);
            this.Controls.Add(this.lblNome);
            this.Name = "FrmMatricula";
            this.Text = "Tela de Matricula de Alunos";
            this.Load += new System.EventHandler(this.FrmMatricula_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txdNome;
        private System.Windows.Forms.Label nblAnoNascimento;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.Button btnIndentificar;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblIndentifica;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblHoje;
        private System.Windows.Forms.Label lblIdadeAtual;
    }
}

