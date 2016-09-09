using Financeiro.Dao;
using Financeiro.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Financeiro.Controllers
{
    public class MovimentacaoController : Controller
    {
        private MovimentacaoDao movimentacaoDao;
        private UsuarioDao usuarioDao;
        public MovimentacaoController(MovimentacaoDao movimentacaoDAO, UsuarioDao usuarioDAO)
        {
            this.movimentacaoDao = movimentacaoDAO;
            this.usuarioDao = usuarioDAO;
        }

        // GET: Movimentacao
        public ActionResult Index()
        {
            return View(movimentacaoDao.Lista());
        }

        public ActionResult Form()
        {
            ViewBag.Usuarios = usuarioDao.Lista();
            return View();
        }

        public ActionResult Adiciona(Movimentacao movimentacao)
        {
            if (ModelState.IsValid)
            {
                movimentacaoDao.Adiciona(movimentacao);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Usuarios = usuarioDao.Lista();
                return View("Form");
            }
        }
    }
}