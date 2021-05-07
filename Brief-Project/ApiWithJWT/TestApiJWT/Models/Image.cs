using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestApiJWT.Models
{
    public class Image
    {
        [Key]
        [ForeignKey("ProcuctId")]
        public Guid Id { get; set; }

        public string  image { get; set; }

        [NotMapped]
        [FileExtensions(Extensions = "jpg,jpeg,png")]
        public IFormFile File { get; set; }

        public Guid ProductId { get; set; }

        public Product Product { get; set; }
    }
}
