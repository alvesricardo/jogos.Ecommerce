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
using jogos.Ecommerce.Web.ViewModel.FichaTecnica;
using jogos.Ecommerce.Web.ViewModel.Plataforma;

namespace jogos.Ecommerce.Web.Controllers
{
    public class FichaTecnicaController : Controller
    {
        private IRepositorioGenerico<FichaTecnica, int>
             repositorioFichaTecnica = new FichaTecnicaRepositorio(new JogoDbContext());

        private IRepositorioGenerico<Plataforma, long>
            repositorioPlataformas = new PlataformaRepositorio(new JogoDbContext());

        // GET: FichaTecnica
        public ActionResult Index()
        {
            return View(Mapper.Map<List<FichaTecnica>, List<FichaTecnicaIndexViewModel>>(repositorioFichaTecnica.Selecionar()));
        }


        public ActionResult FiltarPorNome(String Pesquisa)
        {
            List<FichaTecnica> fichaTecnicas = repositorioFichaTecnica.Selecionar().Where(a => a.Nome.Contains(Pesquisa)).ToList();
            List<FichaTecnicaIndexViewModel> viewModels = Mapper.Map<List<FichaTecnica>, List<FichaTecnicaIndexViewModel>>(fichaTecnicas);

            return Json(viewModels, JsonRequestBehavior.AllowGet);
        }

        // GET: FichaTecnica/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FichaTecnica fichaTecnica = repositorioFichaTecnica.SelecionarPorId(id.Value);
            if (fichaTecnica == null)
            {
                return HttpNotFound();
            }
            return View(Mapper.Map<FichaTecnica, FichaTecnicaIndexViewModel>(fichaTecnica));
        }

        // GET: FichaTecnica/Create
        public ActionResult Create()
        {
            List<PlataformaIndexViewModel> plataformas = Mapper.Map<List<Plataforma>, List<PlataformaIndexViewModel>>(repositorioPlataformas.Selecionar());

            SelectList dropDownPlataformas = new SelectList(plataformas, "IdPlataforma", "NomePlataforma");

            ViewBag.DropDownPlataformas = dropDownPlataformas;
            
            return View();
        }

        // POST: FichaTecnica/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,Desenvolvedora,Publicadora,AnoLancamento,Plataforma,Genero,Enredo,Email")] FichaTecnicaViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                FichaTecnica fichaTecnica = Mapper.Map<FichaTecnicaViewModel, FichaTecnica>(viewModel);
                repositorioFichaTecnica.Inserir(fichaTecnica);
                return RedirectToAction("Index");
            }

            return View(viewModel);
        }

        // GET: FichaTecnica/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FichaTecnica fichaTecnica = repositorioFichaTecnica.SelecionarPorId(id.Value);
            if (fichaTecnica == null)
            {
                return HttpNotFound();
            }
            return View(Mapper.Map<FichaTecnica, FichaTecnicaViewModel>(fichaTecnica));
        }

        // POST: FichaTecnica/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,Desenvolvedora,Publicadora,AnoLancamento,Plataforma,Genero,Enredo,Email")] FichaTecnicaViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                FichaTecnica fichaTecnica = Mapper.Map<FichaTecnicaViewModel, FichaTecnica>(viewModel);
                repositorioFichaTecnica.Alterar(fichaTecnica);
                return RedirectToAction("Index");
            }
            return View(viewModel);
        }

        // GET: FichaTecnica/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FichaTecnica fichaTecnica = repositorioFichaTecnica.SelecionarPorId(id.Value);
            if (fichaTecnica == null)
            {
                return HttpNotFound();
            }
            return View(Mapper.Map<FichaTecnica, FichaTecnicaIndexViewModel>(fichaTecnica));
        }

        // POST: FichaTecnica/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            repositorioFichaTecnica.ExcluirPorId(id);
            return RedirectToAction("Index");
        }
    }
}
