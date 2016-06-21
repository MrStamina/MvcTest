using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly2.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipTypes MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }
    }
}