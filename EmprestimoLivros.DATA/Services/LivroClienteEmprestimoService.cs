using EmprestimoLivros.DATA.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmprestimoLivros.DATA.Services
{
    public class LivroClienteEmprestimoService
    {
        public RepositoryVwLivroClienteEmprestimo oRepositoryVwLivroClienteEmprestimo { get; set; }
        public RepositoryLivro oRepositoryLivro { get; set; }
        public RepositoryCliente oRepositoryCliente { get; set; }

        public RepositoryLivroClienteEmprestimo oRepositoryLivroClienteEmprestimo { get; set; }

        public LivroClienteEmprestimoService()
        {
            oRepositoryVwLivroClienteEmprestimo = new RepositoryVwLivroClienteEmprestimo();
            oRepositoryCliente = new RepositoryCliente();
            oRepositoryLivro = new RepositoryLivro();
            oRepositoryLivroClienteEmprestimo = new RepositoryLivroClienteEmprestimo();
        }
    }
}
