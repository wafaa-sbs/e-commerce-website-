
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TestApiJWT.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Categorie> Categories { get; set; }

        public DbSet<Product> Procducts { get; set; }

        public DbSet<Image> Images { get; set; }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<Panier> Paniers { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<PanierDetails> PanierDetails { get; set; }

    }
}