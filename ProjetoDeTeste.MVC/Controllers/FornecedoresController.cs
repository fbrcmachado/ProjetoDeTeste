using AutoMapper;
using ProjetoDeTeste.AppService.Interfaces;
using ProjetoDeTeste.Domain.Entities;
using ProjetoDeTeste.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoDeTeste.MVC.Controllers
{
    public class FornecedoresController : Controller
    {
        private readonly IFornecedoresAppService _fornecedoresApp;

        public FornecedoresController(IFornecedoresAppService fornecedoresApp)
        {
            _fornecedoresApp = fornecedoresApp;
        }
        // GET: Fornecedores
        public ActionResult Index()
        {
            var fornecedoresViewModel = Mapper.Map<IEnumerable<Fornecedores>, IEnumerable<FornecedoresViewModel>>(_fornecedoresApp.GetAll());
            return View(fornecedoresViewModel);
        }

        // GET: Fornecedores/Details/5
        public ActionResult Details(int id)
        {
            var fornecedores = _fornecedoresApp.GetById(id);
            var fornecedoresViewModel = Mapper.Map<Fornecedores, FornecedoresViewModel>(fornecedores);
            return View(fornecedoresViewModel);
        }



        // POST: Fornecedores/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FornecedoresViewModel fornecedores)
        {
            if (ModelState.IsValid)
            {
                var fornecedoresDomain = Mapper.Map<FornecedoresViewModel, Fornecedores>(fornecedores);
                _fornecedoresApp.Add(fornecedoresDomain);
                return RedirectToAction("Index");
            }

            return View(fornecedores);
        }

        public ActionResult Create()
        {
            return View();
        }



        // GET: Cliente/Edit/5

        public ActionResult Edit(int id)
        {
            var fornecedores = _fornecedoresApp.GetById(id);
            var fornecedoresViewModel = Mapper.Map<Fornecedores, FornecedoresViewModel>(fornecedores);
            return View(fornecedoresViewModel);
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(FornecedoresViewModel produto)
        {
            if (ModelState.IsValid)
            {
                var fornecedoresDomain = Mapper.Map<FornecedoresViewModel, Fornecedores>(produto);
                _fornecedoresApp.Update(fornecedoresDomain);
                return RedirectToAction("Index");
            }

            return View(produto);
        }

        // GET: Cliente/Delete/5
        public ActionResult Delete(int id)
        {
            var fornecedores = _fornecedoresApp.GetById(id);
            var fornecedoresViewModel = Mapper.Map<Fornecedores, FornecedoresViewModel>(fornecedores);
            return View(fornecedoresViewModel);
        }

        // POST: Cliente/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var fornecedores = _fornecedoresApp.GetById(id);
            _fornecedoresApp.Remove(fornecedores);
            return RedirectToAction("Index");
        }
    }
}
