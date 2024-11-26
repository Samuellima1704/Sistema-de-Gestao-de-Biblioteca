namespace FormBibliotecaVirtual
{
    partial class SelecionarLivroForm
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
            this.listBoxLivros = new System.Windows.Forms.ListBox();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxLivros
            // 
            this.listBoxLivros.FormattingEnabled = true;
            this.listBoxLivros.ItemHeight = 16;
            this.listBoxLivros.Location = new System.Drawing.Point(12, 12);
            this.listBoxLivros.Name = "listBoxLivros";
            this.listBoxLivros.Size = new System.Drawing.Size(310, 196);
            this.listBoxLivros.TabIndex = 0;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(115, 225);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(100, 30);
            this.btnSelecionar.TabIndex = 1;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // SelecionarLivroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 281);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.listBoxLivros);
            this.Name = "SelecionarLivroForm";
            this.Text = "Selecionar Livro";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox listBoxLivros;
        private System.Windows.Forms.Button btnSelecionar;
    }
}