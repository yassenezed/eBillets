using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data.ViewModels
{
    public class RegisterVM
    {
        [Display(Name = "Nom Complet")]
        [Required(ErrorMessage = "Le nom complet est requis")]
        public string FullName { get; set; }

        [Display(Name = "Adresse e-mail")]
        [Required(ErrorMessage = "L'adresse e-mail est requise")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Le mot de passe est requis")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Confirmer le mot de passe")]
        [Required(ErrorMessage = "La confirmation du mot de passe est requise")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Les mots de passe ne correspondent pas")]
        public string ConfirmPassword { get; set; }
    }
}
