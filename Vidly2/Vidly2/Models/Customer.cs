using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Vidly2.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Le nom est obligatoire") ]
        [StringLength(75,ErrorMessage ="Le nom est trop long")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Veuillez indiquer votre date de naissance")]
        public DateTime DateOfBirth { get; set; }
        [Required(ErrorMessage ="Veuillez cocher la case")]
        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipTypes MembershipType { get; set; }
        [Required(ErrorMessage ="Choisissez le type d'abonnement")]
        public byte MembershipTypeId { get; set; }
    }
}