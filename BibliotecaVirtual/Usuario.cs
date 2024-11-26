using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual
{
    public class Usuario
    {
        public string Nome { get; private set; }
        public List<Emprestimo> HistoricoEmprestimos { get; private set; }

        public Usuario(string nome)
        {
            Nome = nome;
            HistoricoEmprestimos = new List<Emprestimo>();
        }

        public void AdicionarEmprestimo(Emprestimo emprestimo)
        {
            HistoricoEmprestimos.Add(emprestimo);
        }
    }

}
