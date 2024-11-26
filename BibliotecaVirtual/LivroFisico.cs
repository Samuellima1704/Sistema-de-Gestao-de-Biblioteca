using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual
{
    public class LivroFisico : Livro, IVendavel, IEmprestavel
    {
        public int Estoque { get; private set; }

        public LivroFisico(string titulo, string autor, decimal preco, int estoque)
            : base(titulo, autor, preco)
        {
            Estoque = estoque;
        }

        //Por que usar classes abstratas?
        //Como pode ver, aqui faz sentido, a implementação de exibir detalhes varia para as classes que a implementam
        //Nesse caso, exibir detalhes também exibe o estoque, que não tem no e-book
        public override void ExibirDetalhes()
        {
            Console.WriteLine($"Livro Físico: {Titulo}, Autor: {Autor}, Preço: R${Preco}, Estoque: {Estoque}");
        }

        public void ReduzirEstoque()
        {
            if (Estoque > 0) Estoque--;
        }

        //Implementação da interface vendavel
        public void Vender()
        {
            if (Estoque > 0)
            {
                ReduzirEstoque();
                Console.WriteLine($"{Titulo} vendido.");
            }
            else
            {
                Console.WriteLine("Estoque esgotado.");
            }
        }

        //Implementação da interface emprestavel
        public void Emprestar(Usuario usuario)
        {
            if (Estoque > 0)
            {
                ReduzirEstoque();
                usuario.AdicionarEmprestimo(new Emprestimo(usuario, this));
                Console.WriteLine($"{Titulo} emprestado a {usuario.Nome}.");
            }
            else
            {
                Console.WriteLine("Livro indisponível para empréstimo.");
            }
        }
    }
}