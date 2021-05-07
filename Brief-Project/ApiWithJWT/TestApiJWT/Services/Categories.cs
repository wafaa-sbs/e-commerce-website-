
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApiJWT.Models;

namespace TestApiJWT.Services
{
    public class Categories : ICategories
    {
        private readonly ApplicationDbContext _adb;

        public Categories(ApplicationDbContext adb)
        {
            _adb = adb;
        }

        public async Task<Categorie> Create(Categorie categorie)
        {
            _adb.Categories.Add(categorie);

            await _adb.SaveChangesAsync();

            return categorie;

        }

        public async Task Delete(Guid id)
        {
            var CatToDelete = await _adb.Categories.FindAsync(id);

            _adb.Categories.Remove(CatToDelete);
            await _adb.SaveChangesAsync();
        }

        public async Task<IEnumerable<Categorie>> Get()
        {
            return await _adb.Categories.ToListAsync();
        }

        public async Task<Categorie> Get(Guid id)
        {
            return await _adb.Categories.FindAsync(id);
        }

        public async Task Update(Categorie categorie)
        {
            _adb.Entry(categorie).State = EntityState.Modified;
            await _adb.SaveChangesAsync();
        }
    }
}
