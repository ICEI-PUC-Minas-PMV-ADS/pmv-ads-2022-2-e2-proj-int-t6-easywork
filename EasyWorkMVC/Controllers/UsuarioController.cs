using EasyWorkMVC.Helper;
using EasyWorkMVC.Models;
using EasyWorkMVC.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyWorkMVC.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }
        public IActionResult Index()
        {
            List<UsuarioModel> usuarios = _usuarioRepositorio.BuscarTodos();

            return View(usuarios);
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
            UsuarioModel usuario = _usuarioRepositorio.ListarPorId(id);
            return View(usuario);
        }

        public IActionResult ApagarConfirmacao(int id)
        {
            UsuarioModel usuario = _usuarioRepositorio.ListarPorId(id);
            return View(usuario);
        }

        public IActionResult Apagar(int id)
        {
            _usuarioRepositorio.Apagar(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Criar(UsuarioModel usuario) 
        {
            if (ModelState.IsValid)
            {
                _usuarioRepositorio.Adicionar(usuario); 
                return RedirectToAction("Index", "Login"); //"Index"
            }

            return View(usuario); //usuario
        }

        [HttpPost]
        public IActionResult Alterar(UsuarioSemSenhaModel usuarioSemSenhaModel)
        {
            UsuarioModel usuario = null;

            if (ModelState.IsValid)
            {
                usuario = new UsuarioModel()
                {
                    Id = usuarioSemSenhaModel.Id,
                    Nome = usuarioSemSenhaModel.Nome,
                    Login = usuarioSemSenhaModel.Login,
                    Email = usuarioSemSenhaModel.Email,
                    Perfil = usuarioSemSenhaModel.Perfil
                };

                _usuarioRepositorio.Atualizar(usuario);
                return RedirectToAction("Index");
            }

            return View("Editar", usuario);
        }
    }
}
