namespace ProjetoAtleta
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
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_altura = new System.Windows.Forms.Label();
            this.txt_altura = new System.Windows.Forms.TextBox();
            this.txt_peso = new System.Windows.Forms.TextBox();
            this.lbl_peso = new System.Windows.Forms.Label();
            this.lbl_idade = new System.Windows.Forms.Label();
            this.txt_idade = new System.Windows.Forms.TextBox();
            this.btn_calcularIMC = new System.Windows.Forms.Button();
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(24, 19);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(38, 13);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(68, 19);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(174, 20);
            this.txt_nome.TabIndex = 1;
            // 
            // lbl_altura
            // 
            this.lbl_altura.AutoSize = true;
            this.lbl_altura.Location = new System.Drawing.Point(24, 56);
            this.lbl_altura.Name = "lbl_altura";
            this.lbl_altura.Size = new System.Drawing.Size(37, 13);
            this.lbl_altura.TabIndex = 2;
            this.lbl_altura.Text = "Altura:";
            // 
            // txt_altura
            // 
            this.txt_altura.Location = new System.Drawing.Point(68, 56);
            this.txt_altura.Name = "txt_altura";
            this.txt_altura.Size = new System.Drawing.Size(106, 20);
            this.txt_altura.TabIndex = 3;
            // 
            // txt_peso
            // 
            this.txt_peso.Location = new System.Drawing.Point(68, 95);
            this.txt_peso.Name = "txt_peso";
            this.txt_peso.Size = new System.Drawing.Size(106, 20);
            this.txt_peso.TabIndex = 4;
            // 
            // lbl_peso
            // 
            this.lbl_peso.AutoSize = true;
            this.lbl_peso.Location = new System.Drawing.Point(24, 95);
            this.lbl_peso.Name = "lbl_peso";
            this.lbl_peso.Size = new System.Drawing.Size(34, 13);
            this.lbl_peso.TabIndex = 5;
            this.lbl_peso.Text = "Peso:";
            this.lbl_peso.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_idade
            // 
            this.lbl_idade.AutoSize = true;
            this.lbl_idade.Location = new System.Drawing.Point(24, 137);
            this.lbl_idade.Name = "lbl_idade";
            this.lbl_idade.Size = new System.Drawing.Size(37, 13);
            this.lbl_idade.TabIndex = 6;
            this.lbl_idade.Text = "Idade:";
            this.lbl_idade.Click += new System.EventHandler(this.lbl_idade_Click);
            // 
            // txt_idade
            // 
            this.txt_idade.Location = new System.Drawing.Point(68, 137);
            this.txt_idade.Name = "txt_idade";
            this.txt_idade.Size = new System.Drawing.Size(106, 20);
            this.txt_idade.TabIndex = 7;
            // 
            // btn_calcularIMC
            // 
            this.btn_calcularIMC.BackColor = System.Drawing.Color.Orange;
            this.btn_calcularIMC.Location = new System.Drawing.Point(27, 211);
            this.btn_calcularIMC.Name = "btn_calcularIMC";
            this.btn_calcularIMC.Size = new System.Drawing.Size(173, 35);
            this.btn_calcularIMC.TabIndex = 8;
            this.btn_calcularIMC.Text = "CalcularIMC";
            this.btn_calcularIMC.UseVisualStyleBackColor = false;
            this.btn_calcularIMC.Click += new System.EventHandler(this.btn_calcularIMC_Click);
            // 
            // txt_resultado
            // 
            this.txt_resultado.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txt_resultado.Location = new System.Drawing.Point(53, 263);
            this.txt_resultado.Multiline = true;
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.ReadOnly = true;
            this.txt_resultado.Size = new System.Drawing.Size(132, 41);
            this.txt_resultado.TabIndex = 9;
            this.txt_resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_enviar
            // 
            this.btn_enviar.BackColor = System.Drawing.Color.Tomato;
            this.btn_enviar.Location = new System.Drawing.Point(53, 172);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(121, 33);
            this.btn_enviar.TabIndex = 10;
            this.btn_enviar.Text = "Enviar dados";
            this.btn_enviar.UseVisualStyleBackColor = false;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(289, 316);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.txt_resultado);
            this.Controls.Add(this.btn_calcularIMC);
            this.Controls.Add(this.txt_idade);
            this.Controls.Add(this.lbl_idade);
            this.Controls.Add(this.lbl_peso);
            this.Controls.Add(this.txt_peso);
            this.Controls.Add(this.txt_altura);
            this.Controls.Add(this.lbl_altura);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_nome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_altura;
        private System.Windows.Forms.TextBox txt_altura;
        private System.Windows.Forms.TextBox txt_peso;
        private System.Windows.Forms.Label lbl_peso;
        private System.Windows.Forms.Label lbl_idade;
        private System.Windows.Forms.TextBox txt_idade;
        private System.Windows.Forms.Button btn_calcularIMC;
        private System.Windows.Forms.TextBox txt_resultado;
        private System.Windows.Forms.Button btn_enviar;
    }
}

