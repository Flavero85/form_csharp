namespace teste2
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
            this.txt_nome = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txt_cep = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txt_cidade = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txt_numero = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBox7 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_nome
            // 
            this.txt_nome.AutoSize = true;
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.Location = new System.Drawing.Point(77, 49);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(75, 25);
            this.txt_nome.TabIndex = 0;
            this.txt_nome.Text = "Nome:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(157, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_email
            // 
            this.txt_email.AutoSize = true;
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(81, 88);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(72, 25);
            this.txt_email.TabIndex = 2;
            this.txt_email.Text = "Email:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(157, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(187, 26);
            this.textBox2.TabIndex = 3;
            // 
            // txt_cep
            // 
            this.txt_cep.AutoSize = true;
            this.txt_cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cep.Location = new System.Drawing.Point(88, 133);
            this.txt_cep.Name = "txt_cep";
            this.txt_cep.Size = new System.Drawing.Size(63, 25);
            this.txt_cep.TabIndex = 4;
            this.txt_cep.Text = "CEP:";
            this.txt_cep.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(157, 134);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(187, 26);
            this.textBox3.TabIndex = 5;
            // 
            // txt_cidade
            // 
            this.txt_cidade.AutoSize = true;
            this.txt_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cidade.Location = new System.Drawing.Point(69, 175);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(88, 25);
            this.txt_cidade.TabIndex = 6;
            this.txt_cidade.Text = "Cidade:";
            this.txt_cidade.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(157, 173);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(187, 26);
            this.textBox4.TabIndex = 7;
            // 
            // txt_numero
            // 
            this.txt_numero.AutoSize = true;
            this.txt_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numero.Location = new System.Drawing.Point(64, 217);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(94, 25);
            this.txt_numero.TabIndex = 8;
            this.txt_numero.Text = "Numero:";
            this.txt_numero.Click += new System.EventHandler(this.txt_numero_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(157, 218);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(57, 26);
            this.textBox5.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Idade:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(0, 0);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 26);
            this.textBox6.TabIndex = 11;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(-33, -67);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Size = new System.Drawing.Size(150, 100);
            this.splitContainer1.TabIndex = 12;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(157, 257);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(187, 26);
            this.textBox7.TabIndex = 13;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txt_cidade);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txt_cep);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt_nome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_nome;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txt_email;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label txt_cep;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label txt_cidade;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label txt_numero;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBox7;
    }
}

