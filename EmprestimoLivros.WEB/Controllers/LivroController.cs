using EmprestimoLivros.DATA.Models;
using EmprestimoLivros.DATA.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmprestimoLivros.WEB.Controllers
{
    public class LivroController : Controller
    {
        private LivroService oLivroService = new LivroService();
        public IActionResult Index()
        {
            List<Livro> oListLivro = oLivroService.oRepositoryLivro.SelecionarTodos();
            return View(oListLivro);
        }

        public IActionResult Create()
        {

            return View();
        }

        [AutoValidateAntiforgeryToken]
        [HttpPost]
        public IActionResult Create(Livro model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            oLivroService.oRepositoryLivro.Incluir(model);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            Livro oLivro = oLivroService.oRepositoryLivro.SelecionarPK(id);
            ViewBag.anoPublicacao = oLivro.LivroAnoPublicacao.Year;
            return View(oLivro);
        }

        [AutoValidateAntiforgeryToken]
        [HttpPost]
        public IActionResult Edit(Livro model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            oLivroService.oRepositoryLivro.Alterar(model);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Livro oLivro = oLivroService.oRepositoryLivro.SelecionarPK(id);
            ViewBag.anoPublicacao = oLivro.LivroAnoPublicacao.Year;
            return View(oLivro);
        }

        public IActionResult Delete(int id)
        {
            oLivroService.oRepositoryLivro.Excluir(id);
            return RedirectToAction("Index");
        }
    }
}

