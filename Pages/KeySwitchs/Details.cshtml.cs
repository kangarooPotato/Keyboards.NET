using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Keyboards.Modles;

namespace Keyboards.Pages.KeySwitchs
{
    public class DetailsModel : PageModel
    {
        private readonly KeyboardContext _context;

        public DetailsModel(KeyboardContext context)
        {
            _context = context;
        }

        public Keyboard Keyboard { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Keyboard = await _context.Keyboard.FirstOrDefaultAsync(m => m.ID == id);

            if (Keyboard == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
