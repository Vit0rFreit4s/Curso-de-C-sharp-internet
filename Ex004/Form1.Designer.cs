namespace Ex004
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
            this.btn_ok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.lbl_inteiro = new System.Windows.Forms.Label();
            this.lbl_arredondado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.Location = new System.Drawing.Point(287, 34);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(72, 41);
            this.btn_ok.TabIndex = 0;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite um número Real";
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(199, 47);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(59, 20);
            this.txt_num.TabIndex = 2;
            this.txt_num.TextChanged += new System.EventHandler(this.txt_num_TextChanged);
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor.Location = new System.Drawing.Point(39, 112);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(0, 20);
            this.lbl_valor.TabIndex = 3;
            this.lbl_valor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_inteiro
            // 
            this.lbl_inteiro.AutoSize = true;
            this.lbl_inteiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inteiro.Location = new System.Drawing.Point(39, 155);
            this.lbl_inteiro.Name = "lbl_inteiro";
            this.lbl_inteiro.Size = new System.Drawing.Size(0, 20);
            this.lbl_inteiro.TabIndex = 3;
            this.lbl_inteiro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_inteiro.Click += new System.EventHandler(this.lbl_inteiro_Click);
            // 
            // lbl_arredondado
            // 
            this.lbl_arredondado.AutoSize = true;
            this.lbl_arredondado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_arredondado.Location = new System.Drawing.Point(39, 195);
            this.lbl_arredondado.Name = "lbl_arredondado";
            this.lbl_arredondado.Size = new System.Drawing.Size(0, 20);
            this.lbl_arredondado.TabIndex = 3;
            this.lbl_arredondado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 280);
            this.Controls.Add(this.lbl_arredondado);
            this.Controls.Add(this.lbl_inteiro);
            this.Controls.Add(this.lbl_valor);
            this.Controls.Add(this.txt_num);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analizador de Números";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.Label lbl_inteiro;
        private System.Windows.Forms.Label lbl_arredondado;
    }
}

