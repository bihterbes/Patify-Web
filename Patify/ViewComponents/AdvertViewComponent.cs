using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Patify.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patify.ViewComponents
{
    public class AdvertViewComponent : ViewComponent
    {
        private ApplicationDbContext _context;

        public AdvertViewComponent(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var item = await _context.Advert.ToListAsync();

            return View(item);
        }
    }
}
