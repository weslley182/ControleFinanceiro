using Financeiro.Dao;
using Financeiro.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Financeiro.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Form()
        {
            return View();
        }

        private UsuarioDao usuarioDao;

        public UsuarioController(UsuarioDao usuarioDao)
        {
            this.usuarioDao = usuarioDao;
        }

        public ActionResult Adiciona(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                usuarioDao.Adiciona(usuario);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Form", usuario);
            }
        }

        public ActionResult Index()
        {
            return View(usuarioDao.Lista());
        }
    }
}