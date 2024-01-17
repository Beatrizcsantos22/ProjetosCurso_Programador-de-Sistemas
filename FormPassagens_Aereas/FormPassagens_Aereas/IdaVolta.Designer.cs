
namespace FormPassagens_Aereas
{
    partial class IdaVolta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbCod = new System.Windows.Forms.TextBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.cbxHorario = new System.Windows.Forms.ComboBox();
            this.btnCarrinho = new System.Windows.Forms.Button();
            this.btnApagarTudo = new System.Windows.Forms.Button();
            this.lblHorarioEmbarque = new System.Windows.Forms.Label();
            this.btnComprar = new System.Windows.Forms.Button();
            this.txbValorTotal = new System.Windows.Forms.TextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txbNumeroPassagem = new System.Windows.Forms.TextBox();
            this.lblNumeroPassagem = new System.Windows.Forms.Label();
            this.lblConfirmar = new System.Windows.Forms.Button();
            this.txbValor = new System.Windows.Forms.TextBox();
            this.lblValorPassagem = new System.Windows.Forms.Label();
            this.cbxDestino = new System.Windows.Forms.ComboBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblAtual = new System.Windows.Forms.Label();
            this.cbxAtual = new System.Windows.Forms.ComboBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lblIda = new System.Windows.Forms.Label();
            this.txbIda = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.txbVolta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbCod
            // 
            this.txbCod.Location = new System.Drawing.Point(715, 91);
            this.txbCod.Name = "txbCod";
            this.txbCod.Size = new System.Drawing.Size(124, 20);
            this.txbCod.TabIndex = 53;
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod.Location = new System.Drawing.Point(679, 37);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(160, 18);
            this.lblCod.TabIndex = 52;
            this.lblCod.Text = "Código do  Passageiro";
            // 
            // cbxHorario
            // 
            this.cbxHorario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxHorario.FormattingEnabled = true;
            this.cbxHorario.Items.AddRange(new object[] {
            "00:30:00",
            "2:55:00",
            "3:50:00",
            "5:30:00",
            "7:35:00",
            "9:15:00",
            "12:15:00",
            "14:25:00",
            "16:30:00",
            "18:10:00",
            "21:00:00",
            "23:15:00",
            ""});
            this.cbxHorario.Location = new System.Drawing.Point(500, 227);
            this.cbxHorario.Name = "cbxHorario";
            this.cbxHorario.Size = new System.Drawing.Size(171, 24);
            this.cbxHorario.TabIndex = 51;
            // 
            // btnCarrinho
            // 
            this.btnCarrinho.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarrinho.Location = new System.Drawing.Point(119, 414);
            this.btnCarrinho.Name = "btnCarrinho";
            this.btnCarrinho.Size = new System.Drawing.Size(153, 47);
            this.btnCarrinho.TabIndex = 50;
            this.btnCarrinho.Text = "Adicionar a Passagem";
            this.btnCarrinho.UseVisualStyleBackColor = true;
            this.btnCarrinho.Click += new System.EventHandler(this.btnCarrinho_Click);
            // 
            // btnApagarTudo
            // 
            this.btnApagarTudo.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagarTudo.Location = new System.Drawing.Point(739, 227);
            this.btnApagarTudo.Name = "btnApagarTudo";
            this.btnApagarTudo.Size = new System.Drawing.Size(112, 65);
            this.btnApagarTudo.TabIndex = 49;
            this.btnApagarTudo.Text = "Apagar Tudo";
            this.btnApagarTudo.UseVisualStyleBackColor = true;
            this.btnApagarTudo.Click += new System.EventHandler(this.btnApagarTudo_Click);
            // 
            // lblHorarioEmbarque
            // 
            this.lblHorarioEmbarque.AutoSize = true;
            this.lblHorarioEmbarque.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorarioEmbarque.Location = new System.Drawing.Point(515, 201);
            this.lblHorarioEmbarque.Name = "lblHorarioEmbarque";
            this.lblHorarioEmbarque.Size = new System.Drawing.Size(154, 18);
            this.lblHorarioEmbarque.TabIndex = 48;
            this.lblHorarioEmbarque.Text = "Horário de Embarque";
            // 
            // btnComprar
            // 
            this.btnComprar.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprar.Location = new System.Drawing.Point(350, 414);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(157, 57);
            this.btnComprar.TabIndex = 47;
            this.btnComprar.Text = "Comprar Passagem";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // txbValorTotal
            // 
            this.txbValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbValorTotal.Location = new System.Drawing.Point(500, 355);
            this.txbValorTotal.Name = "txbValorTotal";
            this.txbValorTotal.Size = new System.Drawing.Size(186, 23);
            this.txbValorTotal.TabIndex = 46;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(542, 321);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(82, 18);
            this.lblValorTotal.TabIndex = 45;
            this.lblValorTotal.Text = "Valor Total";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(739, 316);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 62);
            this.btnCancelar.TabIndex = 43;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txbNumeroPassagem
            // 
            this.txbNumeroPassagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNumeroPassagem.Location = new System.Drawing.Point(311, 354);
            this.txbNumeroPassagem.Name = "txbNumeroPassagem";
            this.txbNumeroPassagem.Size = new System.Drawing.Size(125, 23);
            this.txbNumeroPassagem.TabIndex = 42;
            this.txbNumeroPassagem.TextChanged += new System.EventHandler(this.txbNumeroPassagem_TextChanged);
            // 
            // lblNumeroPassagem
            // 
            this.lblNumeroPassagem.AutoSize = true;
            this.lblNumeroPassagem.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroPassagem.Location = new System.Drawing.Point(293, 321);
            this.lblNumeroPassagem.Name = "lblNumeroPassagem";
            this.lblNumeroPassagem.Size = new System.Drawing.Size(155, 18);
            this.lblNumeroPassagem.TabIndex = 41;
            this.lblNumeroPassagem.Text = "Número de Passagem";
            // 
            // lblConfirmar
            // 
            this.lblConfirmar.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmar.Location = new System.Drawing.Point(362, 201);
            this.lblConfirmar.Name = "lblConfirmar";
            this.lblConfirmar.Size = new System.Drawing.Size(108, 48);
            this.lblConfirmar.TabIndex = 40;
            this.lblConfirmar.Text = "Confirmar Destino";
            this.lblConfirmar.UseVisualStyleBackColor = true;
            this.lblConfirmar.Click += new System.EventHandler(this.lblConfirmar_Click);
            // 
            // txbValor
            // 
            this.txbValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbValor.Location = new System.Drawing.Point(62, 354);
            this.txbValor.Name = "txbValor";
            this.txbValor.Size = new System.Drawing.Size(169, 23);
            this.txbValor.TabIndex = 39;
            // 
            // lblValorPassagem
            // 
            this.lblValorPassagem.AutoSize = true;
            this.lblValorPassagem.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPassagem.Location = new System.Drawing.Point(75, 321);
            this.lblValorPassagem.Name = "lblValorPassagem";
            this.lblValorPassagem.Size = new System.Drawing.Size(136, 18);
            this.lblValorPassagem.TabIndex = 38;
            this.lblValorPassagem.Text = "Valor da Passagem";
            // 
            // cbxDestino
            // 
            this.cbxDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDestino.FormattingEnabled = true;
            this.cbxDestino.Location = new System.Drawing.Point(149, 245);
            this.cbxDestino.Name = "cbxDestino";
            this.cbxDestino.Size = new System.Drawing.Size(191, 24);
            this.cbxDestino.TabIndex = 37;
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestino.Location = new System.Drawing.Point(33, 251);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(58, 18);
            this.lblDestino.TabIndex = 36;
            this.lblDestino.Text = "Destino";
            // 
            // lblAtual
            // 
            this.lblAtual.AutoSize = true;
            this.lblAtual.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtual.Location = new System.Drawing.Point(1, 201);
            this.lblAtual.Name = "lblAtual";
            this.lblAtual.Size = new System.Drawing.Size(152, 18);
            this.lblAtual.TabIndex = 35;
            this.lblAtual.Text = "Sua localização atual:";
            // 
            // cbxAtual
            // 
            this.cbxAtual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAtual.FormattingEnabled = true;
            this.cbxAtual.Items.AddRange(new object[] {
            "Jundiaí -SP",
            "São José dos Campos-Sp",
            "Paulínia",
            "Ribeirão Preto",
            "Uberlândia",
            "Sorocaba",
            "Joinville",
            "Piracicaba",
            "Caxias do Sul",
            "Campos dos Goytacazes",
            "Londrina",
            "Parauapebas",
            "Maringá",
            "Taubaté",
            "São José do Rio Preto",
            "Blumenau",
            "Juiz de Fora",
            "Macaé",
            "Ponta Grossa",
            "Anápolis",
            "Louveira",
            "Bauru",
            "Sumaré",
            "Feira de Santana",
            "Indaiatuba",
            "Foz do Iguaçu",
            "Uberaba",
            "Hortolândia",
            "Limeira",
            "Jacareí",
            "Cascavel",
            "Jaguariúna",
            "Volta Redonda",
            "São Carlos",
            "Americana",
            "  Três Lagoas",
            "Ipatinga",
            "Rondonópolis",
            "Rio Verde",
            "Rio Claro",
            "Franca",
            "Araraquara",
            "Montes Claros",
            "Chapecó",
            "Vinhedo",
            "Campina Grande",
            "Marabá",
            "Passo Fundo",
            "Pelotas",
            "Jaraguá do Sul",
            "  Dourados",
            "Santa Cruz do Sul",
            "Presidente Prudente",
            "Resende",
            "Marília",
            "Itu",
            "Extrema",
            "Pouso Alegre",
            "Santa Maria",
            "Criciúma",
            "Pindamonhangaba",
            "Araçatuba",
            "Caruaru",
            "Salto",
            "Imperatriz",
            "Vitória da Conquista",
            "Tucuruí",
            "Poços de Caldas",
            "Catalão",
            "Mossoró",
            "Atibaia",
            "Itupeva",
            "Divinópolis",
            "Petrolina",
            "Toledo",
            "Governador Valadares",
            "Brusque",
            "Valinhos",
            "Sorriso"});
            this.cbxAtual.Location = new System.Drawing.Point(149, 198);
            this.cbxAtual.Name = "cbxAtual";
            this.cbxAtual.Size = new System.Drawing.Size(191, 24);
            this.cbxAtual.TabIndex = 34;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(559, 49);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(91, 54);
            this.btnAdicionar.TabIndex = 33;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lblIda
            // 
            this.lblIda.AutoSize = true;
            this.lblIda.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIda.Location = new System.Drawing.Point(255, 36);
            this.lblIda.Name = "lblIda";
            this.lblIda.Size = new System.Drawing.Size(85, 18);
            this.lblIda.TabIndex = 32;
            this.lblIda.Text = "Data de Ida";
            // 
            // txbIda
            // 
            this.txbIda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIda.Location = new System.Drawing.Point(362, 33);
            this.txbIda.Name = "txbIda";
            this.txbIda.Size = new System.Drawing.Size(174, 23);
            this.txbIda.TabIndex = 31;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.Location = new System.Drawing.Point(4, 9);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 30;
            // 
            // txbVolta
            // 
            this.txbVolta.Location = new System.Drawing.Point(362, 91);
            this.txbVolta.Name = "txbVolta";
            this.txbVolta.Size = new System.Drawing.Size(179, 20);
            this.txbVolta.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 56;
            this.label1.Text = "Data da Volta";
            // 
            // IdaVolta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(871, 478);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbVolta);
            this.Controls.Add(this.txbCod);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.cbxHorario);
            this.Controls.Add(this.btnCarrinho);
            this.Controls.Add(this.btnApagarTudo);
            this.Controls.Add(this.lblHorarioEmbarque);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.txbValorTotal);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txbNumeroPassagem);
            this.Controls.Add(this.lblNumeroPassagem);
            this.Controls.Add(this.lblConfirmar);
            this.Controls.Add(this.txbValor);
            this.Controls.Add(this.lblValorPassagem);
            this.Controls.Add(this.cbxDestino);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.lblAtual);
            this.Controls.Add(this.cbxAtual);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.lblIda);
            this.Controls.Add(this.txbIda);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "IdaVolta";
            this.Text = "IdaVolta";
            this.Load += new System.EventHandler(this.IdaVolta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbCod;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.ComboBox cbxHorario;
        private System.Windows.Forms.Button btnCarrinho;
        private System.Windows.Forms.Button btnApagarTudo;
        private System.Windows.Forms.Label lblHorarioEmbarque;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.TextBox txbValorTotal;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txbNumeroPassagem;
        private System.Windows.Forms.Label lblNumeroPassagem;
        private System.Windows.Forms.Button lblConfirmar;
        private System.Windows.Forms.TextBox txbValor;
        private System.Windows.Forms.Label lblValorPassagem;
        private System.Windows.Forms.ComboBox cbxDestino;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblAtual;
        private System.Windows.Forms.ComboBox cbxAtual;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lblIda;
        private System.Windows.Forms.TextBox txbIda;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox txbVolta;
        private System.Windows.Forms.Label label1;
    }
}