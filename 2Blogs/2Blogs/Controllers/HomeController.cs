using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _2Blogs.Models;
using _2Blogs.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using _2Blogs.Models.BlogViewModels;
using Microsoft.AspNetCore.Authorization;

namespace _2Blogs.Controllers
{
    public class HomeController : Controller
    {
        private UserManager<ApplicationUser> _userManager;
        ApplicationDbContext db;
        public HomeController(ApplicationDbContext context, UserManager<ApplicationUser> usr)
        {
            db = context;
            _userManager = usr;
        }
        public IActionResult Index()
        {
            
            return View();
        }
        public IActionResult BlogList()
        {
            BlogViewModel blogViewModel = new BlogViewModel(_userManager.Users.ToList(), db.Blogs.ToList());
            return View(blogViewModel);
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        [HttpGet]
        [Authorize(Roles = "admin, user")]
        public IActionResult CreateBlog()
        {
            return View();
        }
        [HttpPost]
        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> CreateBlog(Blog blog)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = await _userManager.GetUserAsync(HttpContext.User);
                blog.User = user;
                db.Blogs.Add(blog);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(blog);
        }

        public async Task<IActionResult> DeleateBlog(string blogid)
        {
            Blog delblog = await db.Blogs.FindAsync(blogid);
            
            if (delblog != null)
            {
                db.Blogs.Remove(delblog);
                await db.SaveChangesAsync();
                return RedirectToAction("BlogList");
            }
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
