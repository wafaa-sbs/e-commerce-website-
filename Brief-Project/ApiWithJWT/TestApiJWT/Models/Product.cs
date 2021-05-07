using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestApiJWT.Models
{
    public class Product
    {
        [Key]
        [ForeignKey("CategorieId")]

        public Guid Id { get; set; }

        public DateTime Date { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string ProductName { get; set; }


        [Column(TypeName = "nvarchar(100)")]
        public decimal Price { get; set; }


        [Column(TypeName = "nvarchar(200)")]
        public decimal ImageName { get; set; }

      

        public Guid CategorieId { get; set; }

        public Categorie Categorie { get; set; }


    }
}
