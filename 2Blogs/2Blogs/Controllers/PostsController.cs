using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2Blogs.Data;
using _2Blogs.Models;
using _2Blogs.Models.BlogViewModels;
using _2Blogs.Models.PostViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _2Blogs.Controllers
{
    public class PostsController : Controller
    {
        // GET: Posts
        ApplicationDbContext _context;
        public PostsController(ApplicationDbContext context)
        {
            _context = context;
        }
        public ActionResult PostList(string id)
        {
            ListPostViewModel listPostViewModel = new ListPostViewModel();
            var posts = _context.Posts.ToList().Where(p => p.BlogID == id);
            listPostViewModel.Posts = posts;
            listPostViewModel.Blog = _context.Blogs.Find(id);

            return View(listPostViewModel);
        }

        // GET: Posts/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Posts/Create
        public async Task<IActionResult> Create(string id)
        {
            Blog blog = await _context.Blogs.FindAsync(id);

            CreatePostViewModel model = new CreatePostViewModel() { BlogId = blog.Id, Blog = blog };
            return View(model);
        }

        // POST: Posts/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(CreatePostViewModel model)
        {
            Post newPost = new Post()
            {
                Description = model.Description,
                Title = model.Title,
                BlogID = model.BlogId
            };
            _context.Posts.Add(newPost);
            await _context.SaveChangesAsync();
            return RedirectToAction("PostList", new {id = newPost.BlogID });

        }

        // GET: Posts/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Posts/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: Posts/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Posts/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}