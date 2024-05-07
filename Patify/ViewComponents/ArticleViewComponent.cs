using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Patify.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patify.ViewComponents
{
    public class ArticleViewComponent : ViewComponent
    {
        private ApplicationDbContext _context;

        public ArticleViewComponent(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var item = await _context.Article.ToListAsync();
            return View(item);
        }
    }
}
