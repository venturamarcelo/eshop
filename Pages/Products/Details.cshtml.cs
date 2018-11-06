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
    public class DetailsModel : PageModel
    {
        private readonly storeStation.Models.StationContext _context;

        public DetailsModel(storeStation.Models.StationContext context)
        {
            _context = context;
        }

        public Product Product { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product = await _context.Products.FirstOrDefaultAsync(m => m.productID == id);

            if (Product == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
