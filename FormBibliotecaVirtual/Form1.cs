using BibliotecaVirtual;

namespace FormBibliotecaVirtual
{
    public partial class Form1 : Form
    {

        private List<Livro> acervo;
        private Usuario usuario;
        public Form1()
        {
            InitializeComponent();
            InicializarDados();
        }

        private void InicializarDados()
        {
            // Inicializar dados fictícios
            acervo = new List<Livro>
        {
            new LivroFisico("C# Básico", "João Silva", 50.00m, 10),
            new Ebook("ASP.NET Avançado", "Ana Souza", 30.00m, "EPUB"),
            new LivroFisico("Introdução ao Python", "Carlos Mendes", 45.00m, 7),
            new Ebook("Java para Web", "Mariana Costa", 40.00m, "PDF"),
            new LivroFisico("Segurança da Informação", "Roberta Lima", 70.00m, 5),
            new Ebook("Data Science com Python", "Eduardo Rocha", 35.00m, "MOBI"),
            new LivroFisico("UX Design Moderno", "Fernanda Alves", 60.00m, 8),
            new Ebook("Machine Learning Essencial", "Rafael Brito", 50.00m, "EPUB"),
            new LivroFisico("Redes de Computadores", "Vanessa Martins", 65.00m, 4),
            new Ebook("Inteligência Artificial Prática", "Lucas Azevedo", 55.00m, "PDF")
        };

            usuario = new Usuario("Carlos");
        }

        private void btnListarLivros_Click(object sender, EventArgs e)
        {
            // Exibir lista de livros em uma MessageBox ou ListBox
            var detalhes = string.Join("\n", acervo.ConvertAll(l => $"{l.Titulo} - {l.Autor}"));
            MessageBox.Show(detalhes, "Acervo de Livros");
        }

        private void btnComprarLivro_Click(object sender, EventArgs e)
        {
            var livrosVendaveis = acervo.FindAll(l => l is IVendavel);
            if (livrosVendaveis.Count == 0)
            {
                MessageBox.Show("Não há livros disponíveis para venda!", "Erro");
                return;
            }

            using (var form = new SelecionarLivroForm(livrosVendaveis))
            {
                if (form.ShowDialog() == DialogResult.OK && form.LivroSelecionado is IVendavel vendavel)
                {
                    vendavel.Vender();
                    MessageBox.Show($"Você comprou o livro: {form.LivroSelecionado.Titulo}", "Compra Realizada");
                }
            }
        }


        private void btnEmprestarLivro_Click(object sender, EventArgs e)
        {
            // Simular empréstimo de um livro
            var livrosEmprestaveis = acervo.FindAll(l => l is IEmprestavel);
            if (livrosEmprestaveis.Count == 0)
            {
                MessageBox.Show("Não há livros disponíveis para empréstimo!", "Erro");
                return;
            }

            // Exibir seleção para empréstimo
            using (var form = new SelecionarLivroForm(livrosEmprestaveis))
            {
                if (form.ShowDialog() == DialogResult.OK && form.LivroSelecionado is IEmprestavel emprestavel)
                {
                    emprestavel.Emprestar(usuario);
                    MessageBox.Show($"Você pegou emprestado o livro: {form.LivroSelecionado.Titulo}", "Empréstimo Realizado");
                }
            }
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            // Exibir histórico de empréstimos
            var historico = string.Join("\n", usuario.HistoricoEmprestimos.ConvertAll(h =>
                $"{h.LivroEmprestado.Titulo} - {h.DataEmprestimo.ToShortDateString()}"));

            MessageBox.Show(string.IsNullOrEmpty(historico) ? "Nenhum empréstimo realizado!" : historico, "Histórico de Empréstimos");
        }

    }
}
