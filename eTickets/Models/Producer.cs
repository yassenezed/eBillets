using eTickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Producer : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Photo de profil")]
        [Required(ErrorMessage = "La photo de profil est requise")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Nom complet")]
        [Required(ErrorMessage = "Le nom complet est requis")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Le nom complet doit comporter entre 3 et 50 caractères")]
        public string FullName { get; set; }

        [Display(Name = "Biographie")]
        [Required(ErrorMessage = "La biographie est requise")]
        public string Bio { get; set; }

        //Relations
        public List<Movie> Movies { get; set; }
    }
}
