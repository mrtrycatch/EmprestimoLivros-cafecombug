using EmprestimoLivros.DATA.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmprestimoLivros.DATA.Services
{
    public class LivroService
    {
        public RepositoryLivro oRepositoryLivro { get; set; }

        public LivroService()
        {
            oRepositoryLivro = new RepositoryLivro();
        }
    }
}
