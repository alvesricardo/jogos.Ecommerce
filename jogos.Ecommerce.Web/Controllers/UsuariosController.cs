﻿using jogos.Ecommerce.Dados.Entity.Context;
using jogos.Ecommerce.Web.Identity;
using jogos.Ecommerce.Web.ViewModel.Usuarios;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace jogos.Ecommerce.Web.Controllers
{
    public class UsuariosController : Controller
    {
        // GET: Usuarios
        public ActionResult CriarUsuario()
        {
            return View();
        }

        //POST: Usuarios
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CriarUsuario(UsuarioViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var userStore = new UserStore<IdentityUser>(new JogoIdentityDbContext());
                var userManager = new UserManager<IdentityUser>(userStore);
                var IdentityUser = new IdentityUser
                {
                    UserName = viewModel.Email,
                    Email = viewModel.Email,
                };
                IdentityResult resultado = userManager.Create(IdentityUser, viewModel.Senha) ;
                if (resultado.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("erro_identity", resultado.Errors.First());
                    return View(viewModel);
                }
            }
            return View(viewModel);
        }

        //GET
        public ActionResult Login()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(UsuarioViewModel viewModel)
        {
            if (ModelState.IsValid)
            {

            }
            return View(viewModel);
        }
    }
}