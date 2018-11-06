using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using storeStation.Models;

namespace storeStation.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly storeStation.Models.StationContext _context;

        public IndexModel(storeStation.Models.StationContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Products.ToListAsync();
        }
    }
}
