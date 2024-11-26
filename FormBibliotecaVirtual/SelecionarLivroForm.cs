using BibliotecaVirtual;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormBibliotecaVirtual
{
    public partial class SelecionarLivroForm : Form
    {
        public Livro LivroSelecionado { get; private set; }

        public SelecionarLivroForm(List<Livro> livros)
        {
            InitializeComponent();

            if (livros == null || livros.Count == 0)
            {
                MessageBox.Show("Nenhum livro disponível para seleção.", "Aviso");
                DialogResult = DialogResult.Cancel;
                Close();
                return;
            }

            // Vincular a lista de livros ao ListBox
            listBoxLivros.Tag = livros; // Certifique-se de que "Tag" recebe os livros.
            foreach (var livro in livros)
            {
                listBoxLivros.Items.Add(livro.Titulo); // Adiciona os títulos ao ListBox.
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (listBoxLivros.SelectedIndex >= 0)
            {
                var livros = (List<Livro>)listBoxLivros.Tag;
                LivroSelecionado = livros[listBoxLivros.SelectedIndex]; // Seleciona o livro correto.
                DialogResult = DialogResult.OK; // Retorna OK ao formulário principal.
                Close();
            }
            else
            {
                MessageBox.Show("Por favor, selecione um livro antes de continuar.", "Aviso");
            }
        }
    }
}
