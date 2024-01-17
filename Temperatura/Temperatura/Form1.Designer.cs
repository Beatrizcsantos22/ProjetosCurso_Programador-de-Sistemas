
namespace Temperatura
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
            this.lblCelsius = new System.Windows.Forms.Label();
            this.lblKelvin = new System.Windows.Forms.Label();
            this.lblFahrenheit = new System.Windows.Forms.Label();
            this.txbCelsius = new System.Windows.Forms.TextBox();
            this.txbKelvin = new System.Windows.Forms.TextBox();
            this.txbFahrenheit = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCelsius
            // 
            this.lblCelsius.AutoSize = true;
            this.lblCelsius.Location = new System.Drawing.Point(21, 32);
            this.lblCelsius.Name = "lblCelsius";
            this.lblCelsius.Size = new System.Drawing.Size(40, 13);
            this.lblCelsius.TabIndex = 0;
            this.lblCelsius.Text = "Celsius";
            // 
            // lblKelvin
            // 
            this.lblKelvin.AutoSize = true;
            this.lblKelvin.Location = new System.Drawing.Point(24, 91);
            this.lblKelvin.Name = "lblKelvin";
            this.lblKelvin.Size = new System.Drawing.Size(36, 13);
            this.lblKelvin.TabIndex = 1;
            this.lblKelvin.Text = "Kelvin";
            // 
            // lblFahrenheit
            // 
            this.lblFahrenheit.AutoSize = true;
            this.lblFahrenheit.Location = new System.Drawing.Point(24, 178);
            this.lblFahrenheit.Name = "lblFahrenheit";
            this.lblFahrenheit.Size = new System.Drawing.Size(57, 13);
            this.lblFahrenheit.TabIndex = 2;
            this.lblFahrenheit.Text = "Fahrenheit";
            // 
            // txbCelsius
            // 
            this.txbCelsius.BackColor = System.Drawing.SystemColors.Window;
            this.txbCelsius.Location = new System.Drawing.Point(64, 27);
            this.txbCelsius.Name = "txbCelsius";
            this.txbCelsius.Size = new System.Drawing.Size(93, 20);
            this.txbCelsius.TabIndex = 3;
            // 
            // txbKelvin
            // 
            this.txbKelvin.BackColor = System.Drawing.SystemColors.Window;
            this.txbKelvin.Location = new System.Drawing.Point(70, 85);
            this.txbKelvin.Name = "txbKelvin";
            this.txbKelvin.Size = new System.Drawing.Size(86, 20);
            this.txbKelvin.TabIndex = 4;
            // 
            // txbFahrenheit
            // 
            this.txbFahrenheit.Location = new System.Drawing.Point(90, 179);
            this.txbFahrenheit.Name = "txbFahrenheit";
            this.txbFahrenheit.Size = new System.Drawing.Size(77, 20);
            this.txbFahrenheit.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.PaleGreen;
            this.btnCalcular.Location = new System.Drawing.Point(271, 208);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(154, 80);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(468, 345);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txbFahrenheit);
            this.Controls.Add(this.txbKelvin);
            this.Controls.Add(this.txbCelsius);
            this.Controls.Add(this.lblFahrenheit);
            this.Controls.Add(this.lblKelvin);
            this.Controls.Add(this.lblCelsius);
            this.Name = "Form1";
            this.Text = "Formulário Converter Temperaturas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCelsius;
        private System.Windows.Forms.Label lblKelvin;
        private System.Windows.Forms.Label lblFahrenheit;
        private System.Windows.Forms.TextBox txbCelsius;
        private System.Windows.Forms.TextBox txbKelvin;
        private System.Windows.Forms.TextBox txbFahrenheit;
        private System.Windows.Forms.Button btnCalcular;
    }
}

