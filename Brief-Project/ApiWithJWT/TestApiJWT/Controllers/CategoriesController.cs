using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using TestApiJWT.Models;
using TestApiJWT.Services;

namespace TestApiJWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CategoriesController : ControllerBase
    {
        private readonly ICategories _categories;

        public CategoriesController (ICategories categories)
        {
            _categories = categories;
        }

        // Get Categories
        [HttpGet]
        public async Task<IEnumerable<Categorie>> GetCategorie()
        {
            return await _categories.Get();
        }

        // Get id  Categories
        [HttpGet("{id}")]

        public async Task<ActionResult<Categorie>> GetCategorie(Guid id)
        {
            return await _categories.Get(id);
        }

        // Post Categories

        [HttpPost]
        public async Task<ActionResult<Categorie>> PostCategorie([FromBody] Categorie categorie)
        {
            var newCat = await _categories.Create(categorie);
            return CreatedAtAction(nameof(GetCategorie), new { id = newCat.id }, newCat);
        }


        // Put  Categories

        [HttpPut]
        public async Task<ActionResult> PutCategorie(Guid id, [FromBody] Categorie categorie)
        {
            if (id != categorie.id)
            {
                return BadRequest();
            }

            await _categories.Update(categorie);

            return NoContent();
        }


        // DELETE Categories

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var CatToDelete = await _categories.Get(id);
            if (CatToDelete == null)
                return NotFound();

            await _categories.Delete(CatToDelete.id);
            return NoContent();
        }

    }
}
