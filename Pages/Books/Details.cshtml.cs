using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Postolache_Elena_Lab2.Data;
using Postolache_Elena_Lab2.Models;

namespace Postolache_Elena_Lab2.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly Postolache_Elena_Lab2.Data.Postolache_Elena_Lab2Context _context;

        public DetailsModel(Postolache_Elena_Lab2.Data.Postolache_Elena_Lab2Context context)
        {
            _context = context;
        }

        public Book Book { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book = await _context.Book
             .Include(b => b.Author)
             .Include(b => b.Publisher)
             .Include(b => b.BookCategories)
              .ThenInclude(bc => bc.Category)
             .FirstOrDefaultAsync(m => m.ID == id);

            if (Book == null)
            {
                return NotFound();
            }

            return Page();

        }
    }
}
