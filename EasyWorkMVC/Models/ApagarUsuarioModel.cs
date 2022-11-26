using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EasyWorkMVC.Models
{
    public class ApagarUsuarioModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o login do usuário")]
        public string ExcluirLogin { get; set; }

        [Required(ErrorMessage = "Digite a senha do usuário")]
        public string ExcluirSenha { get; set; }
    }
}
