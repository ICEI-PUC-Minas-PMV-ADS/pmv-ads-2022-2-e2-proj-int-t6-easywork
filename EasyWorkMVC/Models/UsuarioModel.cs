﻿using EasyWorkMVC.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EasyWorkMVC.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o nome do Usuário")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Digite o login do Usuário")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Digite o e-mail do Usuário")]
        [EmailAddress(ErrorMessage = "O e-mail informado não é válido!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "informe o perfil do Usuário")]
        public PerfilEnum? Perfil { get; set; }
        [Required(ErrorMessage = "Digite a senha do Usuário")]
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataAtualizacao { get; set; }

        public bool SenhaValida(string senha)
        {
            return Senha == senha;
        }
    }
}
