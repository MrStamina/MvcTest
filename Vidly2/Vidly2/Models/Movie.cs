using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Vidly2.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Veuillez indiquer le titre du film")]
        [StringLength(75,ErrorMessage ="Le titre est trop long")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Veuillez indiquer la date de sortie")]
        public DateTime ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }

        [Required(ErrorMessage ="Veuillez indiquer la quantité en stock")]
        public int Stock { get; set; }

        public Genre Genre { get; set; }
        [Required(ErrorMessage ="Selectionnez un genre")]
        public byte GenreId { get; set; }
    }
}