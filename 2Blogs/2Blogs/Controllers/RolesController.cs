using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2Blogs.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using _2Blogs.Models.RoleViewModels;
using Microsoft.AspNetCore.Authorization;

namespace _2Blogs.Controllers
{
    [Authorize(Roles = "admin, user")]
    public class RolesController : Controller
    {
        RoleManager<IdentityRole> _roleManager;
        UserManager<ApplicationUser> _userManager;

        //Roles
        public RolesController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }
            
        public ActionResult Index()
        {
            return View(_roleManager.Roles.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(string name)
        {
            IdentityResult result = await _roleManager.CreateAsync(new IdentityRole(name));
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return View(name);
        }
     
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(string id)
        {
            IdentityRole role = await _roleManager.FindByIdAsync(id);
            if(role != null)
            {
                IdentityResult result = await _roleManager.DeleteAsync(role);

            }
            return RedirectToAction("Index");
        }
        //Users
        public ActionResult UserList()
        {
            return View(_userManager.Users.ToList());
        }
        public async Task<IActionResult> Edit(string userId)
        {
            ApplicationUser user = await _userManager.FindByIdAsync(userId);
            if (user != null)
            {
                var userRoles = await _userManager.GetRolesAsync(user);
                var allRoles = _roleManager.Roles.ToList();
                ChangeRoleViewModel model = new ChangeRoleViewModel
                {
                    UserId = user.Id,
                    UserEmail = user.Email,
                    UserRoles = userRoles,
                    AllRoles = allRoles

                };
                return View(model);
                
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(string userId, List<string> roles)
        {
            ApplicationUser user = await _userManager.FindByIdAsync(userId);
            if(user!=null)
            {
                var userRoles = await _userManager.GetRolesAsync(user);
                var allRoles = _roleManager.Roles.ToList();
               // var removedRoles = userRoles.Except(roles);
                await _userManager.RemoveFromRolesAsync(user, userRoles);
                await _userManager.AddToRolesAsync(user, roles);
                return RedirectToAction("UserList");
            }
            return NotFound();
        }
    }
}