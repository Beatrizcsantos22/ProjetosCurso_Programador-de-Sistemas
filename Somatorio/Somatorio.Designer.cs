
namespace VetorUni
{
    partial class FrmVetor
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
            this.lsbLista = new System.Windows.Forms.ListBox();
            this.lblSoma = new System.Windows.Forms.Label();
            this.txdNumero = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnExibir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.pgbProgresso = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lsbLista
            // 
            this.lsbLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbLista.FormattingEnabled = true;
            this.lsbLista.ItemHeight = 15;
            this.lsbLista.Location = new System.Drawing.Point(29, 21);
            this.lsbLista.Name = "lsbLista";
            this.lsbLista.ScrollAlwaysVisible = true;
            this.lsbLista.Size = new System.Drawing.Size(141, 424);
            this.lsbLista.TabIndex = 0;
            // 
            // lblSoma
            // 
            this.lblSoma.AutoSize = true;
            this.lblSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoma.Location = new System.Drawing.Point(176, 21);
            this.lblSoma.Name = "lblSoma";
            this.lblSoma.Size = new System.Drawing.Size(194, 15);
            this.lblSoma.TabIndex = 1;
            this.lblSoma.Text = "Digite o numero para o somatorio:";
            // 
            // txdNumero
            // 
            this.txdNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txdNumero.Location = new System.Drawing.Point(211, 64);
            this.txdNumero.Name = "txdNumero";
            this.txdNumero.Size = new System.Drawing.Size(128, 21);
            this.txdNumero.TabIndex = 2;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(202, 153);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(137, 66);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnExibir
            // 
            this.btnExibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibir.Location = new System.Drawing.Point(202, 247);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(134, 64);
            this.btnExibir.TabIndex = 4;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(202, 352);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(134, 63);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // pgbProgresso
            // 
            this.pgbProgresso.Location = new System.Drawing.Point(12, 459);
            this.pgbProgresso.Name = "pgbProgresso";
            this.pgbProgresso.Size = new System.Drawing.Size(369, 25);
            this.pgbProgresso.TabIndex = 6;
            // 
            // FrmVetor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 496);
            this.Controls.Add(this.pgbProgresso);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txdNumero);
            this.Controls.Add(this.lblSoma);
            this.Controls.Add(this.lsbLista);
            this.Name = "FrmVetor";
            this.Text = "Exemplo de Vetor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbLista;
        private System.Windows.Forms.Label lblSoma;
        private System.Windows.Forms.TextBox txdNumero;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ProgressBar pgbProgresso;
    }
}

