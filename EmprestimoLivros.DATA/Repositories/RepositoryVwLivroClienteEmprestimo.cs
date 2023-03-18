using EmprestimoLivros.DATA.Interfaces;
using EmprestimoLivros.DATA.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmprestimoLivros.DATA.Repositories
{
    public class RepositoryVwLivroClienteEmprestimo : RepositoryBase<VwLivroClienteEmprestimo>, IRepositoryVwLivroClienteEmprestimo
    {
        public RepositoryVwLivroClienteEmprestimo(bool SaveChanges = true) : base(SaveChanges)
        {

        }

    }
}
