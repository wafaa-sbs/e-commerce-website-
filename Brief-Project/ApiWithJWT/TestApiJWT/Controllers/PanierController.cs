using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TestApiJWT.Models;

namespace TestApiJWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PanierController : ControllerBase
    {
        private readonly ApplicationDbContext _adb;
        private readonly UserManager<ApplicationUser> _userManager;

        public PanierController(ApplicationDbContext adb, UserManager<ApplicationUser> userManager)
        {
            _adb = adb;
            _userManager = userManager;
        }

       /* [HttpPost]
*/
        /*public async Task<ActionResult> Create(Panier panier)
        {

           


            *//* var Currproduct = _adb.Procducts.FirstOrDefault(x => x.CategorieId == product.CategorieId); *//*



            var claimsIdentity = this.User.Identity as ClaimsIdentity;
            var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).;
          

         *//*   panier.UserId = guid;*//*


            _adb.Paniers.Add(panier);



            await _adb.SaveChangesAsync();

            return Ok(panier);


        }*/

    }
}
