using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Keyboards.Models;

namespace Keyboards.Pages.KeySwitchs
{
    public class DeleteModel : PageModel
    {
        private readonly KeyboardContext _context;

        public DeleteModel(KeyboardContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Keyboard = await _context.Keyboard.FindAsync(id);

            if (Keyboard != null)
            {
                _context.Keyboard.Remove(Keyboard);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
