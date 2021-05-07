using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestApiJWT.Models
{
    public class Panier
    {
        [Key]
        [ForeignKey("UserId")]

        public Guid Id { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public Double TotalPrice { get; set; }

        public Guid UserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
    }
}
