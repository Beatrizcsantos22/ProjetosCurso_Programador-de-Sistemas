
namespace FormPassagens_Aereas
{
    partial class Escolha_CompraCadastrado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Escolha_CompraCadastrado));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxSelecione = new System.Windows.Forms.GroupBox();
            this.rbtnIda = new System.Windows.Forms.RadioButton();
            this.rbtnIdaVolta = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbxSelecione.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-32, -19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(417, 446);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // gbxSelecione
            // 
            this.gbxSelecione.Controls.Add(this.rbtnIda);
            this.gbxSelecione.Controls.Add(this.rbtnIdaVolta);
            this.gbxSelecione.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSelecione.Location = new System.Drawing.Point(420, 71);
            this.gbxSelecione.Name = "gbxSelecione";
            this.gbxSelecione.Size = new System.Drawing.Size(307, 268);
            this.gbxSelecione.TabIndex = 2;
            this.gbxSelecione.TabStop = false;
            this.gbxSelecione.Text = "Selecione";
            // 
            // rbtnIda
            // 
            this.rbtnIda.AutoSize = true;
            this.rbtnIda.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnIda.Location = new System.Drawing.Point(36, 42);
            this.rbtnIda.Name = "rbtnIda";
            this.rbtnIda.Size = new System.Drawing.Size(203, 22);
            this.rbtnIda.TabIndex = 2;
            this.rbtnIda.TabStop = true;
            this.rbtnIda.Text = "Comprar Passagem de Ida";
            this.rbtnIda.UseVisualStyleBackColor = true;
            this.rbtnIda.CheckedChanged += new System.EventHandler(this.lblIda_CheckedChanged_1);
            // 
            // rbtnIdaVolta
            // 
            this.rbtnIdaVolta.AutoSize = true;
            this.rbtnIdaVolta.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnIdaVolta.Location = new System.Drawing.Point(22, 132);
            this.rbtnIdaVolta.Name = "rbtnIdaVolta";
            this.rbtnIdaVolta.Size = new System.Drawing.Size(254, 22);
            this.rbtnIdaVolta.TabIndex = 1;
            this.rbtnIdaVolta.TabStop = true;
            this.rbtnIdaVolta.Text = "Comprar Passagem de Ida e Volta";
            this.rbtnIdaVolta.UseVisualStyleBackColor = true;
            this.rbtnIdaVolta.CheckedChanged += new System.EventHandler(this.lblIdaVolta_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Location = new System.Drawing.Point(379, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 64);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Location = new System.Drawing.Point(382, 335);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(384, 74);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Green;
            this.panel3.Location = new System.Drawing.Point(379, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(47, 277);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Green;
            this.panel4.Location = new System.Drawing.Point(719, 62);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(47, 277);
            this.panel4.TabIndex = 6;
            // 
            // Escolha_CompraCadastrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(766, 406);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbxSelecione);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Escolha_CompraCadastrado";
            this.Text = "Escolha_CompraCadastrado";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbxSelecione.ResumeLayout(false);
            this.gbxSelecione.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbxSelecione;
        private System.Windows.Forms.RadioButton rbtnIda;
        private System.Windows.Forms.RadioButton rbtnIdaVolta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}