using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual
{
    public interface IEmprestavel
    {
        void Emprestar(Usuario usuario); // Implementa a lógica de empréstimo
    }
}
