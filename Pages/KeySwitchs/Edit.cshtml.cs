using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Keyboards.Models;

namespace Keyboards.Pages.KeySwitchs
{
    public class EditModel : PageModel
    {
        private readonly KeyboardContext _context;

        public EditModel(KeyboardContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Keyboard Keyboard { get; set; }

        public async Task<IActionResult> OnGetAsync(int? special)
        {
            if (special == null)
            {
                return NotFound();
            }

            Keyboard = await _context.Keyboard.FirstOrDefaultAsync(m => m.ID == special);

            if (Keyboard == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Keyboard).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KeyboardExists(Keyboard.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool KeyboardExists(int special)
        {
            return _context.Keyboard.Any(e => e.ID == special);
        }
    }
}
