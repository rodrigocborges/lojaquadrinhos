using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LojaQuadrinhos.Models
{
    public class RegisterUserViewModel
    {
        [Required(ErrorMessage = "O campo email é obrigatório!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O campo senha é obrigatório!")]
        [StringLength(32, ErrorMessage = "A senha tem que ter no mínimo 8 caracteres e no máximo 32!", MinimumLength = 8)]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "As senhas não conferem!")]
        public string ConfirmPassword { get; set; }
    }

    public class LoginUserViewModel
    {
        [Required(ErrorMessage = "O campo email é obrigatório!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O campo senha é obrigatório!")]
        [StringLength(32, ErrorMessage = "A senha tem que ter no mínimo 8 caracteres e no máximo 32!", MinimumLength = 8)]
        public string Password { get; set; }
    }
}
