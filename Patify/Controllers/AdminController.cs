using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Patify.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patify.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        public IActionResult Index()
        {
            return View();
        }

        public AdminController(RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProjectRole role)
        {
            var roleExist = await roleManager.RoleExistsAsync(role.RoleName);

            if(!roleExist)
            {
                var result = await roleManager.CreateAsync(new IdentityRole(role.RoleName));
            }

            return View();
        }
    }
}
