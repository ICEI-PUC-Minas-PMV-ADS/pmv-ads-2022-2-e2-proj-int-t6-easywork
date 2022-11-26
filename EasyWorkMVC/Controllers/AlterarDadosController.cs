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
    public class AlterarDadosController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private readonly ISessao _sessao;

        public AlterarDadosController(IUsuarioRepositorio usuarioRepositorio,
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

        public IActionResult Alterar(AlterarDadosModel alterarDadosModel)
        {
            try
            {
                UsuarioModel usuarioLogado = _sessao.BuscarSessaoDoUsuario();
                alterarDadosModel.Id = usuarioLogado.Id;

                if(ModelState.IsValid)
                {
                    _usuarioRepositorio.AlterarDados(alterarDadosModel);
                    TempData["MensagemSucesso"] = "Dados alterados com sucesso!";
                    return View("Index", alterarDadosModel);
                }

                return View("Index", alterarDadosModel);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos alterar seus dados, tente novamente, detalhe do erro: {erro.Message}";
                return View("Index", alterarDadosModel);
            }
        }
    }
}
