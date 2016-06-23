using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly2.Models;
using System.ComponentModel.DataAnnotations;

namespace Vidly2.Views.ViewModels
{
    public class MoviesFormViewModel
    {
        public int? Id { get; set; }

        [Required(ErrorMessage = "Veuillez indiquer le titre du film")]
        [StringLength(75, ErrorMessage = "Le titre est trop long")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Veuillez indiquer la date de sortie")]
        public DateTime? ReleaseDate { get; set; }
        

        [Required]
        [Range(1, 20, ErrorMessage = "La quantité doit être comprise entre 1 et 20")]
        public int? Stock { get; set; }

        
        [Required(ErrorMessage = "Selectionnez un genre")]
        public byte GenreId { get; set; }
        public IEnumerable<Genre> Genre { get; set; }

        public string Title
        {
            get
            {
                return Id != 0 ? "Modifier film" : "Nouveau Film";                 
            }
        }
        public MoviesFormViewModel()
        {
            Id = 0;
        }
        public MoviesFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            GenreId = movie.GenreId;
            Stock = movie.Stock;

        }
    }
}