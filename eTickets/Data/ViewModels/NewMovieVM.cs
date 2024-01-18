using eTickets.Data;
using eTickets.Data.Base;
using eTickets.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class NewMovieVM
    {
        public int Id { get; set; }

        [Display(Name = "Nom du film")]
        [Required(ErrorMessage = "Le nom est requis")]
        public string Name { get; set; }

        [Display(Name = "Description du film")]
        [Required(ErrorMessage = "La description est requise")]
        public string Description { get; set; }

        [Display(Name = "Prix en €")]
        [Required(ErrorMessage = "Le prix est requis")]
        public double Price { get; set; }

        [Display(Name = "URL de l'affiche du film")]
        [Required(ErrorMessage = "L'URL de l'affiche du film est requis")]
        public string ImageURL { get; set; }

        [Display(Name = "Date de début du film")]
        [Required(ErrorMessage = "La date de début est requise")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Date de fin du film")]
        [Required(ErrorMessage = "La date de fin est requise")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Sélectionnez une catégorie")]
        [Required(ErrorMessage = "La catégorie du film est requise")]
        public MovieCategory MovieCategory { get; set; }

        //Relations
        [Display(Name = "Sélectionnez acteur(s)")]
        [Required(ErrorMessage = "Le(s) acteur(s) du film est(sont) requis")]
        public List<int> ActorIds { get; set; }

        [Display(Name = "Sélectionnez un cinema")]
        [Required(ErrorMessage = "Le cinema du film est requis")]
        public int CinemaId { get; set; }

        [Display(Name = "Sélectionnez un producteur")]
        [Required(ErrorMessage = "Le producteur du film est requis")]
        public int ProducerId { get; set; }
    }
}
