using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectre.Console;

namespace BibliotecaVirtual
{
    internal class MenuBiblioteca
    {
        // Método principal para o loop do menu, nessa parte eu usei o SpectreConsole, uma biblioteca para menu de aplicações de console
        // Não precisa entender tudo
        public static void Menu(List<Livro> acervo, Usuario usuario)
        {
            while (true)
            {
                // Limpar a tela antes de exibir o menu
                Console.Clear();

                // Exibir menu com opções
                var escolha = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                        .Title("[green]Bem-vindo à Biblioteca Virtual![/]")
                        .PageSize(5)
                        .AddChoices(new[] {
                    "Listar Livros",
                    "Comprar Livro",
                    "Pegar Livro Emprestado",
                    "Ver Histórico de Empréstimos",
                    "Sair"
                        }));

                switch (escolha)
                {
                    case "Listar Livros":
                        Console.Clear(); // Limpa a tela antes de listar os livros
                        AnsiConsole.MarkupLine("\n[bold yellow]--- Acervo de Livros ---[/]");
                        foreach (var livro in acervo)
                        {
                            livro.ExibirDetalhes();
                        }
                        AnsiConsole.MarkupLine("\n[grey]Pressione qualquer tecla para voltar ao menu...[/]");
                        Console.ReadKey();
                        break;

                    case "Comprar Livro":
                        Console.Clear(); // Limpa a tela antes de exibir a compra
                        ComprarLivro(acervo);
                        AnsiConsole.MarkupLine("\n[grey]Pressione qualquer tecla para voltar ao menu...[/]");
                        Console.ReadKey();
                        break;

                    case "Pegar Livro Emprestado":
                        Console.Clear(); // Limpa a tela antes de exibir empréstimos
                        EmprestarLivro(acervo, usuario);
                        AnsiConsole.MarkupLine("\n[grey]Pressione qualquer tecla para voltar ao menu...[/]");
                        Console.ReadKey();
                        break;

                    case "Ver Histórico de Empréstimos":
                        Console.Clear(); // Limpa a tela antes de exibir o histórico
                        ExibirHistorico(usuario);
                        AnsiConsole.MarkupLine("\n[grey]Pressione qualquer tecla para voltar ao menu...[/]");
                        Console.ReadKey();
                        break;

                    case "Sair":
                        Console.Clear();
                        AnsiConsole.MarkupLine("[bold red]Saindo da aplicação... Até logo![/]");
                        return;
                }
            }
        }

        // Função para comprar livro
        static void ComprarLivro(List<Livro> acervo)
        {
            //Buscando todos os livros vendaveis, mais uma utilidade de se usar interfaces!!
            var livrosVendaveis = acervo.FindAll(l => l is IVendavel);

            if (livrosVendaveis.Count == 0)
            {
                AnsiConsole.MarkupLine("[red]Não há livros disponíveis para venda![/]");
                return;
            }

            var escolha = AnsiConsole.Prompt(
                new SelectionPrompt<Livro>()
                    .Title("Selecione o [green]livro[/] para comprar:")
                    .UseConverter(l => l.Titulo)
                    .AddChoices(livrosVendaveis));

            if (escolha is IVendavel vendavel)
            {
                vendavel.Vender();
            }
        }

        // Função para pegar livro emprestado
        static void EmprestarLivro(List<Livro> acervo, Usuario usuario)
        {
            var livrosEmprestaveis = acervo.FindAll(l => l is IEmprestavel);

            if (livrosEmprestaveis.Count == 0)
            {
                AnsiConsole.MarkupLine("[red]Não há livros disponíveis para empréstimo![/]");
                return;
            }

            var escolha = AnsiConsole.Prompt(
                new SelectionPrompt<Livro>()
                    .Title("Selecione o [green]livro físico[/] para empréstimo:")
                    .UseConverter(l => l.Titulo)
                    .AddChoices(livrosEmprestaveis));

            if (escolha is IEmprestavel emprestavel)
            {
                emprestavel.Emprestar(usuario);
            }
        }

        // Função para exibir histórico de empréstimos
        static void ExibirHistorico(Usuario usuario)
        {
            AnsiConsole.MarkupLine("[bold yellow]--- Histórico de Empréstimos ---[/]");

            if (usuario.HistoricoEmprestimos.Count == 0)
            {
                AnsiConsole.MarkupLine("[red]Nenhum empréstimo realizado![/]");
            }
            else
            {
                foreach (var emprestimo in usuario.HistoricoEmprestimos)
                {
                    AnsiConsole.MarkupLine(emprestimo.ExibirDetalhes());
                }
            }
        }

    }
}
