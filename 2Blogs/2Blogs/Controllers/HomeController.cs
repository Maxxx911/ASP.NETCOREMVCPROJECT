using _2Blogs.Data;
using _2Blogs.Models;
using _2Blogs.Models.BlogViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace _2Blogs.Controllers
{
    public class HomeController:Controller
    {
        private UserManager<ApplicationUser> _userManager;
        private ApplicationDbContext db;
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
            BlogViewModel blogViewModel = new BlogViewModel(_userManager.Users.ToList(), db.Blogs.ToList(), db.Tags.ToList());
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
        public async Task<IActionResult> CreateBlog(CreateBlogViewModel createBlogViewModel)
        {
            if (ModelState.IsValid)
            {
                List<Tag> tags = new List<Tag>();
                tags.Add(new Tag { Name = createBlogViewModel.tagName });
                Blog newBlog = new Blog()
                {
                    Description = createBlogViewModel.blogDescription,
                    Title = createBlogViewModel.blogTitle,
                    Tags = tags
                };



                ApplicationUser user = await _userManager.GetUserAsync(HttpContext.User);
                newBlog.User = user;
                db.Blogs.Add(newBlog);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(createBlogViewModel);
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
