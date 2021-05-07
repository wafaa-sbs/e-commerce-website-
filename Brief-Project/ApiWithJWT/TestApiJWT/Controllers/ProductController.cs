using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using TestApiJWT.Models;
using TestApiJWT.Services;

namespace TestApiJWT.Controllers
{

    [ApiController]

    [Route("api/Product")]

    public class ProductController : ControllerBase
    {
        private readonly ApplicationDbContext _adb;

        public ProductController(ApplicationDbContext adb)
        {
            _adb = adb;
        }




        [HttpGet]
        public ActionResult Get(Guid CategorieId)
        {
            return Ok(_adb.Procducts.Where(x => x.CategorieId == CategorieId).ToList());
        }

        [HttpGet("{Id}")]

        public IActionResult GetByid(Guid CategorieId, Guid Id)
        {

            var Currproduct = _adb.Procducts.Where(x => x.CategorieId == CategorieId && x.Id == Id).ToList();

            return Ok(Currproduct);
        }

        [HttpPost]

        public async Task<ActionResult> Create(Guid CategorieId, Product product)
        {

            /* var Currproduct = _adb.Procducts.FirstOrDefault(x => x.CategorieId == product.CategorieId); */


            product.CategorieId = CategorieId;

             _adb.Procducts.Add(product);


             await _adb.SaveChangesAsync();

            return CreatedAtAction(nameof(GetByid), new { CategorieId = CategorieId, Id = product.Id }, product);


        }

        [HttpPut("{Id}")]

        public ActionResult Update(Guid CategorieId, Product product)
        {

            product.CategorieId = CategorieId;

            _adb.Entry(product).State = EntityState.Modified;

            _adb.SaveChanges();

            return NoContent();

        }
    }
}
