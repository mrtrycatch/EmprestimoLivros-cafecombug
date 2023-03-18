using EmprestimoLivros.DATA.Interfaces;
using EmprestimoLivros.DATA.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmprestimoLivros.DATA.Repositories
{
    public class RepositoryLivro : RepositoryBase<Livro>, IRepositoryLivro
    {
        public RepositoryLivro(bool SaveChanges = true) : base(SaveChanges)
        {

        }

    }
}
