using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual
{
    public class Ebook : Livro, IVendavel
    {
        public string Formato { get; private set; } // Por exemplo, PDF ou EPUB

        public Ebook(string titulo, string autor, decimal preco, string formato)
            : base(titulo, autor, preco)
        {
            Formato = formato;
        }

        //Nesse caso, o exibir detalhes contempla o formato, mas não o estoque
        public override void ExibirDetalhes()
        {
            Console.WriteLine($"Ebook: {Titulo}, Autor: {Autor}, Preço: R${Preco}, Formato: {Formato}");
        }

        //Implementação da interface vendavel
        public void Vender()
        {
            Console.WriteLine($"{Titulo} vendido em formato {Formato}.");
        }
    }
}
