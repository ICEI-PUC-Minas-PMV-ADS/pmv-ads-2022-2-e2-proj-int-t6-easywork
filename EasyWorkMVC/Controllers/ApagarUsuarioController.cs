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
    public class ApagarUsuarioController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private readonly ISessao _sessao;

        public ApagarUsuarioController(IUsuarioRepositorio usuarioRepositorio,
                                       ISessao sessao)
        {
            _usuarioRepositorio = usuarioRepositorio;
            _sessao = sessao;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Apagar(ApagarUsuarioModel apagarUsuarioModel)
        {

            try
            {
                UsuarioModel usuarioLogado = _sessao.BuscarSessaoDoUsuario();
                apagarUsuarioModel.Id = usuarioLogado.Id;

                if (ModelState.IsValid)
                {
                    _usuarioRepositorio.ApagarUsuario(apagarUsuarioModel);
                    _sessao.RemoverSessaoUsuario(); //não tem
                    //TempData["MensagemSucesso"] = "Conta excluída com sucesso!";
                    return RedirectToAction("Index", "Login");
                    //return View("Index", apagarUsuarioModel);
                }

                return View("Index", apagarUsuarioModel); //return View("Index", apagarUsuarioModel);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos excluir a sua conta, tente novamente, detalhe do erro: {erro.Message}";
                return View("Index", apagarUsuarioModel);
            }

        }
    }
}
