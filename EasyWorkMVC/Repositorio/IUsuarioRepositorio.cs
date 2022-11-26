using EasyWorkMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyWorkMVC.Repositorio
{
    public interface IUsuarioRepositorio
    {
        UsuarioModel BuscarPorLogin(string login);
        UsuarioModel BuscarPorEmailELogin(string email, string login);
        List<UsuarioModel> BuscarTodos();
        UsuarioModel ListarPorId(int id);
        UsuarioModel Adicionar(UsuarioModel usuario); 
        UsuarioModel Atualizar(UsuarioModel usuario);
        UsuarioModel AlterarSenha(AlterarSenhaModel alterarSenhaModel);
        UsuarioModel AlterarDados(AlterarDadosModel alterarDadosModel);
        UsuarioModel ApagarUsuario(ApagarUsuarioModel apagarUsuarioModel);
        bool Apagar(int id);
    }
}
