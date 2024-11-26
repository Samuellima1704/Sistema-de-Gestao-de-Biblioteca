namespace FormBibliotecaVirtual
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnListarLivros = new System.Windows.Forms.Button();
            this.btnComprarLivro = new System.Windows.Forms.Button();
            this.btnEmprestarLivro = new System.Windows.Forms.Button();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListarLivros
            // 
            this.btnListarLivros.Location = new System.Drawing.Point(12, 12);
            this.btnListarLivros.Name = "btnListarLivros";
            this.btnListarLivros.Size = new System.Drawing.Size(200, 40);
            this.btnListarLivros.TabIndex = 0;
            this.btnListarLivros.Text = "Listar Livros";
            this.btnListarLivros.UseVisualStyleBackColor = true;
            this.btnListarLivros.Click += new System.EventHandler(this.btnListarLivros_Click);
            // 
            // btnComprarLivro
            // 
            this.btnComprarLivro.Location = new System.Drawing.Point(12, 58);
            this.btnComprarLivro.Name = "btnComprarLivro";
            this.btnComprarLivro.Size = new System.Drawing.Size(200, 40);
            this.btnComprarLivro.TabIndex = 1;
            this.btnComprarLivro.Text = "Comprar Livro";
            this.btnComprarLivro.UseVisualStyleBackColor = true;
            this.btnComprarLivro.Click += new System.EventHandler(this.btnComprarLivro_Click);
            // 
            // btnEmprestarLivro
            // 
            this.btnEmprestarLivro.Location = new System.Drawing.Point(12, 104);
            this.btnEmprestarLivro.Name = "btnEmprestarLivro";
            this.btnEmprestarLivro.Size = new System.Drawing.Size(200, 40);
            this.btnEmprestarLivro.TabIndex = 2;
            this.btnEmprestarLivro.Text = "Pegar Livro Emprestado";
            this.btnEmprestarLivro.UseVisualStyleBackColor = true;
            this.btnEmprestarLivro.Click += new System.EventHandler(this.btnEmprestarLivro_Click);
            // 
            // btnHistorico
            // 
            this.btnHistorico.Location = new System.Drawing.Point(12, 150);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(200, 40);
            this.btnHistorico.TabIndex = 3;
            this.btnHistorico.Text = "Ver Histórico";
            this.btnHistorico.UseVisualStyleBackColor = true;
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 203);
            this.Controls.Add(this.btnHistorico);
            this.Controls.Add(this.btnEmprestarLivro);
            this.Controls.Add(this.btnComprarLivro);
            this.Controls.Add(this.btnListarLivros);
            this.Name = "MainForm";
            this.Text = "Biblioteca";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnListarLivros;
        private System.Windows.Forms.Button btnComprarLivro;
        private System.Windows.Forms.Button btnEmprestarLivro;
        private System.Windows.Forms.Button btnHistorico;
    }
}
