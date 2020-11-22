using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using jogos.Ecommerce.Dados.Entity.Context;
using jogos.Ecommerce.Dominio;
using jogos.Ecommerce.Repositorios.Comum;
using jogos.Ecommerce.Repositorios.Entity;
using jogos.Ecommerce.Web.ViewModel.Plataforma;

namespace jogos.Ecommerce.Web.Controllers
{
    public class PlataformasController : Controller
    {
        private IRepositorioGenerico<Plataforma, long>
            repositorioPlataformas = new PlataformaRepositorio(new JogoDbContext());

        //private IRepositorioGenerico<FichaTecnica, int>
          //  repositorioFichaTecnica = new FichaTecnicaRepositorio(new JogoDbContext());

        // GET: Plataformas
        public ActionResult Index()
        {
            return View(Mapper.Map<List<Plataforma>,List<PlataformaIndexViewModel>>(repositorioPlataformas.Selecionar()));
        }

        // GET: Plataformas/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Plataforma plataforma = repositorioPlataformas.SelecionarPorId(id.Value);
            if (plataforma == null)
            {
                return HttpNotFound();
            }
            return View(Mapper.Map<Plataforma, PlataformaIndexViewModel>(plataforma));
        }

        // GET: Plataformas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Plataformas/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdPlataforma,NomePlataforma")] PlataformaViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Plataforma plataforma = Mapper.Map<PlataformaViewModel, Plataforma>(viewModel);
                repositorioPlataformas.Inserir(plataforma);
                return RedirectToAction("Index");
            }

            return View(viewModel);
        }

        // GET: Plataformas/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Plataforma plataforma = repositorioPlataformas.SelecionarPorId(id.Value);
            if (plataforma == null)
            {
                return HttpNotFound();
            }
            return View(Mapper.Map<Plataforma, PlataformaViewModel>(plataforma));
        }

        // POST: Plataformas/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdPlataforma,NomePlataforma")] PlataformaViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Plataforma plataforma = Mapper.Map<PlataformaViewModel, Plataforma>(viewModel);
                repositorioPlataformas.Alterar(plataforma);
                return RedirectToAction("Index");
            }
            return View(viewModel);
        }

        // GET: Plataformas/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Plataforma plataforma = repositorioPlataformas.SelecionarPorId(id.Value);
            if (plataforma == null)
            {
                return HttpNotFound();
            }
            return View(Mapper.Map<Plataforma, PlataformaIndexViewModel>(plataforma));
        }

        // POST: Plataformas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            repositorioPlataformas.ExcluirPorId(id);
            return RedirectToAction("Index");
        }
    }
}
