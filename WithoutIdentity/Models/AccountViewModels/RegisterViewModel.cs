using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WithoutIdentity.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required]
        [PasswordPropertyText]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        [StringLength(100, ErrorMessage = "O campo {0} deve ter no mínimo e no máxio {1} caracteres", MinimumLength = 8)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar senha")]
        [Compare("Password", ErrorMessage = "As senhas devem ser iguais")]
        public string ConfirmPassword { get; set; }
    }
}
