using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly2.Models;

namespace Vidly2.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Le nom est obligatoire")]
        [StringLength(75, ErrorMessage = "Le nom est trop long")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Veuillez indiquer votre date de naissance")]
        [Min18YearsIfAMember]
        public DateTime DateOfBirth { get; set; }
        [Required(ErrorMessage = "Veuillez cocher la case")]
        public bool IsSubscribedToNewsletter { get; set; }
        
        public byte MembershipTypeId { get; set; }
    }
}