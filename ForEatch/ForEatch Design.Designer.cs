
namespace EstruturaForEath
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
            this.lblVisitar = new System.Windows.Forms.Label();
            this.txbVisitar = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblLocais = new System.Windows.Forms.Label();
            this.lbsLocais = new System.Windows.Forms.ListBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVisitar
            // 
            this.lblVisitar.AutoSize = true;
            this.lblVisitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisitar.Location = new System.Drawing.Point(12, 47);
            this.lblVisitar.Name = "lblVisitar";
            this.lblVisitar.Size = new System.Drawing.Size(231, 17);
            this.lblVisitar.TabIndex = 0;
            this.lblVisitar.Text = "Cinco lugare que gostaria de visitar";
            // 
            // txbVisitar
            // 
            this.txbVisitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbVisitar.Location = new System.Drawing.Point(12, 83);
            this.txbVisitar.Name = "txbVisitar";
            this.txbVisitar.Size = new System.Drawing.Size(227, 23);
            this.txbVisitar.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(12, 195);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(231, 45);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Adicionar a Lista";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(12, 267);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(231, 43);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar a Lista";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblLocais
            // 
            this.lblLocais.AutoSize = true;
            this.lblLocais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocais.Location = new System.Drawing.Point(447, 47);
            this.lblLocais.Name = "lblLocais";
            this.lblLocais.Size = new System.Drawing.Size(186, 17);
            this.lblLocais.TabIndex = 4;
            this.lblLocais.Text = "Listas dos Locais Preferidos";
            // 
            // lbsLocais
            // 
            this.lbsLocais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsLocais.FormattingEnabled = true;
            this.lbsLocais.ItemHeight = 16;
            this.lbsLocais.Location = new System.Drawing.Point(399, 83);
            this.lbsLocais.Name = "lbsLocais";
            this.lbsLocais.Size = new System.Drawing.Size(283, 260);
            this.lbsLocais.TabIndex = 5;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(399, 388);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(278, 47);
            this.btnMostrar.TabIndex = 6;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 468);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.lbsLocais);
            this.Controls.Add(this.lblLocais);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txbVisitar);
            this.Controls.Add(this.lblVisitar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVisitar;
        private System.Windows.Forms.TextBox txbVisitar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblLocais;
        private System.Windows.Forms.ListBox lbsLocais;
        private System.Windows.Forms.Button btnMostrar;
    }
}

