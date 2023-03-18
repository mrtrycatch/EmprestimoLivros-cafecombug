using EmprestimoLivros.DATA.Models;
using EmprestimoLivros.DATA.Services;
using EmprestimoLivros.WEB.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmprestimoLivros.WEB.Controllers
{
    public class EmprestimosController : Controller
    {
        private LivroClienteEmprestimoService _service = new LivroClienteEmprestimoService();
        public IActionResult Index()
        {
            List<VwLivroClienteEmprestimo> oListVwLivroClienteEmprestimo = _service.oRepositoryVwLivroClienteEmprestimo.SelecionarTodos();
            return View(oListVwLivroClienteEmprestimo);
        }

        public IActionResult Create()
        {
            EmprestimoViewModel oEmprestimoViewModel = new EmprestimoViewModel();
            List<Livro> oListLivro = _service.oRepositoryLivro.SelecionarTodos();
            List<Cliente> oListCLiente = _service.oRepositoryCliente.SelecionarTodos();

            oEmprestimoViewModel.oListCliente = oListCLiente;
            oEmprestimoViewModel.oListLivro = oListLivro;

            oEmprestimoViewModel.oLivroClienteEmprestimo = new LivroClienteEmprestimo();

            oEmprestimoViewModel.oLivroClienteEmprestimo.LceDataEmprestimo = DateTime.Now;
            oEmprestimoViewModel.oLivroClienteEmprestimo.LceDataEntrega = DateTime.Now.AddDays(7);


            return View(oEmprestimoViewModel);
        }

        [HttpPost]
        public IActionResult Create(LivroClienteEmprestimo oLivroClienteEmprestimo)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }

            _service.oRepositoryLivroClienteEmprestimo.Incluir(oLivroClienteEmprestimo);

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            EmprestimoViewModel oEmprestimoViewModel = new EmprestimoViewModel();

            oEmprestimoViewModel.oListCliente = _service.oRepositoryCliente.SelecionarTodos();
            oEmprestimoViewModel.oListLivro = _service.oRepositoryLivro.SelecionarTodos();

            LivroClienteEmprestimo oLivroClienteEmprestimo = _service.oRepositoryLivroClienteEmprestimo.SelecionarPK(id);
            oEmprestimoViewModel.oLivroClienteEmprestimo = oLivroClienteEmprestimo;


            return View(oEmprestimoViewModel);
        }
        [HttpPost]
        public IActionResult Edit(EmprestimoViewModel oEmprestimoViewModel)
        {
            if (!ModelState.IsValid)
            {
                oEmprestimoViewModel.oListCliente = _service.oRepositoryCliente.SelecionarTodos();
                oEmprestimoViewModel.oListLivro = _service.oRepositoryLivro.SelecionarTodos();
                return View(oEmprestimoViewModel);
            }


            _service.oRepositoryLivroClienteEmprestimo.Alterar(oEmprestimoViewModel.oLivroClienteEmprestimo);

            return RedirectToAction("Index");
        }

       
    }
}
