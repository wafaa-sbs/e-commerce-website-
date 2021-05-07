using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestApiJWT.Models
{
    public class Categorie
    {

        [Key]
        public Guid id { get; set; }

        [Column(TypeName = "nvarchar(100)")] 
        public string CategorieName { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string Description { get; set; }

        public ICollection<Product> Products { get; set; }


    }
}
