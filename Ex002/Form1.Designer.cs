namespace Ex002
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
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.lbl_meu = new System.Windows.Forms.Label();
            this.lbl_brasil = new System.Windows.Forms.Label();
            this.lbl_brasileiro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iniciar.Location = new System.Drawing.Point(102, 129);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(130, 38);
            this.btn_iniciar.TabIndex = 0;
            this.btn_iniciar.Text = "INICIAR";
            this.btn_iniciar.UseVisualStyleBackColor = true;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // lbl_meu
            // 
            this.lbl_meu.BackColor = System.Drawing.Color.Transparent;
            this.lbl_meu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_meu.ForeColor = System.Drawing.Color.Black;
            this.lbl_meu.Location = new System.Drawing.Point(34, 50);
            this.lbl_meu.Name = "lbl_meu";
            this.lbl_meu.Size = new System.Drawing.Size(59, 33);
            this.lbl_meu.TabIndex = 1;
            this.lbl_meu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_brasil
            // 
            this.lbl_brasil.BackColor = System.Drawing.Color.Transparent;
            this.lbl_brasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_brasil.ForeColor = System.Drawing.Color.Black;
            this.lbl_brasil.Location = new System.Drawing.Point(98, 51);
            this.lbl_brasil.Name = "lbl_brasil";
            this.lbl_brasil.Size = new System.Drawing.Size(90, 33);
            this.lbl_brasil.TabIndex = 1;
            this.lbl_brasil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_brasileiro
            // 
            this.lbl_brasileiro.BackColor = System.Drawing.Color.Transparent;
            this.lbl_brasileiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_brasileiro.ForeColor = System.Drawing.Color.Black;
            this.lbl_brasileiro.Location = new System.Drawing.Point(194, 51);
            this.lbl_brasileiro.Name = "lbl_brasileiro";
            this.lbl_brasileiro.Size = new System.Drawing.Size(124, 33);
            this.lbl_brasileiro.TabIndex = 1;
            this.lbl_brasileiro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 229);
            this.Controls.Add(this.lbl_brasileiro);
            this.Controls.Add(this.lbl_brasil);
            this.Controls.Add(this.lbl_meu);
            this.Controls.Add(this.btn_iniciar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brasil";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.Label lbl_meu;
        private System.Windows.Forms.Label lbl_brasil;
        private System.Windows.Forms.Label lbl_brasileiro;
    }
}

