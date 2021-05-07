using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestApiJWT.Models
{
    public class Order
    {
        [Key]
        [ForeignKey("UserId,PanierId")]
        public Guid Id  { get; set; }

        public DateTime Date { get; set; }

        public  Double TotalPrice { get; set; }

        public Guid UserId { get; set; }

        public Guid PanierId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public Panier Panier { get; set; }
    }
}
