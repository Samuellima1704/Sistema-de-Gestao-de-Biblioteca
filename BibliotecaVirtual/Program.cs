using BibliotecaVirtual;

class Program
{
    static void Main(string[] args)
    {
        var acervo = new List<Livro>
        {
            new LivroFisico("C# Básico", "João Silva", 50.00m, 5),
            new LivroFisico("Introdução à Programação", "Ana Souza", 60.00m, 3),
            new Ebook("C# Avançado", "Carlos Pereira", 30.00m, "PDF"),
            new Ebook("Padrões de Projeto", "Maria Clara", 40.00m, "EPUB")
        };

        Usuario usuario = new Usuario("Maria");
        MenuBiblioteca.Menu(acervo, usuario);
    }
}