using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace _2Blogs.Controllers
{
    [Produces("application/json")]
    [Route("api/AdminApi")]
    public class AdminApiController : Controller
    {
        RoleManager<IdentityRole> _roleManager;

        public AdminApiController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }
        // GET: api/AdminApi
        [HttpGet]
        public IEnumerable<IdentityRole> Get()
        {
            return _roleManager.Roles.ToList();
        }

        ////// GET: api/AdminApi/5
        ////[HttpGet("{id}", Name = "Get")]
        ////public string Get(int id)
        ////{
        ////    return "value";
        ////}

        ////// POST: api/AdminApi
        ////[HttpPost]
        ////public void Post([FromBody]string value)
        ////{
        ////}

        ////// PUT: api/AdminApi/5
        ////[HttpPut("{id}")]
        ////public void Put(int id, [FromBody]string value)
        ////{
        ////}

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            IdentityRole role = await _roleManager.FindByIdAsync(id);
            if(role != null)
            {
                IdentityResult result = await _roleManager.DeleteAsync(role);
            }
            return NoContent();
        }
    }
}
