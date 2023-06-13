namespace NumericUpDown1
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tb_valor = new System.Windows.Forms.TextBox();
            this.Definirvalor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.numericUpDown1.Location = new System.Drawing.Point(13, 13);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(145, 20);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // tb_valor
            // 
            this.tb_valor.Location = new System.Drawing.Point(245, 13);
            this.tb_valor.Name = "tb_valor";
            this.tb_valor.Size = new System.Drawing.Size(140, 20);
            this.tb_valor.TabIndex = 1;
            this.tb_valor.TextChanged += new System.EventHandler(this.tb_valor_TextChanged);
            // 
            // Definirvalor
            // 
            this.Definirvalor.Location = new System.Drawing.Point(403, 8);
            this.Definirvalor.Name = "Definirvalor";
            this.Definirvalor.Size = new System.Drawing.Size(85, 27);
            this.Definirvalor.TabIndex = 2;
            this.Definirvalor.Text = "Definir Valor";
            this.Definirvalor.UseVisualStyleBackColor = true;
            this.Definirvalor.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Definirvalor);
            this.Controls.Add(this.tb_valor);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox tb_valor;
        private System.Windows.Forms.Button Definirvalor;
    }
}

