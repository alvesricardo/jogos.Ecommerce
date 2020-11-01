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
using jogos.Ecommerce.Web.ViewModel.FichaTecnica;

namespace jogos.Ecommerce.Web.Controllers
{
    public class FichaTecnicaController : Controller
    {
        private JogoDbContext db = new JogoDbContext();

        // GET: FichaTecnica
        public ActionResult Index()
        {
            return View(Mapper.Map<List<FichaTecnica>, List<FichaTecnicaIndexViewModel>>(db.ficha.ToList()));
        }

        // GET: FichaTecnica/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FichaTecnica fichaTecnica = db.ficha.Find(id);
            if (fichaTecnica == null)
            {
                return HttpNotFound();
            }
            return View(Mapper.Map<FichaTecnica, FichaTecnicaIndexViewModel>(fichaTecnica));
        }

        // GET: FichaTecnica/Create
        public ActionResult Create()
        {
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
                db.ficha.Add(fichaTecnica);
                db.SaveChanges();
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
            FichaTecnica fichaTecnica = db.ficha.Find(id);
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
                db.Entry(fichaTecnica).State = EntityState.Modified;
                db.SaveChanges();
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
            FichaTecnica fichaTecnica = db.ficha.Find(id);
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
            FichaTecnica fichaTecnica = db.ficha.Find(id);
            db.ficha.Remove(fichaTecnica);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
