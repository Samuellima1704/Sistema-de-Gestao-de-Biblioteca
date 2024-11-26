using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual
{
    public class Emprestimo
    {
        public Usuario Usuario { get; private set; }
        public Livro LivroEmprestado { get; private set; }
        public DateTime DataEmprestimo { get; private set; }

        public Emprestimo(Usuario usuario, Livro livro)
        {
            Usuario = usuario;
            LivroEmprestado = livro;
            DataEmprestimo = DateTime.Now;
        }

        public string ExibirDetalhes()
        {
            return $"[blue]{Usuario.Nome}[/] emprestou [bold]{LivroEmprestado.Titulo}[/] em {DataEmprestimo.ToShortDateString()}";
        }
    }

}
