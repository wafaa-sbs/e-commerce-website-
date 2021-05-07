
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApiJWT.Models;

namespace TestApiJWT.Services
{
   public interface ICategories
    {

        Task<IEnumerable<Categorie>> Get();
        Task<Categorie> Get(Guid id);
        Task<Categorie> Create(Categorie categorie);
        Task Update(Categorie categorie);
        Task Delete(Guid id);
         
    }
}
