using EmprestimoLivros.DATA.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmprestimoLivros.DATA.Services
{
    public class ClienteService
    {
        public RepositoryCliente oRepositoryCliente { get; set; }

        public ClienteService()
        {
            oRepositoryCliente = new RepositoryCliente();
        }
    }
}
