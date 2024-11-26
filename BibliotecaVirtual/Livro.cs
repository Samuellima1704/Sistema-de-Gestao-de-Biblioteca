using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual
{
    public abstract class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        protected decimal Preco { get; set; } // Visibilidade protegida, acessível apenas para classes que a herdam

        public Livro(string titulo, string autor, decimal preco)
        {
            Titulo = titulo;
            Autor = autor;
            Preco = preco;
        }

        // Método abstrato a ser implementado pelas subclasses
        public abstract void ExibirDetalhes();
    }
}
