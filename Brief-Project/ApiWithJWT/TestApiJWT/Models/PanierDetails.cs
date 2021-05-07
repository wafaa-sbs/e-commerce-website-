
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestApiJWT.Models
{
    public class PanierDetails
    {
        [Key]
        [ForeignKey("ProductId,PanierId,")]

        public Guid Id { get; set; }

        public DateTime DateOfAdd { get; set; }

        public Guid PanierId { get; set; }

        public Guid ProductId { get; set; }

        public Product Product { get; set; }

        public Panier Panier { get; set; }



    }
}
