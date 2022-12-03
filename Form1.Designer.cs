namespace Cauculadora
{
    partial class CAUCULADORA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CAUCULADORA));
            this.operacao = new System.Windows.Forms.Label();
            this.buttonN7 = new System.Windows.Forms.Button();
            this.buttonN8 = new System.Windows.Forms.Button();
            this.buttonN9 = new System.Windows.Forms.Button();
            this.button_Mais = new System.Windows.Forms.Button();
            this.button_CE = new System.Windows.Forms.Button();
            this.button_Igual = new System.Windows.Forms.Button();
            this.button_vezes = new System.Windows.Forms.Button();
            this.buttonN3 = new System.Windows.Forms.Button();
            this.buttonN2 = new System.Windows.Forms.Button();
            this.buttonN1 = new System.Windows.Forms.Button();
            this.button_C = new System.Windows.Forms.Button();
            this.button_Menos = new System.Windows.Forms.Button();
            this.buttonN6 = new System.Windows.Forms.Button();
            this.buttonN5 = new System.Windows.Forms.Button();
            this.buttonN4 = new System.Windows.Forms.Button();
            this.button_divisor = new System.Windows.Forms.Button();
            this.button_ponto = new System.Windows.Forms.Button();
            this.buttonN0 = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // operacao
            // 
            this.operacao.AutoSize = true;
            this.operacao.Location = new System.Drawing.Point(12, 24);
            this.operacao.Name = "operacao";
            this.operacao.Size = new System.Drawing.Size(0, 13);
            this.operacao.TabIndex = 1;
            this.operacao.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonN7
            // 
            this.buttonN7.Location = new System.Drawing.Point(12, 67);
            this.buttonN7.Name = "buttonN7";
            this.buttonN7.Size = new System.Drawing.Size(55, 52);
            this.buttonN7.TabIndex = 2;
            this.buttonN7.Text = "7";
            this.buttonN7.UseVisualStyleBackColor = true;
            this.buttonN7.Click += new System.EventHandler(this.buttonN7_Click);
            // 
            // buttonN8
            // 
            this.buttonN8.Location = new System.Drawing.Point(73, 67);
            this.buttonN8.Name = "buttonN8";
            this.buttonN8.Size = new System.Drawing.Size(58, 52);
            this.buttonN8.TabIndex = 3;
            this.buttonN8.Text = "8";
            this.buttonN8.UseVisualStyleBackColor = true;
            this.buttonN8.Click += new System.EventHandler(this.buttonN8_Click);
            // 
            // buttonN9
            // 
            this.buttonN9.Location = new System.Drawing.Point(137, 67);
            this.buttonN9.Name = "buttonN9";
            this.buttonN9.Size = new System.Drawing.Size(60, 52);
            this.buttonN9.TabIndex = 4;
            this.buttonN9.Text = "9";
            this.buttonN9.UseVisualStyleBackColor = true;
            this.buttonN9.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_Mais
            // 
            this.button_Mais.Location = new System.Drawing.Point(212, 67);
            this.button_Mais.Name = "button_Mais";
            this.button_Mais.Size = new System.Drawing.Size(55, 52);
            this.button_Mais.TabIndex = 5;
            this.button_Mais.Text = "+";
            this.button_Mais.UseVisualStyleBackColor = true;
            this.button_Mais.Click += new System.EventHandler(this.button4_Click);
            // 
            // button_CE
            // 
            this.button_CE.Location = new System.Drawing.Point(275, 67);
            this.button_CE.Name = "button_CE";
            this.button_CE.Size = new System.Drawing.Size(50, 52);
            this.button_CE.TabIndex = 6;
            this.button_CE.Text = "CE";
            this.button_CE.UseVisualStyleBackColor = true;
            this.button_CE.Click += new System.EventHandler(this.button5_Click);
            // 
            // button_Igual
            // 
            this.button_Igual.Location = new System.Drawing.Point(273, 177);
            this.button_Igual.Name = "button_Igual";
            this.button_Igual.Size = new System.Drawing.Size(52, 96);
            this.button_Igual.TabIndex = 11;
            this.button_Igual.Text = "=";
            this.button_Igual.UseVisualStyleBackColor = true;
            this.button_Igual.Click += new System.EventHandler(this.button_Igual_Click);
            // 
            // button_vezes
            // 
            this.button_vezes.Location = new System.Drawing.Point(212, 177);
            this.button_vezes.Name = "button_vezes";
            this.button_vezes.Size = new System.Drawing.Size(55, 48);
            this.button_vezes.TabIndex = 10;
            this.button_vezes.Text = "x";
            this.button_vezes.UseVisualStyleBackColor = true;
            this.button_vezes.Click += new System.EventHandler(this.button7_Click);
            // 
            // buttonN3
            // 
            this.buttonN3.Location = new System.Drawing.Point(137, 177);
            this.buttonN3.Name = "buttonN3";
            this.buttonN3.Size = new System.Drawing.Size(60, 48);
            this.buttonN3.TabIndex = 9;
            this.buttonN3.Text = "3";
            this.buttonN3.UseVisualStyleBackColor = true;
            this.buttonN3.Click += new System.EventHandler(this.button8_Click);
            // 
            // buttonN2
            // 
            this.buttonN2.Location = new System.Drawing.Point(73, 177);
            this.buttonN2.Name = "buttonN2";
            this.buttonN2.Size = new System.Drawing.Size(58, 48);
            this.buttonN2.TabIndex = 8;
            this.buttonN2.Text = "2";
            this.buttonN2.UseVisualStyleBackColor = true;
            this.buttonN2.Click += new System.EventHandler(this.buttonN2_Click);
            // 
            // buttonN1
            // 
            this.buttonN1.Location = new System.Drawing.Point(12, 177);
            this.buttonN1.Name = "buttonN1";
            this.buttonN1.Size = new System.Drawing.Size(55, 48);
            this.buttonN1.TabIndex = 7;
            this.buttonN1.Text = "1";
            this.buttonN1.UseVisualStyleBackColor = true;
            this.buttonN1.Click += new System.EventHandler(this.buttonN1_Click);
            // 
            // button_C
            // 
            this.button_C.Location = new System.Drawing.Point(275, 125);
            this.button_C.Name = "button_C";
            this.button_C.Size = new System.Drawing.Size(50, 46);
            this.button_C.TabIndex = 16;
            this.button_C.Text = "C";
            this.button_C.UseVisualStyleBackColor = true;
            this.button_C.Click += new System.EventHandler(this.button11_Click);
            // 
            // button_Menos
            // 
            this.button_Menos.Location = new System.Drawing.Point(212, 125);
            this.button_Menos.Name = "button_Menos";
            this.button_Menos.Size = new System.Drawing.Size(55, 46);
            this.button_Menos.TabIndex = 15;
            this.button_Menos.Text = "-";
            this.button_Menos.UseVisualStyleBackColor = true;
            this.button_Menos.Click += new System.EventHandler(this.button12_Click);
            // 
            // buttonN6
            // 
            this.buttonN6.Location = new System.Drawing.Point(137, 125);
            this.buttonN6.Name = "buttonN6";
            this.buttonN6.Size = new System.Drawing.Size(60, 46);
            this.buttonN6.TabIndex = 14;
            this.buttonN6.Text = "6";
            this.buttonN6.UseVisualStyleBackColor = true;
            this.buttonN6.Click += new System.EventHandler(this.buttonN6_Click);
            // 
            // buttonN5
            // 
            this.buttonN5.Location = new System.Drawing.Point(73, 125);
            this.buttonN5.Name = "buttonN5";
            this.buttonN5.Size = new System.Drawing.Size(58, 46);
            this.buttonN5.TabIndex = 13;
            this.buttonN5.Text = "5";
            this.buttonN5.UseVisualStyleBackColor = true;
            this.buttonN5.Click += new System.EventHandler(this.buttonN5_Click);
            // 
            // buttonN4
            // 
            this.buttonN4.Location = new System.Drawing.Point(12, 125);
            this.buttonN4.Name = "buttonN4";
            this.buttonN4.Size = new System.Drawing.Size(55, 46);
            this.buttonN4.TabIndex = 12;
            this.buttonN4.Text = "4";
            this.buttonN4.UseVisualStyleBackColor = true;
            this.buttonN4.Click += new System.EventHandler(this.buttonN4_Click);
            // 
            // button_divisor
            // 
            this.button_divisor.Location = new System.Drawing.Point(212, 231);
            this.button_divisor.Name = "button_divisor";
            this.button_divisor.Size = new System.Drawing.Size(55, 42);
            this.button_divisor.TabIndex = 20;
            this.button_divisor.Text = "/";
            this.button_divisor.UseVisualStyleBackColor = true;
            this.button_divisor.Click += new System.EventHandler(this.button_divisor_Click);
            // 
            // button_ponto
            // 
            this.button_ponto.Location = new System.Drawing.Point(137, 231);
            this.button_ponto.Name = "button_ponto";
            this.button_ponto.Size = new System.Drawing.Size(60, 42);
            this.button_ponto.TabIndex = 19;
            this.button_ponto.Text = ".";
            this.button_ponto.UseVisualStyleBackColor = true;
            this.button_ponto.Click += new System.EventHandler(this.button_ponto_Click);
            // 
            // buttonN0
            // 
            this.buttonN0.Location = new System.Drawing.Point(12, 231);
            this.buttonN0.Name = "buttonN0";
            this.buttonN0.Size = new System.Drawing.Size(119, 42);
            this.buttonN0.TabIndex = 17;
            this.buttonN0.Text = "0";
            this.buttonN0.UseVisualStyleBackColor = true;
            this.buttonN0.Click += new System.EventHandler(this.button20_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(11, 21);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(5);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(314, 20);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResultado.TextChanged += new System.EventHandler(this.txtResultado_TextChanged);
            // 
            // lblOperacao
            // 
            this.lblOperacao.AutoSize = true;
            this.lblOperacao.Location = new System.Drawing.Point(18, 24);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(0, 13);
            this.lblOperacao.TabIndex = 21;
            this.lblOperacao.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Copyright FC ©";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // CAUCULADORA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(339, 316);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOperacao);
            this.Controls.Add(this.button_divisor);
            this.Controls.Add(this.button_ponto);
            this.Controls.Add(this.buttonN0);
            this.Controls.Add(this.button_C);
            this.Controls.Add(this.button_Menos);
            this.Controls.Add(this.buttonN6);
            this.Controls.Add(this.buttonN5);
            this.Controls.Add(this.buttonN4);
            this.Controls.Add(this.button_Igual);
            this.Controls.Add(this.button_vezes);
            this.Controls.Add(this.buttonN3);
            this.Controls.Add(this.buttonN2);
            this.Controls.Add(this.buttonN1);
            this.Controls.Add(this.button_CE);
            this.Controls.Add(this.button_Mais);
            this.Controls.Add(this.buttonN9);
            this.Controls.Add(this.buttonN8);
            this.Controls.Add(this.buttonN7);
            this.Controls.Add(this.operacao);
            this.Controls.Add(this.txtResultado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CAUCULADORA";
            this.Text = "CALCULADORA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label operacao;
        private System.Windows.Forms.Button buttonN7;
        private System.Windows.Forms.Button buttonN8;
        private System.Windows.Forms.Button buttonN9;
        private System.Windows.Forms.Button button_Mais;
        private System.Windows.Forms.Button button_CE;
        private System.Windows.Forms.Button button_Igual;
        private System.Windows.Forms.Button button_vezes;
        private System.Windows.Forms.Button buttonN3;
        private System.Windows.Forms.Button buttonN2;
        private System.Windows.Forms.Button buttonN1;
        private System.Windows.Forms.Button button_C;
        private System.Windows.Forms.Button button_Menos;
        private System.Windows.Forms.Button buttonN6;
        private System.Windows.Forms.Button buttonN5;
        private System.Windows.Forms.Button buttonN4;
        private System.Windows.Forms.Button button_divisor;
        private System.Windows.Forms.Button button_ponto;
        private System.Windows.Forms.Button buttonN0;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblOperacao;
        private System.Windows.Forms.Label label1;
    }
}

