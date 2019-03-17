using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace _2Blogs.Controllers
{
    [Route("[controller]/[action]")]
    public class JSController : Controller
    {
        public IActionResult JavaScriptPage()
        {
            return View();
        }
    }
}