using eTickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Cinema : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Logo du cinema")]
        [Required(ErrorMessage = "Le logo du cinema est requis")]
        public string Logo { get; set; }

        [Display(Name = "Nom du cinema")]
        [Required(ErrorMessage = "Le nom du cinema est requis")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "La description du cinema est requise")]
        public string Description { get; set; }

        //Relations
        public List<Movie> Movies { get; set; }
    }
}
