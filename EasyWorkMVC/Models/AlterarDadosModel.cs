using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EasyWorkMVC.Models
{
    public class AlterarDadosModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o nome do usuário")]
        public string NovoNome { get; set; }

        [Required(ErrorMessage = "Digite o e-mail do usuário")]
        public string NovoEmail { get; set; }

        [Required(ErrorMessage = "Digite o nome de login do usuário")]
        public string NovoLogin { get; set; }
    }
}
